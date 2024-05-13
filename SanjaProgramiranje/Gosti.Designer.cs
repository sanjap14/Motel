namespace SanjaProgramiranje
{
    partial class Gosti
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
            this.btUnesi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btNoviGost = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.btObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(975, 598);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(169, 104);
            this.btUnesi.TabIndex = 23;
            this.btUnesi.Text = "Unesi gosta";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Visible = false;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Broj telefona";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 598);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prezime";
            this.label2.Visible = false;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(523, 626);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(210, 29);
            this.tbPrezime.TabIndex = 19;
            this.tbPrezime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ime";
            this.label1.Visible = false;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(297, 626);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(210, 29);
            this.tbIme.TabIndex = 17;
            this.tbIme.Visible = false;
            // 
            // btNoviGost
            // 
            this.btNoviGost.Location = new System.Drawing.Point(26, 598);
            this.btNoviGost.Name = "btNoviGost";
            this.btNoviGost.Size = new System.Drawing.Size(169, 104);
            this.btNoviGost.TabIndex = 16;
            this.btNoviGost.Text = "Novi gost";
            this.btNoviGost.UseVisualStyleBackColor = true;
            this.btNoviGost.Click += new System.EventHandler(this.btNoviGost_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 70);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 72;
            this.dataGridView3.RowTemplate.Height = 31;
            this.dataGridView3.Size = new System.Drawing.Size(1249, 509);
            this.dataGridView3.TabIndex = 15;
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(749, 626);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(210, 29);
            this.tbBroj.TabIndex = 25;
            this.tbBroj.Visible = false;
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(26, 18);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(192, 46);
            this.btObrisi.TabIndex = 26;
            this.btObrisi.Text = "Obriši";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // Gosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btNoviGost);
            this.Controls.Add(this.dataGridView3);
            this.Name = "Gosti";
            this.Size = new System.Drawing.Size(1300, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btNoviGost;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Button btObrisi;
    }
}
