namespace AutoKuca.WinUI
{
    partial class frmDijeloviIndex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDijeloviIndex));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijeloviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziDijeloveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviDioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziMarkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikaziModeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtWelcome = new System.Windows.Forms.Label();
            this.prikaziDijeloveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviDioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbeToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.dijeloviToolStripMenuItem,
            this.kategorijeToolStripMenuItem,
            this.markeToolStripMenuItem,
            this.modeliToolStripMenuItem,
            this.izvjestajiToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            this.narudzbeToolStripMenuItem.Click += new System.EventHandler(this.NarudzbeToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            this.klijentiToolStripMenuItem.Click += new System.EventHandler(this.KlijentiToolStripMenuItem_Click);
            // 
            // dijeloviToolStripMenuItem
            // 
            this.dijeloviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziDijeloveToolStripMenuItem1,
            this.dodajNoviDioToolStripMenuItem1});
            this.dijeloviToolStripMenuItem.Name = "dijeloviToolStripMenuItem";
            this.dijeloviToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.dijeloviToolStripMenuItem.Text = "Dijelovi";
            // 
            // prikaziDijeloveToolStripMenuItem1
            // 
            this.prikaziDijeloveToolStripMenuItem1.Name = "prikaziDijeloveToolStripMenuItem1";
            this.prikaziDijeloveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.prikaziDijeloveToolStripMenuItem1.Text = "Prikazi dijelove";
            this.prikaziDijeloveToolStripMenuItem1.Click += new System.EventHandler(this.PrikaziDijeloveToolStripMenuItem1_Click);
            // 
            // dodajNoviDioToolStripMenuItem1
            // 
            this.dodajNoviDioToolStripMenuItem1.Name = "dodajNoviDioToolStripMenuItem1";
            this.dodajNoviDioToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.dodajNoviDioToolStripMenuItem1.Text = "Dodaj novi dio";
            this.dodajNoviDioToolStripMenuItem1.Click += new System.EventHandler(this.DodajNoviDioToolStripMenuItem1_Click);
            // 
            // kategorijeToolStripMenuItem
            // 
            this.kategorijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziToolStripMenuItem,
            this.dodajNovuToolStripMenuItem});
            this.kategorijeToolStripMenuItem.Name = "kategorijeToolStripMenuItem";
            this.kategorijeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijeToolStripMenuItem.Text = "Kategorije";
            // 
            // prikaziToolStripMenuItem
            // 
            this.prikaziToolStripMenuItem.Name = "prikaziToolStripMenuItem";
            this.prikaziToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.prikaziToolStripMenuItem.Text = "Prikazi kategorije";
            this.prikaziToolStripMenuItem.Click += new System.EventHandler(this.PrikaziToolStripMenuItem_Click);
            // 
            // dodajNovuToolStripMenuItem
            // 
            this.dodajNovuToolStripMenuItem.Name = "dodajNovuToolStripMenuItem";
            this.dodajNovuToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajNovuToolStripMenuItem.Text = "Dodaj novu";
            this.dodajNovuToolStripMenuItem.Click += new System.EventHandler(this.DodajNovuToolStripMenuItem_Click);
            // 
            // markeToolStripMenuItem
            // 
            this.markeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziMarkeToolStripMenuItem,
            this.dodajNovuToolStripMenuItem1});
            this.markeToolStripMenuItem.Name = "markeToolStripMenuItem";
            this.markeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.markeToolStripMenuItem.Text = "Marke";
            // 
            // prikaziMarkeToolStripMenuItem
            // 
            this.prikaziMarkeToolStripMenuItem.Name = "prikaziMarkeToolStripMenuItem";
            this.prikaziMarkeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.prikaziMarkeToolStripMenuItem.Text = "Prikazi marke";
            this.prikaziMarkeToolStripMenuItem.Click += new System.EventHandler(this.PrikaziMarkeToolStripMenuItem_Click);
            // 
            // dodajNovuToolStripMenuItem1
            // 
            this.dodajNovuToolStripMenuItem1.Name = "dodajNovuToolStripMenuItem1";
            this.dodajNovuToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.dodajNovuToolStripMenuItem1.Text = "Dodaj novu";
            this.dodajNovuToolStripMenuItem1.Click += new System.EventHandler(this.DodajNovuToolStripMenuItem1_Click);
            // 
            // modeliToolStripMenuItem
            // 
            this.modeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikaziModeleToolStripMenuItem,
            this.dodajNoviToolStripMenuItem});
            this.modeliToolStripMenuItem.Name = "modeliToolStripMenuItem";
            this.modeliToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.modeliToolStripMenuItem.Text = "Modeli";
            this.modeliToolStripMenuItem.Click += new System.EventHandler(this.ModeliToolStripMenuItem_Click);
            // 
            // prikaziModeleToolStripMenuItem
            // 
            this.prikaziModeleToolStripMenuItem.Name = "prikaziModeleToolStripMenuItem";
            this.prikaziModeleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.prikaziModeleToolStripMenuItem.Text = "Prikazi modele";
            this.prikaziModeleToolStripMenuItem.Click += new System.EventHandler(this.PrikaziModeleToolStripMenuItem_Click);
            // 
            // dodajNoviToolStripMenuItem
            // 
            this.dodajNoviToolStripMenuItem.Name = "dodajNoviToolStripMenuItem";
            this.dodajNoviToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dodajNoviToolStripMenuItem.Text = "Dodaj novi";
            this.dodajNoviToolStripMenuItem.Click += new System.EventHandler(this.DodajNoviToolStripMenuItem_Click);
            // 
            // izvjestajiToolStripMenuItem
            // 
            this.izvjestajiToolStripMenuItem.Name = "izvjestajiToolStripMenuItem";
            this.izvjestajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvjestajiToolStripMenuItem.Text = "Izvjestaji";
            this.izvjestajiToolStripMenuItem.Click += new System.EventHandler(this.IzvjestajiToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWelcome.Location = new System.Drawing.Point(11, 34);
            this.txtWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(70, 16);
            this.txtWelcome.TabIndex = 4;
            this.txtWelcome.Text = "Dobro dosao";
            // 
            // prikaziDijeloveToolStripMenuItem
            // 
            this.prikaziDijeloveToolStripMenuItem.Name = "prikaziDijeloveToolStripMenuItem";
            this.prikaziDijeloveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prikaziDijeloveToolStripMenuItem.Text = "Prikazi dijelove";
            this.prikaziDijeloveToolStripMenuItem.Click += new System.EventHandler(this.PrikaziDijeloveToolStripMenuItem_Click);
            // 
            // dodajNoviDioToolStripMenuItem
            // 
            this.dodajNoviDioToolStripMenuItem.Name = "dodajNoviDioToolStripMenuItem";
            this.dodajNoviDioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajNoviDioToolStripMenuItem.Text = "Dodaj novi dio";
            // 
            // frmDijeloviIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmDijeloviIndex";
            this.Text = "Auto Kuca NER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDijeloviIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem kategorijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.ToolStripMenuItem prikaziDijeloveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviDioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijeloviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziDijeloveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviDioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziMarkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikaziModeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajiToolStripMenuItem;
    }
}



