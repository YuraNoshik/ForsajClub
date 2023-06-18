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
using System.Data;
using System.Data.SqlClient;

namespace ПП
{
    public partial class Form1 : Form
    {
        public SqlConnection SqlConnection = null;
        Form Form2 = new Form();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Graphics"].ConnectionString);
            SqlConnection.Open();


        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            String LoginUser = loginUser.Text;
            String PassUser = passUser.Text;



            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP ", SqlConnection);
            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Добро пожаловать");
            else
                MessageBox.Show("Такой учетки нет");
            this.Hide();
            Form2.ShowDialog();
        }
    }
}
