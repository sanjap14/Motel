namespace SanjaProgramiranje
{
    partial class Zaposleni
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
            this.btObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPozicija = new System.Windows.Forms.TextBox();
            this.btUnesi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btNoviZaposleni = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKontakt = new System.Windows.Forms.TextBox();
            this.btVrati = new System.Windows.Forms.Button();
            this.cbAktivni = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(26, 18);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(192, 46);
            this.btObrisi.TabIndex = 47;
            this.btObrisi.Text = "Otpusti zaposlenog";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ime";
            this.label1.Visible = false;
            // 
            // tbPozicija
            // 
            this.tbPozicija.Location = new System.Drawing.Point(376, 668);
            this.tbPozicija.Name = "tbPozicija";
            this.tbPozicija.Size = new System.Drawing.Size(210, 29);
            this.tbPozicija.TabIndex = 45;
            this.tbPozicija.Visible = false;
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(975, 598);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(169, 104);
            this.btUnesi.TabIndex = 44;
            this.btUnesi.Text = "Unesi zaposlenog";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Visible = false;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pozicija";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prezime";
            this.label2.Visible = false;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(376, 633);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(210, 29);
            this.tbPrezime.TabIndex = 41;
            this.tbPrezime.Visible = false;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(376, 598);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(210, 29);
            this.tbIme.TabIndex = 40;
            this.tbIme.Visible = false;
            // 
            // btNoviZaposleni
            // 
            this.btNoviZaposleni.Location = new System.Drawing.Point(26, 598);
            this.btNoviZaposleni.Name = "btNoviZaposleni";
            this.btNoviZaposleni.Size = new System.Drawing.Size(169, 104);
            this.btNoviZaposleni.TabIndex = 39;
            this.btNoviZaposleni.Text = "Novi zaposleni";
            this.btNoviZaposleni.UseVisualStyleBackColor = true;
            this.btNoviZaposleni.Click += new System.EventHandler(this.btNoviZaposleni_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(26, 70);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 15;
            this.dataGridView6.RowTemplate.Height = 31;
            this.dataGridView6.Size = new System.Drawing.Size(1249, 509);
            this.dataGridView6.TabIndex = 38;
            this.dataGridView6.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(628, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Plata";
            this.label4.Visible = false;
            // 
            // tbPlata
            // 
            this.tbPlata.Location = new System.Drawing.Point(690, 598);
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.Size = new System.Drawing.Size(210, 29);
            this.tbPlata.TabIndex = 48;
            this.tbPlata.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(605, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Kontakt";
            this.label5.Visible = false;
            // 
            // tbKontakt
            // 
            this.tbKontakt.Location = new System.Drawing.Point(690, 634);
            this.tbKontakt.Name = "tbKontakt";
            this.tbKontakt.Size = new System.Drawing.Size(210, 29);
            this.tbKontakt.TabIndex = 50;
            this.tbKontakt.Visible = false;
            // 
            // btVrati
            // 
            this.btVrati.Location = new System.Drawing.Point(224, 18);
            this.btVrati.Name = "btVrati";
            this.btVrati.Size = new System.Drawing.Size(192, 46);
            this.btVrati.TabIndex = 52;
            this.btVrati.Text = "Vrati zaposlenog";
            this.btVrati.UseVisualStyleBackColor = true;
            this.btVrati.Click += new System.EventHandler(this.btVrati_Click);
            // 
            // cbAktivni
            // 
            this.cbAktivni.AutoSize = true;
            this.cbAktivni.Location = new System.Drawing.Point(979, 35);
            this.cbAktivni.Name = "cbAktivni";
            this.cbAktivni.Size = new System.Drawing.Size(296, 29);
            this.cbAktivni.TabIndex = 54;
            this.cbAktivni.Text = "Prikazuj samo aktivne radnike";
            this.cbAktivni.UseVisualStyleBackColor = true;
            this.cbAktivni.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Zaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbAktivni);
            this.Controls.Add(this.btVrati);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKontakt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlata);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPozicija);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.btNoviZaposleni);
            this.Controls.Add(this.dataGridView6);
            this.Name = "Zaposleni";
            this.Size = new System.Drawing.Size(1300, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPozicija;
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btNoviZaposleni;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKontakt;
        private System.Windows.Forms.Button btVrati;
        private System.Windows.Forms.CheckBox cbAktivni;
    }
}
