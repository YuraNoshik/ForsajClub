
namespace Graphics123
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FIO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stazh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoriya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponedelnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtornik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sreda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chetverg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyatnitsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subbota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1002, 552);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(994, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График работы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.ponedelnik,
            this.vtornik,
            this.sreda,
            this.chetverg,
            this.pyatnitsa,
            this.subbota,
            this.Smena});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(994, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO2,
            this.PhoneNumber,
            this.Spec,
            this.Stazh,
            this.Kategoriya});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(653, 394);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(664, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(665, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить сотрудника";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FIO2
            // 
            this.FIO2.HeaderText = "ФИО";
            this.FIO2.Name = "FIO2";
            this.FIO2.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 110;
            // 
            // Spec
            // 
            this.Spec.HeaderText = "Специализация";
            this.Spec.Name = "Spec";
            this.Spec.Width = 150;
            // 
            // Stazh
            // 
            this.Stazh.HeaderText = "Стаж работы";
            this.Stazh.Name = "Stazh";
            // 
            // Kategoriya
            // 
            this.Kategoriya.HeaderText = "Категория";
            this.Kategoriya.Name = "Kategoriya";
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.Width = 150;
            // 
            // ponedelnik
            // 
            this.ponedelnik.HeaderText = "ПН";
            this.ponedelnik.Name = "ponedelnik";
            this.ponedelnik.Width = 90;
            // 
            // vtornik
            // 
            this.vtornik.HeaderText = "ВТ";
            this.vtornik.Name = "vtornik";
            this.vtornik.Width = 90;
            // 
            // sreda
            // 
            this.sreda.HeaderText = "СР";
            this.sreda.Name = "sreda";
            this.sreda.Width = 90;
            // 
            // chetverg
            // 
            this.chetverg.HeaderText = "ЧТ";
            this.chetverg.Name = "chetverg";
            this.chetverg.Width = 90;
            // 
            // pyatnitsa
            // 
            this.pyatnitsa.HeaderText = "ПТ";
            this.pyatnitsa.Name = "pyatnitsa";
            this.pyatnitsa.Width = 90;
            // 
            // subbota
            // 
            this.subbota.HeaderText = "СБ";
            this.subbota.Name = "subbota";
            this.subbota.Width = 90;
            // 
            // Smena
            // 
            this.Smena.HeaderText = "Начало/Заверш. смены";
            this.Smena.Name = "Smena";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stazh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoriya;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponedelnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtornik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sreda;
        private System.Windows.Forms.DataGridViewTextBoxColumn chetverg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pyatnitsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn subbota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smena;
    }
}