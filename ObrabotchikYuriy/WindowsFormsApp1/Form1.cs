using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void Click_On(object sender, EventArgs e)
        {
            this.Click += Form1_Click;
        }
     

        private void Click_Off(object sender, EventArgs e)
        {
            this.Click -= Form1_Click;
        }
    }
}
