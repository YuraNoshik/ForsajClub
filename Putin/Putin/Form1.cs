using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Putin
{
    public partial class Form1 : Form
    {
        string Putin = "вор";
        string Putin1 = "Вор";
        string Putin2 = "ВОР";
        Image myimage = new Bitmap(@"73XR.gif");
        SoundPlayer music = new SoundPlayer();
        Form2 F = new Form2();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == Putin )
            {
                this.Hide();
                MessageBox.Show("Бля...");
                music.SoundLocation = @"Михаил Кр. feat В. Путин - Даже не о чем говорить.wav";
                music.Play();
                F.ShowDialog();
                Application.Exit();


            }

            if (textBox1.Text == Putin1)
            {
                this.Hide();
                MessageBox.Show("Бля...");
                music.SoundLocation = @"Михаил Кр. feat В. Путин - Даже не о чем говорить.wav";
                music.Play();
                F.ShowDialog();
                Application.Exit();


            }
            if (textBox1.Text == Putin2)
            {
                this.Hide();
                MessageBox.Show("Бля...");
                music.SoundLocation = @"Михаил Кр. feat В. Путин - Даже не о чем говорить.wav";
                music.Play();
                F.ShowDialog();
                Application.Exit();


            }
            else
            {
                MessageBox.Show("Ответ неверный, тебе ПИЗДА!!!!!!!!! Последний четтверг живешь!!! Тикай с городу, пока не поздно...");

            }
        }
        protected void Form1_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
