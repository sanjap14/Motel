namespace SanjaProgramiranje
{
    partial class Narudzbine
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
            this.btUnesi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNovaNarudzbina = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.nmBrojStola = new System.Windows.Forms.NumericUpDown();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.dtVreme = new System.Windows.Forms.DateTimePicker();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btUnesiProizvode = new System.Windows.Forms.Button();
            this.rtbPregled = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBrojStola)).BeginInit();
            this.SuspendLayout();
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(26, 18);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(192, 46);
            this.btObrisi.TabIndex = 34;
            this.btObrisi.Text = "Obriši podatak";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(1106, 509);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(169, 104);
            this.btUnesi.TabIndex = 33;
            this.btUnesi.Text = "Unesi narudžbinu";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Visible = false;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Datum";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Zaposleni";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Broj stola";
            this.label1.Visible = false;
            // 
            // btNovaNarudzbina
            // 
            this.btNovaNarudzbina.Location = new System.Drawing.Point(26, 481);
            this.btNovaNarudzbina.Name = "btNovaNarudzbina";
            this.btNovaNarudzbina.Size = new System.Drawing.Size(169, 104);
            this.btNovaNarudzbina.TabIndex = 27;
            this.btNovaNarudzbina.Text = "Nova narudžbina";
            this.btNovaNarudzbina.UseVisualStyleBackColor = true;
            this.btNovaNarudzbina.Click += new System.EventHandler(this.btNovaNarudzbina_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(26, 70);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 72;
            this.dataGridView4.RowTemplate.Height = 31;
            this.dataGridView4.Size = new System.Drawing.Size(1249, 400);
            this.dataGridView4.TabIndex = 26;
            this.dataGridView4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellValueChanged);
            // 
            // nmBrojStola
            // 
            this.nmBrojStola.Location = new System.Drawing.Point(348, 483);
            this.nmBrojStola.Name = "nmBrojStola";
            this.nmBrojStola.Size = new System.Drawing.Size(210, 29);
            this.nmBrojStola.TabIndex = 36;
            this.nmBrojStola.Visible = false;
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(348, 518);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(210, 32);
            this.cbZaposleni.TabIndex = 37;
            this.cbZaposleni.Visible = false;
            // 
            // dtVreme
            // 
            this.dtVreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVreme.Location = new System.Drawing.Point(348, 591);
            this.dtVreme.Name = "dtVreme";
            this.dtVreme.Size = new System.Drawing.Size(210, 29);
            this.dtVreme.TabIndex = 38;
            this.dtVreme.Visible = false;
            // 
            // dtDatum
            // 
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDatum.Location = new System.Drawing.Point(348, 556);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(210, 29);
            this.dtDatum.TabIndex = 39;
            this.dtDatum.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Vreme";
            this.label4.Visible = false;
            // 
            // btUnesiProizvode
            // 
            this.btUnesiProizvode.Location = new System.Drawing.Point(348, 626);
            this.btUnesiProizvode.Name = "btUnesiProizvode";
            this.btUnesiProizvode.Size = new System.Drawing.Size(210, 76);
            this.btUnesiProizvode.TabIndex = 41;
            this.btUnesiProizvode.Text = "Unesi proizvode";
            this.btUnesiProizvode.UseVisualStyleBackColor = true;
            this.btUnesiProizvode.Visible = false;
            this.btUnesiProizvode.Click += new System.EventHandler(this.btStaviProizvode_Click);
            // 
            // rtbPregled
            // 
            this.rtbPregled.Location = new System.Drawing.Point(584, 509);
            this.rtbPregled.Name = "rtbPregled";
            this.rtbPregled.ReadOnly = true;
            this.rtbPregled.Size = new System.Drawing.Size(477, 193);
            this.rtbPregled.TabIndex = 42;
            this.rtbPregled.Text = "";
            this.rtbPregled.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Pregled unetih proizvoda";
            this.label5.Visible = false;
            // 
            // Narudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbPregled);
            this.Controls.Add(this.btUnesiProizvode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.dtVreme);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.nmBrojStola);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNovaNarudzbina);
            this.Controls.Add(this.dataGridView4);
            this.Name = "Narudzbine";
            this.Size = new System.Drawing.Size(1300, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBrojStola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNovaNarudzbina;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.NumericUpDown nmBrojStola;
        private System.Windows.Forms.ComboBox cbZaposleni;
        private System.Windows.Forms.DateTimePicker dtVreme;
        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btUnesiProizvode;
        private System.Windows.Forms.RichTextBox rtbPregled;
        private System.Windows.Forms.Label label5;
    }
}
