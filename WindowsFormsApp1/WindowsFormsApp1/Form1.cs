using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        double n = 0.0005;
        double m = 0.0005;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i;
            i = Convert.ToDouble(textBox1.Text);
            double j;
            j = Convert.ToDouble(textBox3.Text);
            double p;
            p = Convert.ToDouble(textBox2.Text);
            p = i + n;
            j = i - m;
        }
    }
}
