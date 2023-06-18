using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Double BatteryPercentage = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String a;
            a = textBox1.Text;
            //for (Double i = 90; i >= 0; i--)
            //{
                BatteryPercentage = Convert.ToDouble(a);
                if (BatteryPercentage <= 20)
                {
                    label1.Text = "powerOff";
                    textBox1.Text = " ";
                }
                else
                {
                    
                    Random random = new Random();
                    a = a + random.Next(10);
                    label2.Text = a;
                }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            label1.Text = " ";
        }
    }
}
