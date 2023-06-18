using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuriyNoshik
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        int wf, hf;
        private object button;
        private object myControl;
       
        public Font SelectionFont { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            wf = this.Width;
            hf = this.Height;
            textBox1.Text = Convert.ToString(Screen.PrimaryScreen.Bounds.Size);
            textBox4.Text = Convert.ToString(Screen.PrimaryScreen.WorkingArea);
            textBox2.Text = Convert.ToString(this.Size);
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height / 2 - this.Height / 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (this.Width > 750)

            {
                this.Width = this.Width - 10;
                this.Height = this.Height - 10;
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            Console.WriteLine(resolution);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            {
                if (this.Width >= 750)
                    this.Width = this.Width + 10;
                    this.Height = this.Height + 10;
            }

            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Size - this.Size);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Size = new Size(900, 500);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Size = new Size(1200, 768);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Size = new Size(800, 600);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void случайныйЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cursor cross = Cursors.Cross;
            this.Close();
        }

        private void тонкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void natureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\yuran\OneDrive\Рабочий стол\unnamed.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\yuran\OneDrive\Рабочий стол\car.jpg");
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\yuran\OneDrive\Рабочий стол\city.jpg");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void курсорToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
            this.Cursor = Cursors.WaitCursor;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;

        }  
            private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ws = Screen.PrimaryScreen.WorkingArea.Width; //Ширина рабочего стола
            int hs = Screen.PrimaryScreen.WorkingArea.Height;
            textBox4.Text = ws.ToString();
           
        }

        private void КнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
            button2.BackColor = Color.CornflowerBlue;
            button3.BackColor = Color.CornflowerBlue;
            button4.BackColor = Color.CornflowerBlue;
            button5.BackColor = Color.CornflowerBlue;
            button6.BackColor = Color.CornflowerBlue;
            button7.BackColor = Color.CornflowerBlue;
            button8.BackColor = Color.CornflowerBlue;
            button9.BackColor = Color.CornflowerBlue;
            button10.BackColor = Color.CornflowerBlue;
            button11.BackColor = Color.CornflowerBlue;
            button12.BackColor = Color.CornflowerBlue;
            button13.BackColor = Color.CornflowerBlue;
            button14.BackColor = Color.CornflowerBlue;
            
            



        }

        private void цветаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
            button2.BackColor = Color.CornflowerBlue;
            button3.BackColor = Color.CornflowerBlue;
            button4.BackColor = Color.CornflowerBlue;
            button5.BackColor = Color.CornflowerBlue;
            button6.BackColor = Color.CornflowerBlue;
            button7.BackColor = Color.CornflowerBlue;
            button8.BackColor = Color.CornflowerBlue;
            button9.BackColor = Color.CornflowerBlue;
            button10.BackColor = Color.CornflowerBlue;
            button11.BackColor = Color.CornflowerBlue;
            button12.BackColor = Color.CornflowerBlue;
            button13.BackColor = Color.CornflowerBlue;
            button14.BackColor = Color.CornflowerBlue;
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
            button2.BackColor = Color.DarkRed;
            button3.BackColor = Color.DarkRed;
            button4.BackColor = Color.DarkRed;
            button5.BackColor = Color.DarkRed;
            button6.BackColor = Color.DarkRed;
            button7.BackColor = Color.DarkRed;
            button8.BackColor = Color.DarkRed;
            button9.BackColor = Color.DarkRed;
            button10.BackColor = Color.DarkRed;
            button11.BackColor = Color.DarkRed;
            button12.BackColor = Color.DarkRed;
            button13.BackColor = Color.DarkRed;
            button14.BackColor = Color.DarkRed;
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
            button2.BackColor = Color.DarkRed;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.HotPink;
            button5.BackColor = Color.AliceBlue;
            button6.BackColor = Color.IndianRed;
            button7.BackColor = Color.AntiqueWhite;
            button8.BackColor = Color.Aquamarine;
            button9.BackColor = Color.Azure;
            button10.BackColor = Color.Beige;
            button11.BackColor = Color.Bisque;
            button12.BackColor = Color.Black;
            button13.BackColor = Color.BlanchedAlmond;
            button14.BackColor = Color.BlueViolet;
            
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void разрешитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void запретитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void разрешитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click_1(object sender, EventArgs e)
        
        {

            this.ForeColor = Color.Red;

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.BlueViolet;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Pink;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Pink;
            groupBox2.BackColor = Color.Pink;
            groupBox3.BackColor = Color.Pink;
            groupBox4.BackColor = Color.Pink;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Blue;
            groupBox2.BackColor = Color.Blue;
            groupBox3.BackColor = Color.Blue;
            groupBox4.BackColor = Color.Blue;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Gold;
            groupBox2.BackColor = Color.Gold;
            groupBox3.BackColor = Color.Gold;
            groupBox4.BackColor = Color.Gold;
        }

        private void noneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }
    }
}

   