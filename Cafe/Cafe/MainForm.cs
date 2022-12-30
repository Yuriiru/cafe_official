using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe
{
    enum RowState
    {
        Existed,
        New,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void selectQuery()
        {
            string query = "SELECT * FROM product WHERE (count LIKE '%" + textBox1.Text + "%\' || name LIKE '%" + textBox1.Text + "%\' || plasce_location LIKE '%" + textBox1.Text + "%\')";
            if(comboBox1.SelectedItem.ToString() != "Все")
            {
                query += (" AND type = '" + comboBox1.SelectedItem.ToString() + "'");
            }
            dbConnection.adap.SelectCommand = new MySqlCommand(query, dbConnection.connect);
            dbConnection.connect.Open();
            dbConnection.adap.SelectCommand.ExecuteNonQuery();
            DataTable product = new DataTable();
            dbConnection.adap.Fill(product);
            dbConnection.connect.Close();
            dataGridView1.DataSource = product;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Название продукта";
            dataGridView1.Columns[3].HeaderText = "Количество";
            dataGridView1.Columns[4].HeaderText = "Место хранения";
            dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetString(4), record.GetInt32(5),RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            //dgw.Rows.Clear();

            string queryString = $"SELECT * FROM product";

            MySqlCommand SelectCommand = new MySqlCommand(queryString, dbConnection.connect);

            dbConnection.connect.Open();

            MySqlDataReader reader = SelectCommand.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AdminValidation();
            dbConnection.adap.SelectCommand = new MySqlCommand("SELECT name FROM type", dbConnection.connect);
            dbConnection.connect.Open();
            dbConnection.adap.SelectCommand.ExecuteNonQuery();
            DataTable types = new DataTable();
            dbConnection.adap.Fill(types);
            dbConnection.connect.Close();
            comboBox1.Items.Add("Все");
            foreach(DataRow row in types.Rows)
            {
                comboBox1.Items.Add(row["name"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
            selectQuery();
            //RefreshDataGrid(dataGridView1);
        }
        private void AdminValidation()
        {
            if(User.admin)
            {
                AddProductBtn.Visible = true;
                button_delete.Visible = true;
                button_redact.Visible = true;
            };
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddNewProduct f = new AddNewProduct();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameLabel.Text = "Название: " + dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            Type.Text = "Тип продукта: " + dataGridView1.CurrentRow.Cells["type"].Value.ToString();
            Count.Text = "Количество: " + dataGridView1.CurrentRow.Cells["count"].Value.ToString();
            Plasce_location.Text = "Место хранения: " + dataGridView1.CurrentRow.Cells["plasce_location"].Value.ToString();
            Price.Text = "Цена: " + dataGridView1.CurrentRow.Cells["price"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User.admin = false;
            Authorization f = new Authorization();
            f.Show();
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            Update();
        }

        private void button_redact_Click(object sender, EventArgs e)
        {
            
            //AddNewProduct f = new AddNewProduct();
            //f.ShowDialog();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

           // var id = 
        }
       
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.CurrentCell = null;
            dataGridView1.Rows[index].Visible = false;
                

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
        }

        private void Update()
        {
            dbConnection.connect.Open();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    dbConnection.adap.InsertCommand = new MySqlCommand($"DELETE FROM product WHERE id = {id}", dbConnection.connect);
                    dbConnection.adap.InsertCommand.ExecuteNonQuery();
                    
                }
            }

            dbConnection.connect.Close();
        }
    }
}
