using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace PerehodPolyakova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var date = DateTime.ParseExact("27.03.2004", "dd.MM.yyyy", CultureInfo.InvariantCulture);
           
            var age = DateTime.Now.Year - date.Year;
            int age2 = Convert.ToInt32(age);

            DateTime a = Convert.ToDateTime(textBox1.Text);
            
            if (a < date && !(a.Year < 1900)) 
            {
                MessageBox.Show("Вы успешно вошлии на сайт!");
            }
            else if (a.Year < 1900)
            {   
                Process.Start("https://ru.wikipedia.org/wiki/Первая_мировая_война");
            }
            else
            {
                Process.Start("https://pl.spb.ru");
            }
            
        }
    }
}
