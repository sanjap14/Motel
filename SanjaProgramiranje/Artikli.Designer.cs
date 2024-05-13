namespace SanjaProgramiranje
{
    partial class Artikli
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
            this.tbCena = new System.Windows.Forms.TextBox();
            this.btUnesi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.btNoviArtikal = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(409, 339);
            this.tbCena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(116, 20);
            this.tbCena.TabIndex = 35;
            this.tbCena.Visible = false;
            // 
            // btUnesi
            // 
            this.btUnesi.Location = new System.Drawing.Point(532, 324);
            this.btUnesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUnesi.Name = "btUnesi";
            this.btUnesi.Size = new System.Drawing.Size(92, 56);
            this.btUnesi.TabIndex = 33;
            this.btUnesi.Text = "Unesi artikal";
            this.btUnesi.UseVisualStyleBackColor = true;
            this.btUnesi.Visible = false;
            this.btUnesi.Click += new System.EventHandler(this.btUnesi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cena";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Količina";
            this.label2.Visible = false;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(285, 339);
            this.tbKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(116, 20);
            this.tbKolicina.TabIndex = 30;
            this.tbKolicina.Visible = false;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(162, 339);
            this.tbNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(116, 20);
            this.tbNaziv.TabIndex = 28;
            this.tbNaziv.Visible = false;
            // 
            // btNoviArtikal
            // 
            this.btNoviArtikal.Location = new System.Drawing.Point(14, 324);
            this.btNoviArtikal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNoviArtikal.Name = "btNoviArtikal";
            this.btNoviArtikal.Size = new System.Drawing.Size(92, 56);
            this.btNoviArtikal.TabIndex = 27;
            this.btNoviArtikal.Text = "Novi artikal";
            this.btNoviArtikal.UseVisualStyleBackColor = true;
            this.btNoviArtikal.Click += new System.EventHandler(this.btNoviArtikal_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(14, 38);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 72;
            this.dataGridView5.RowTemplate.Height = 31;
            this.dataGridView5.Size = new System.Drawing.Size(681, 276);
            this.dataGridView5.TabIndex = 26;
            this.dataGridView5.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Naziv";
            this.label1.Visible = false;
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(14, 10);
            this.btObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(105, 25);
            this.btObrisi.TabIndex = 37;
            this.btObrisi.Text = "Obriši artikal";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // Artikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.btUnesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.btNoviArtikal);
            this.Controls.Add(this.dataGridView5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Artikli";
            this.Size = new System.Drawing.Size(709, 390);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Button btUnesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Button btNoviArtikal;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btObrisi;
    }
}
