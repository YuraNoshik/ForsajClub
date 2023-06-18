using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source = (localdb); Initial Catalog = GraphWorkers1; Persist Security Info = False; User ID = DESKTOP-V1OO69E";
            SqlConnection connection = new SqlConnection(connectionString);
            try
                {                 
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                     connection.Close();
                    }
                MessageBox.Show("Success!");
            }
                catch (SqlException)
                {
                    MessageBox.Show("Подключение недоступно!");
                }
               

        }
    }
}
