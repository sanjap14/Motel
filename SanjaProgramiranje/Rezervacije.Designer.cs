namespace SanjaProgramiranje
{
    partial class Rezervacije
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btNovaRez = new System.Windows.Forms.Button();
            this.cbGost = new System.Windows.Forms.ComboBox();
            this.cbSoba = new System.Windows.Forms.ComboBox();
            this.cbZaposleni = new System.Windows.Forms.ComboBox();
            this.dtDolazak = new System.Windows.Forms.DateTimePicker();
            this.dtOdlazak = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btUnos = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btNovaRez
            // 
            this.btNovaRez.Location = new System.Drawing.Point(25, 591);
            this.btNovaRez.Name = "btNovaRez";
            this.btNovaRez.Size = new System.Drawing.Size(169, 104);
            this.btNovaRez.TabIndex = 1;
            this.btNovaRez.Text = "Nova rezervacija";
            this.btNovaRez.UseVisualStyleBackColor = true;
            this.btNovaRez.Click += new System.EventHandler(this.btNovaRez_Click);
            // 
            // cbGost
            // 
            this.cbGost.FormattingEnabled = true;
            this.cbGost.Location = new System.Drawing.Point(286, 579);
            this.cbGost.Name = "cbGost";
            this.cbGost.Size = new System.Drawing.Size(152, 32);
            this.cbGost.TabIndex = 2;
            this.cbGost.Visible = false;
            // 
            // cbSoba
            // 
            this.cbSoba.FormattingEnabled = true;
            this.cbSoba.Location = new System.Drawing.Point(444, 579);
            this.cbSoba.Name = "cbSoba";
            this.cbSoba.Size = new System.Drawing.Size(152, 32);
            this.cbSoba.TabIndex = 3;
            this.cbSoba.Visible = false;
            // 
            // cbZaposleni
            // 
            this.cbZaposleni.FormattingEnabled = true;
            this.cbZaposleni.Location = new System.Drawing.Point(602, 579);
            this.cbZaposleni.Name = "cbZaposleni";
            this.cbZaposleni.Size = new System.Drawing.Size(152, 32);
            this.cbZaposleni.TabIndex = 4;
            this.cbZaposleni.Visible = false;
            // 
            // dtDolazak
            // 
            this.dtDolazak.Location = new System.Drawing.Point(814, 552);
            this.dtDolazak.Name = "dtDolazak";
            this.dtDolazak.Size = new System.Drawing.Size(359, 29);
            this.dtDolazak.TabIndex = 5;
            this.dtDolazak.Value = new System.DateTime(2024, 5, 5, 0, 0, 0, 0);
            this.dtDolazak.Visible = false;
            // 
            // dtOdlazak
            // 
            this.dtOdlazak.Location = new System.Drawing.Point(814, 587);
            this.dtOdlazak.Name = "dtOdlazak";
            this.dtOdlazak.Size = new System.Drawing.Size(359, 29);
            this.dtOdlazak.TabIndex = 6;
            this.dtOdlazak.Value = new System.DateTime(2024, 5, 5, 0, 0, 0, 0);
            this.dtOdlazak.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gost";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soba";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Zaposleni";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Od:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Do:";
            this.label5.Visible = false;
            // 
            // btUnos
            // 
            this.btUnos.Location = new System.Drawing.Point(844, 639);
            this.btUnos.Name = "btUnos";
            this.btUnos.Size = new System.Drawing.Size(305, 78);
            this.btUnos.TabIndex = 12;
            this.btUnos.Text = "Unesi rezervaciju";
            this.btUnos.UseVisualStyleBackColor = true;
            this.btUnos.Visible = false;
            this.btUnos.Click += new System.EventHandler(this.btUnos_Click);
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(25, 20);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(192, 46);
            this.btObrisi.TabIndex = 13;
            this.btObrisi.Text = "Obriši podatak";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // Rezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btUnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtOdlazak);
            this.Controls.Add(this.dtDolazak);
            this.Controls.Add(this.cbZaposleni);
            this.Controls.Add(this.cbSoba);
            this.Controls.Add(this.cbGost);
            this.Controls.Add(this.btNovaRez);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rezervacije";
            this.Size = new System.Drawing.Size(1300, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btNovaRez;
        private System.Windows.Forms.ComboBox cbGost;
        private System.Windows.Forms.ComboBox cbSoba;
        private System.Windows.Forms.ComboBox cbZaposleni;
        private System.Windows.Forms.DateTimePicker dtDolazak;
        private System.Windows.Forms.DateTimePicker dtOdlazak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUnos;
        private System.Windows.Forms.Button btObrisi;
    }
}
