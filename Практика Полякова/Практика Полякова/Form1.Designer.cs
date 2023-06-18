
namespace Практика_Полякова
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponedelnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtornik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sreda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chetverg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyatnitsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subbota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.subbota});
            this.dataGridView1.Location = new System.Drawing.Point(27, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // ponedelnik
            // 
            this.ponedelnik.HeaderText = "ПН";
            this.ponedelnik.Name = "ponedelnik";
            // 
            // vtornik
            // 
            this.vtornik.HeaderText = "ВТ";
            this.vtornik.Name = "vtornik";
            // 
            // sreda
            // 
            this.sreda.HeaderText = "СР";
            this.sreda.Name = "sreda";
            // 
            // chetverg
            // 
            this.chetverg.HeaderText = "ЧТ";
            this.chetverg.Name = "chetverg";
            // 
            // pyatnitsa
            // 
            this.pyatnitsa.HeaderText = "ПТ";
            this.pyatnitsa.Name = "pyatnitsa";
            // 
            // subbota
            // 
            this.subbota.HeaderText = "СБ";
            this.subbota.Name = "subbota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponedelnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtornik;
        private System.Windows.Forms.DataGridViewTextBoxColumn sreda;
        private System.Windows.Forms.DataGridViewTextBoxColumn chetverg;
        private System.Windows.Forms.DataGridViewTextBoxColumn pyatnitsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn subbota;
    }
}

