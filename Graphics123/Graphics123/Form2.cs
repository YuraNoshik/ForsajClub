using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics123
{
    
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            
        }
        protected void Form2_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
