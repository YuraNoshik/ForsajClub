
namespace Замена_пикселя
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbSourceColor = new System.Windows.Forms.PictureBox();
            this.pbDesiredColor = new System.Windows.Forms.PictureBox();
            this.tbDesiredColor = new System.Windows.Forms.TextBox();
            this.tbDopusk = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbSourceColor = new System.Windows.Forms.TextBox();
            this.tbFileLoacation = new System.Windows.Forms.TextBox();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackDopusk = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btRecolor = new System.Windows.Forms.Button();
            this.btPalette = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lable7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.исходноеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа90ГрадусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesiredColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDopusk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.исходноеИзображениеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pbMain);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(487, 437);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(3, 3);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(484, 418);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // pbSourceColor
            // 
            this.pbSourceColor.Location = new System.Drawing.Point(558, 53);
            this.pbSourceColor.Name = "pbSourceColor";
            this.pbSourceColor.Size = new System.Drawing.Size(74, 68);
            this.pbSourceColor.TabIndex = 3;
            this.pbSourceColor.TabStop = false;
            // 
            // pbDesiredColor
            // 
            this.pbDesiredColor.Location = new System.Drawing.Point(558, 154);
            this.pbDesiredColor.Name = "pbDesiredColor";
            this.pbDesiredColor.Size = new System.Drawing.Size(74, 68);
            this.pbDesiredColor.TabIndex = 4;
            this.pbDesiredColor.TabStop = false;
            // 
            // tbDesiredColor
            // 
            this.tbDesiredColor.Location = new System.Drawing.Point(652, 170);
            this.tbDesiredColor.Multiline = true;
            this.tbDesiredColor.Name = "tbDesiredColor";
            this.tbDesiredColor.Size = new System.Drawing.Size(180, 28);
            this.tbDesiredColor.TabIndex = 5;
            // 
            // tbDopusk
            // 
            this.tbDopusk.Location = new System.Drawing.Point(880, 381);
            this.tbDopusk.Multiline = true;
            this.tbDopusk.Name = "tbDopusk";
            this.tbDopusk.Size = new System.Drawing.Size(122, 20);
            this.tbDopusk.TabIndex = 6;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(880, 332);
            this.tbBlue.Multiline = true;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(122, 20);
            this.tbBlue.TabIndex = 7;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(880, 286);
            this.tbGreen.Multiline = true;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(122, 20);
            this.tbGreen.TabIndex = 8;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(880, 237);
            this.tbRed.Multiline = true;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(122, 20);
            this.tbRed.TabIndex = 9;
            // 
            // tbSourceColor
            // 
            this.tbSourceColor.Location = new System.Drawing.Point(652, 68);
            this.tbSourceColor.Multiline = true;
            this.tbSourceColor.Name = "tbSourceColor";
            this.tbSourceColor.Size = new System.Drawing.Size(180, 28);
            this.tbSourceColor.TabIndex = 10;
            // 
            // tbFileLoacation
            // 
            this.tbFileLoacation.Location = new System.Drawing.Point(547, 454);
            this.tbFileLoacation.Multiline = true;
            this.tbFileLoacation.Name = "tbFileLoacation";
            this.tbFileLoacation.Size = new System.Drawing.Size(433, 30);
            this.tbFileLoacation.TabIndex = 11;
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(558, 228);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(282, 45);
            this.trackRed.TabIndex = 12;
            this.trackRed.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackDopusk
            // 
            this.trackDopusk.Location = new System.Drawing.Point(558, 381);
            this.trackDopusk.Maximum = 255;
            this.trackDopusk.Name = "trackDopusk";
            this.trackDopusk.Size = new System.Drawing.Size(282, 45);
            this.trackDopusk.TabIndex = 13;
            // 
            // trackBlue
            // 
            this.trackBlue.Location = new System.Drawing.Point(558, 330);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(282, 45);
            this.trackBlue.TabIndex = 14;
            // 
            // trackGreen
            // 
            this.trackGreen.Location = new System.Drawing.Point(558, 279);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(282, 45);
            this.trackGreen.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Исходный цвет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Желаемый цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Допуск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Синий";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Зеленый";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Красный";
            // 
            // btRecolor
            // 
            this.btRecolor.Location = new System.Drawing.Point(880, 56);
            this.btRecolor.Name = "btRecolor";
            this.btRecolor.Size = new System.Drawing.Size(123, 43);
            this.btRecolor.TabIndex = 22;
            this.btRecolor.Text = "Перекрасить";
            this.btRecolor.UseVisualStyleBackColor = true;
            this.btRecolor.Click += new System.EventHandler(this.btRecolor_Click);
            // 
            // btPalette
            // 
            this.btPalette.Location = new System.Drawing.Point(880, 158);
            this.btPalette.Name = "btPalette";
            this.btPalette.Size = new System.Drawing.Size(123, 43);
            this.btPalette.TabIndex = 23;
            this.btPalette.Text = "Палитра";
            this.btPalette.UseVisualStyleBackColor = true;
            this.btPalette.Click += new System.EventHandler(this.btPalette_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Location = new System.Drawing.Point(544, 429);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(74, 13);
            this.lable7.TabIndex = 24;
            this.lable7.Text = "Путь к файлу";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // исходноеИзображениеToolStripMenuItem
            // 
            this.исходноеИзображениеToolStripMenuItem.Name = "исходноеИзображениеToolStripMenuItem";
            this.исходноеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.исходноеИзображениеToolStripMenuItem.Text = "Исходное изображение";
            this.исходноеИзображениеToolStripMenuItem.Click += new System.EventHandler(this.исходноеИзображениеToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поворотНа90ГрадусовToolStripMenuItem,
            this.поворотНа180ToolStripMenuItem,
            this.отразитьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // поворотНа90ГрадусовToolStripMenuItem
            // 
            this.поворотНа90ГрадусовToolStripMenuItem.Name = "поворотНа90ГрадусовToolStripMenuItem";
            this.поворотНа90ГрадусовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поворотНа90ГрадусовToolStripMenuItem.Text = "Поворот на 90";
            // 
            // поворотНа180ToolStripMenuItem
            // 
            this.поворотНа180ToolStripMenuItem.Name = "поворотНа180ToolStripMenuItem";
            this.поворотНа180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поворотНа180ToolStripMenuItem.Text = "Поворот на 180";
            // 
            // отразитьToolStripMenuItem
            // 
            this.отразитьToolStripMenuItem.Name = "отразитьToolStripMenuItem";
            this.отразитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отразитьToolStripMenuItem.Text = "Отразить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 511);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.btPalette);
            this.Controls.Add(this.btRecolor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackDopusk);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.tbFileLoacation);
            this.Controls.Add(this.tbSourceColor);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbDopusk);
            this.Controls.Add(this.tbDesiredColor);
            this.Controls.Add(this.pbDesiredColor);
            this.Controls.Add(this.pbSourceColor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesiredColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackDopusk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbSourceColor;
        private System.Windows.Forms.PictureBox pbDesiredColor;
        private System.Windows.Forms.TextBox tbDesiredColor;
        private System.Windows.Forms.TextBox tbDopusk;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbSourceColor;
        private System.Windows.Forms.TextBox tbFileLoacation;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TrackBar trackDopusk;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRecolor;
        private System.Windows.Forms.Button btPalette;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem исходноеИзображениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа90ГрадусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьToolStripMenuItem;
    }
}

