namespace SanjaProgramiranje
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodavnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(7, 60);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(709, 390);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.prodavnicaToolStripMenuItem,
            this.zaposleniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervacijeToolStripMenuItem,
            this.sobeToolStripMenuItem,
            this.gostiToolStripMenuItem});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.rezervacijeToolStripMenuItem.Text = "Rezervacije";
            this.rezervacijeToolStripMenuItem.Click += new System.EventHandler(this.rezervacijeToolStripMenuItem_Click);
            // 
            // sobeToolStripMenuItem
            // 
            this.sobeToolStripMenuItem.Name = "sobeToolStripMenuItem";
            this.sobeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sobeToolStripMenuItem.Text = "Sobe";
            this.sobeToolStripMenuItem.Click += new System.EventHandler(this.sobeToolStripMenuItem_Click);
            // 
            // gostiToolStripMenuItem
            // 
            this.gostiToolStripMenuItem.Name = "gostiToolStripMenuItem";
            this.gostiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.gostiToolStripMenuItem.Text = "Gosti";
            this.gostiToolStripMenuItem.Click += new System.EventHandler(this.gostiToolStripMenuItem_Click);
            // 
            // prodavnicaToolStripMenuItem
            // 
            this.prodavnicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudžbineToolStripMenuItem,
            this.artikliToolStripMenuItem});
            this.prodavnicaToolStripMenuItem.Name = "prodavnicaToolStripMenuItem";
            this.prodavnicaToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.prodavnicaToolStripMenuItem.Text = "Restoran";
            // 
            // narudžbineToolStripMenuItem
            // 
            this.narudžbineToolStripMenuItem.Name = "narudžbineToolStripMenuItem";
            this.narudžbineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.narudžbineToolStripMenuItem.Text = "Narudžbine";
            this.narudžbineToolStripMenuItem.Click += new System.EventHandler(this.narudžbineToolStripMenuItem_Click);
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artikliToolStripMenuItem.Text = "Artikli";
            this.artikliToolStripMenuItem.Click += new System.EventHandler(this.artikliToolStripMenuItem_Click);
            // 
            // zaposleniToolStripMenuItem
            // 
            this.zaposleniToolStripMenuItem.Name = "zaposleniToolStripMenuItem";
            this.zaposleniToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.zaposleniToolStripMenuItem.Text = "Zaposleni";
            this.zaposleniToolStripMenuItem.Click += new System.EventHandler(this.zaposleniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 456);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodavnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniToolStripMenuItem;
    }
}

