using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation();
        }
        private void Validation()
        {
            if (textBoxName.Text == "" || textBoxPlace.Text == "" || textBoxCount.Text == "")
            {
                labelErrorEmptyFields.Visible = true;
            }
            else
            {
                dbConnection.adap.InsertCommand = new MySqlCommand("INSERT INTO product(count,type,name,plasce_location,price) VALUES(@count,@type,@name,@plasce_location,@price)", dbConnection.connect);
                dbConnection.adap.InsertCommand.Parameters.AddWithValue("@count", textBoxCount.Text);
                dbConnection.adap.InsertCommand.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());
                dbConnection.adap.InsertCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                dbConnection.adap.InsertCommand.Parameters.AddWithValue("@plasce_location", textBoxPlace.Text);
                dbConnection.adap.InsertCommand.Parameters.AddWithValue("@price", textBox4.Text);
                dbConnection.connect.Open();
                dbConnection.adap.InsertCommand.ExecuteNonQuery();
                dbConnection.connect.Close();
                this.Close();
            }
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            dbConnection.adap.SelectCommand = new MySqlCommand("SELECT name FROM type", dbConnection.connect);
            dbConnection.connect.Open();
            dbConnection.adap.SelectCommand.ExecuteNonQuery();
            DataTable types = new DataTable();
            dbConnection.adap.Fill(types);
            dbConnection.connect.Close();
            foreach (DataRow row in types.Rows)
            {
                comboBox1.Items.Add(row["name"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
    }
}
