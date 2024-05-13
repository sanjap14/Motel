namespace SanjaProgramiranje
{
    partial class SelekcijaProizvoda
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
            this.dgRaspolozivi = new System.Windows.Forms.DataGridView();
            this.dgUneti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btStavi = new System.Windows.Forms.Button();
            this.btZavrsi = new System.Windows.Forms.Button();
            this.btIsprazni = new System.Windows.Forms.Button();
            this.nmKolicina = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btUkloni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRaspolozivi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUneti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRaspolozivi
            // 
            this.dgRaspolozivi.AllowUserToAddRows = false;
            this.dgRaspolozivi.AllowUserToDeleteRows = false;
            this.dgRaspolozivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgRaspolozivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRaspolozivi.Location = new System.Drawing.Point(12, 53);
            this.dgRaspolozivi.Name = "dgRaspolozivi";
            this.dgRaspolozivi.ReadOnly = true;
            this.dgRaspolozivi.RowHeadersWidth = 5;
            this.dgRaspolozivi.RowTemplate.Height = 31;
            this.dgRaspolozivi.Size = new System.Drawing.Size(519, 501);
            this.dgRaspolozivi.TabIndex = 0;
            // 
            // dgUneti
            // 
            this.dgUneti.AllowUserToAddRows = false;
            this.dgUneti.AllowUserToDeleteRows = false;
            this.dgUneti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgUneti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUneti.Location = new System.Drawing.Point(728, 53);
            this.dgUneti.Name = "dgUneti";
            this.dgUneti.RowHeadersWidth = 5;
            this.dgUneti.RowTemplate.Height = 31;
            this.dgUneti.Size = new System.Drawing.Size(519, 501);
            this.dgUneti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raspoloživi proizvodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uneti proizvodi";
            // 
            // btStavi
            // 
            this.btStavi.Location = new System.Drawing.Point(537, 115);
            this.btStavi.Name = "btStavi";
            this.btStavi.Size = new System.Drawing.Size(185, 67);
            this.btStavi.TabIndex = 4;
            this.btStavi.Text = "< Unesi izabrani proizvod";
            this.btStavi.UseVisualStyleBackColor = true;
            this.btStavi.Click += new System.EventHandler(this.btStavi_Click);
            // 
            // btZavrsi
            // 
            this.btZavrsi.Location = new System.Drawing.Point(537, 414);
            this.btZavrsi.Name = "btZavrsi";
            this.btZavrsi.Size = new System.Drawing.Size(185, 67);
            this.btZavrsi.TabIndex = 5;
            this.btZavrsi.Text = "Završi sa korpom";
            this.btZavrsi.UseVisualStyleBackColor = true;
            this.btZavrsi.Click += new System.EventHandler(this.btZavrsi_Click);
            // 
            // btIsprazni
            // 
            this.btIsprazni.Location = new System.Drawing.Point(537, 487);
            this.btIsprazni.Name = "btIsprazni";
            this.btIsprazni.Size = new System.Drawing.Size(185, 67);
            this.btIsprazni.TabIndex = 6;
            this.btIsprazni.Text = "Isprazni korpu";
            this.btIsprazni.UseVisualStyleBackColor = true;
            this.btIsprazni.Click += new System.EventHandler(this.btIsprazni_Click);
            // 
            // nmKolicina
            // 
            this.nmKolicina.Location = new System.Drawing.Point(537, 80);
            this.nmKolicina.Name = "nmKolicina";
            this.nmKolicina.Size = new System.Drawing.Size(185, 29);
            this.nmKolicina.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kolicina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ukupna cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "0 din.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btUkloni
            // 
            this.btUkloni.Location = new System.Drawing.Point(537, 188);
            this.btUkloni.Name = "btUkloni";
            this.btUkloni.Size = new System.Drawing.Size(185, 67);
            this.btUkloni.TabIndex = 11;
            this.btUkloni.Text = "Ukloni izabrani proizvod >";
            this.btUkloni.UseVisualStyleBackColor = true;
            this.btUkloni.Click += new System.EventHandler(this.btUkloni_Click);
            // 
            // SelekcijaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 578);
            this.Controls.Add(this.btUkloni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmKolicina);
            this.Controls.Add(this.btIsprazni);
            this.Controls.Add(this.btZavrsi);
            this.Controls.Add(this.btStavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgUneti);
            this.Controls.Add(this.dgRaspolozivi);
            this.Name = "SelekcijaProizvoda";
            this.Text = "SelekcijaProizvoda";
            ((System.ComponentModel.ISupportInitialize)(this.dgRaspolozivi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUneti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRaspolozivi;
        private System.Windows.Forms.DataGridView dgUneti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btStavi;
        private System.Windows.Forms.Button btZavrsi;
        private System.Windows.Forms.Button btIsprazni;
        private System.Windows.Forms.NumericUpDown nmKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUkloni;
    }
}