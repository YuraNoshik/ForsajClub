using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupbox1
{
    public partial class Form1 : Form
    {
        int wf, hf;
        private void Form1_Load(object sender, EventArgs e)
        {
            wf = this.Width;
            hf = this.Height;
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Размер_Enter(object sender, EventArgs e)
        {

        }

        private void group_Enter(object sender, EventArgs e)
        {

        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Width > 400)
            {
                this.Width = this.Width - 10;
                this.Height = this.Height - 10;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Width > 400)
            {
                this.Width = this.Width + 10;
                this.Height = this.Height + 10;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void курсорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Height = 508;
            this.Width =  1152; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Height = 980;
            this.Width = 1280;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Height = 900;
            this.Width = 1600;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size - this.Size);
        }

        private void прозрачностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           this.Opacity = 0.5;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int ws = Screen.PrimaryScreen.WorkingArea.Width; //Ширина рабочего стола
            int hs = Screen.PrimaryScreen.WorkingArea.Height;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 50;
        }
    }
}
