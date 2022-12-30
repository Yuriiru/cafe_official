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
    //РЕГИСТРАЦИЯ
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Validation();
                RegistrationQuery();
                MessageBox.Show("Регистрация прошла успешно");
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
            dbConnection.adap.SelectCommand = new MySqlCommand("SELECT * FROM users WHERE login = @login", dbConnection.connect);
            dbConnection.adap.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
            dbConnection.connect.Open();
            dbConnection.reader = dbConnection.adap.SelectCommand.ExecuteReader();
            if (dbConnection.reader.Read())
                throw new Exception("Пользователь с таким логином уже существует");
            dbConnection.connect.Close();
        }
        private void RegistrationQuery()
        {
            dbConnection.adap.InsertCommand = new MySqlCommand("INSERT INTO users(login,password) VALUES (@login,@password)", dbConnection.connect);
            dbConnection.adap.InsertCommand.Parameters.AddWithValue("@login", textBox1.Text);
            dbConnection.adap.InsertCommand.Parameters.AddWithValue("@password", textBox2.Text);
            dbConnection.connect.Open();
            dbConnection.adap.InsertCommand.ExecuteNonQuery();
            dbConnection.connect.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.Show();
            this.Close();
        }
    }
}
