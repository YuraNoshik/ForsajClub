using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Graphics123
{
    public partial class Form1 : Form
    {
        Form2 Form2 = new Form2();
        Form3 Form3 = new Form3();
        

        public Form1()
        
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passUser.PasswordChar = '*';
        }

        private void button1_Click(object sender, KeyPressEventArgs e)

        {
            if (!((e.KeyChar == '.' || e.KeyChar == ',') &&
                loginUser.Text.IndexOf('.') == -1 &&
                loginUser.Text.IndexOf(',') == -1))
            {
                e.Handled = true;
                MessageBox.Show("Символ . запрещен!");
            }
            else
            {
                MessageBox.Show("Сотрудник добавлен!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            




            String LoginUser = loginUser.Text;
            String PassUser = passUser.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `auth` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            {
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Добро пожаловать!");
                    MessageBox.Show("Неверно введен пароль!");
                    this.Hide();
                    Form2.ShowDialog();
                }
                else
                    MessageBox.Show("Такой учетной записи нет!");
            }



            



            if (loginUser.Text == string.Empty)
            {
                MessageBox.Show("Не введен логин!");
                return;
            }
            if (loginUser.Text == "Admin12")
            {
                MessageBox.Show("Неверно введен логин!");
                return;
            }

            if (passUser.Text == string.Empty)
            {
                MessageBox.Show("Не введен пароль!");
                return;
            }
            if (passUser.Text == "admin1233")
            {
                MessageBox.Show("Неверно введен пароль!");
                return;
            }

            //if (loginUser.TextLength > 22)
            //{
            //    MessageBox.Show("Превышен лимит на колличество введенных символов в поле Login. MAX - 22");
            //    return;
            //}

            //if (loginUser.TextLength < 6)
            //{
            //    MessageBox.Show("Занижен лимит на колличество введенных символов в поле Login. MIN - 6");
            //    return;
            //}

            //if (passUser.TextLength > 30)
            //{
            //    MessageBox.Show("Превышен лимит на колличество введенных символов в поле Password. MAX - 30");
            //    return;
            //}

            if (passUser.TextLength < 8)
            {
                MessageBox.Show("Занижен лимит на колличество введенных символов в поле Password. MIN - 8");
                return;
            }







            //if (loginUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа _ запрещен в поле Login");
            //    return;
            //}

            //if (loginUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа . запрещен в поле Login");
            //    return;
            //}

            //if (loginUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа , запрещен в поле Login");
            //    return;
            //}

            //if (passUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа - запрещен в поле Password");
            //    return;
            //}

            //if (passUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа _ запрещен в поле Password");
            //    return;
            //}

            //if (passUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод символа . запрещен в поле Password");
            //    return;
            //}

            //if (passUser.TextLength < 6)
            //{
            //    MessageBox.Show("Ввод - в поле ФИО запрещен");
            //    return;
            //}

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3.ShowDialog();
        }
        protected void Form1_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
