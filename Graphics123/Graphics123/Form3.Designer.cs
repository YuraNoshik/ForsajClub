
namespace Graphics123
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponedelnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtornik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sreda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chetverg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pyatnitsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subbota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 401);
            this.dataGridView1.TabIndex = 1;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 402);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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