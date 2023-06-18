using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Autorization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _connectionString = @"Data Source=MAMA-ПК\SQLEXPRESS; Initial Catalog=TravelAgency;Integrated Security=True";

            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {
                connection.Open();
            }

            catch (SqlException)
            {
                MessageBox.Show("Error");

            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                MessageBox.Show("Success!");
            }


            string cmd = "select * from customers";

            SqlCommand sqlCommand = new SqlCommand(cmd, connection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                var myString = dataReader.GetString(0);

                string[] column0;
            }

            
        }
    }
}
