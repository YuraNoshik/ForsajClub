using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Замена_пикселя
{
    public partial class Form1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        PictureBox mainPB = new PictureBox();
        Bitmap picRefresh;
        
        public Form1()
        {
            InitializeComponent();
            
            pbMain.MouseClick += new MouseEventHandler(mainPB_MouseClick);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pbMain.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbMain.Image = new Bitmap(openFileDialog.FileName);
                picRefresh = new Bitmap(openFileDialog.FileName);
                
            }
            
            flowLayoutPanel1.Controls.Add(pbMain);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "*новый файл";
            save.DefaultExt = "jpg";
            save.Filter = "jpg files (*.jpg)|*.jpg";

            if (!(pbMain.Image == null))
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pbMain.Image.Save(save.FileName);
                }
            }
        }

        private void btPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbDesiredColor.BackColor = colorDialog1.Color;
            }
        }

        private void btRecolor_Click(object sender, EventArgs e)
        {
            try             //проверка наличия изображения
                            //Обработать каждый пиксель изображения
            {
                for (int i = 0; i < pbMain.Image.Height - 1; i++)
                {
                    for (int j = 0; j < pbMain.Image.Width - 1; j++)
                    {
                        //Получить цвет текущего пикселя
                        Color color = ((Bitmap)pbMain.Image).GetPixel(j, i);
                        //Проверить каждую составляющую цвета на попадание в диапазон с допуском
                        if (color.R - trackDopusk.Value / 2 <= pbSourceColor.BackColor.R
                             && color.R + trackDopusk.Value / 2 >= pbSourceColor.BackColor.R
                             && color.G - trackDopusk.Value / 2 <= pbSourceColor.BackColor.G
                             && color.G + trackDopusk.Value / 2 >= pbSourceColor.BackColor.G
                             && color.B - trackDopusk.Value / 2 <= pbSourceColor.BackColor.B
                             && color.B + trackDopusk.Value / 2 >= pbSourceColor.BackColor.B)
                        {
                            //Взять цвет для окрашивания
                            Color color2 = pbSourceColor.BackColor;
                            int colorB = color.B - color2.B;
                            int colorG = color.G - color2.G;
                            int colorR = color.R - color2.R;
                            if (pbDesiredColor.BackColor.R + colorR < 0)
                                colorR = pbDesiredColor.BackColor.R;
                            if (pbDesiredColor.BackColor.G + colorG < 0)
                                colorG = pbDesiredColor.BackColor.G;
                            if (pbDesiredColor.BackColor.B + colorB < 0)
                                colorB = pbDesiredColor.BackColor.B;
                            if (pbDesiredColor.BackColor.R + colorR > 255)
                                colorR = 255 - pbDesiredColor.BackColor.R;
                            if (pbDesiredColor.BackColor.G + colorG > 255)
                                colorG = 255 - pbDesiredColor.BackColor.G;
                            if (pbDesiredColor.BackColor.B + colorB > 255)
                                colorB = 255 - pbDesiredColor.BackColor.B;
                            //Образовать новый цвет
                            color2 = Color.FromArgb(255, pbDesiredColor.BackColor.R + colorR,
                                                                             pbDesiredColor.BackColor.G + colorG,
                                                                             pbDesiredColor.BackColor.B + colorB);
                            //Окрасить созданным цветом текущий пиксель
                            ((Bitmap)pbMain.Image).SetPixel(j, i, color2);
                        }
                    }
                }
                pbMain.Refresh();
            }
            catch
            {
                MessageBox.Show("Проблема с изображением. Может его нет?",
                                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private Color GetColorAt(Point point)
        {

            return ((Bitmap)pbMain.Image).GetPixel(point.X, point.Y);
        }
        private void mainPB_MouseClick(object sender, MouseEventArgs e) //тут получаю координаты пикселя по клику и окрашиваю пикчербокс в новый цвет
        {
            Color pixelColor = new Color();
            pixelColor = GetColorAt(e.Location);
            pbSourceColor.BackColor = pixelColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbDesiredColor.BackColor = Color.FromArgb(trackDopusk.Value, trackRed.Value, trackGreen.Value, trackBlue.Value);
        }

        private void исходноеИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbMain.Image = picRefresh;
            picRefresh = new Bitmap(openFileDialog.FileName);
        }

        
    }
}
