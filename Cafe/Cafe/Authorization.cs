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
    //АВТОРИЗАЦИЯ
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                errorMessage.Text = error.Message;
                dbConnection.connect.Close();
            }
        }

        private void Validation()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                throw new Exception("Поля не должны быть пустыми");
            dbConnection.adap.SelectCommand = new MySqlCommand("SELECT * FROM users WHERE login = @login && password = @password", dbConnection.connect);
            dbConnection.adap.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
            dbConnection.adap.SelectCommand.Parameters.AddWithValue("@password", textBox2.Text);
            dbConnection.connect.Open();
            dbConnection.reader = dbConnection.adap.SelectCommand.ExecuteReader();
            if (!dbConnection.reader.Read())
                throw new Exception("Проверьте корректность введенных данных");
            User.admin = Convert.ToBoolean(dbConnection.reader["admin"]);
            dbConnection.connect.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.Show();
            this.Hide();
        }
    }
}
