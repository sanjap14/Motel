namespace SanjaProgramiranje
{
    partial class Sobe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btNovaSoba = new System.Windows.Forms.Button();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btUnesi = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.Size = new System.Drawing.Size(1249, 509);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // btNovaSoba
            // 
            this.btNovaSoba.Location = new System.Drawing.Point(28, 604);
            this.btNovaSoba.Name = "btNovaSoba";
            this.btNovaSoba.Size = new System.Drawing.Size(169, 104);
            this.btNovaSoba.TabIndex = 2;
            this.btNovaSoba.Text = "Nova soba";
            this.btNovaSoba.UseVisualStyleBackColor = true;
            this.btNovaSoba.Click += new System.EventHandler(this.btNovaSoba_Click);
            // 
            // tbTip
            // 
            this.tbTip.Location = new System.Drawing.Point(311, 632);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(182, 29);
            this.tbTip.TabIndex = 3;
            this.tbTip.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tip sobe";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cena po noćenju";
            this.label2.Visible = false;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(527, 632);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(182, 29);
            this.tbCena.TabIndex = 5;
            this.tbCena.Visible = false;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "0 - Dostupno",
            "1 - Nedostupno"});
            this.cbStatus.Location = new System.Drawing.Point(730, 632);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(182, 32);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            this.label3.Visible = false;
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(977, 604);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(169, 104);
            this.btUnesi.TabIndex = 9;
            this.btUnesi.Text = "Unesi sobu";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Visible = false;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(28, 24);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(192, 46);
            this.btObrisi.TabIndex = 14;
            this.btObrisi.Text = "Obriši podatak";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // Sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.btNovaSoba);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Sobe";
            this.Size = new System.Drawing.Size(1300, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btNovaSoba;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Button btObrisi;
    }
}
