namespace AutoKuca.WinUI
{
    partial class frmAdminIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminIndex));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.uposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviUposlenikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaGradovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaRadionicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaRadionicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uvozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUpitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vozilabrojPregledaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodanaVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijeloviINarudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uposleniciToolStripMenuItem,
            this.gradoviToolStripMenuItem,
            this.radioniceToolStripMenuItem,
            this.uvozToolStripMenuItem,
            this.upitiToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // uposleniciToolStripMenuItem
            // 
            this.uposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviUposlenikToolStripMenuItem});
            this.uposleniciToolStripMenuItem.Name = "uposleniciToolStripMenuItem";
            this.uposleniciToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uposleniciToolStripMenuItem.Text = "Uposlenici";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pretragaToolStripMenuItem.Text = "Lista uposlenika";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // noviUposlenikToolStripMenuItem
            // 
            this.noviUposlenikToolStripMenuItem.Name = "noviUposlenikToolStripMenuItem";
            this.noviUposlenikToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.noviUposlenikToolStripMenuItem.Text = "Novi uposlenik";
            this.noviUposlenikToolStripMenuItem.Click += new System.EventHandler(this.NoviUposlenikToolStripMenuItem_Click);
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaGradovaToolStripMenuItem,
            this.noviGradToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // listaGradovaToolStripMenuItem
            // 
            this.listaGradovaToolStripMenuItem.Name = "listaGradovaToolStripMenuItem";
            this.listaGradovaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.listaGradovaToolStripMenuItem.Text = "Lista gradova";
            this.listaGradovaToolStripMenuItem.Click += new System.EventHandler(this.ListaGradovaToolStripMenuItem_Click);
            // 
            // noviGradToolStripMenuItem
            // 
            this.noviGradToolStripMenuItem.Name = "noviGradToolStripMenuItem";
            this.noviGradToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.noviGradToolStripMenuItem.Text = "Novi grad";
            this.noviGradToolStripMenuItem.Click += new System.EventHandler(this.NoviGradToolStripMenuItem_Click);
            // 
            // radioniceToolStripMenuItem
            // 
            this.radioniceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaRadionicaToolStripMenuItem,
            this.novaRadionicaToolStripMenuItem});
            this.radioniceToolStripMenuItem.Name = "radioniceToolStripMenuItem";
            this.radioniceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.radioniceToolStripMenuItem.Text = "Radionice";
            // 
            // listaRadionicaToolStripMenuItem
            // 
            this.listaRadionicaToolStripMenuItem.Name = "listaRadionicaToolStripMenuItem";
            this.listaRadionicaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listaRadionicaToolStripMenuItem.Text = "Lista radionica";
            this.listaRadionicaToolStripMenuItem.Click += new System.EventHandler(this.ListaRadionicaToolStripMenuItem_Click);
            // 
            // novaRadionicaToolStripMenuItem
            // 
            this.novaRadionicaToolStripMenuItem.Name = "novaRadionicaToolStripMenuItem";
            this.novaRadionicaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.novaRadionicaToolStripMenuItem.Text = "Nova radionica";
            this.novaRadionicaToolStripMenuItem.Click += new System.EventHandler(this.NovaRadionicaToolStripMenuItem_Click);
            // 
            // uvozToolStripMenuItem
            // 
            this.uvozToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPodatakaToolStripMenuItem});
            this.uvozToolStripMenuItem.Name = "uvozToolStripMenuItem";
            this.uvozToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.uvozToolStripMenuItem.Text = "Uvoz";
            // 
            // listaPodatakaToolStripMenuItem
            // 
            this.listaPodatakaToolStripMenuItem.Name = "listaPodatakaToolStripMenuItem";
            this.listaPodatakaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listaPodatakaToolStripMenuItem.Text = "Lista podataka";
            this.listaPodatakaToolStripMenuItem.Click += new System.EventHandler(this.ListaPodatakaToolStripMenuItem_Click);
            // 
            // upitiToolStripMenuItem
            // 
            this.upitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaUpitaToolStripMenuItem});
            this.upitiToolStripMenuItem.Name = "upitiToolStripMenuItem";
            this.upitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.upitiToolStripMenuItem.Text = "Upiti";
            // 
            // listaUpitaToolStripMenuItem
            // 
            this.listaUpitaToolStripMenuItem.Name = "listaUpitaToolStripMenuItem";
            this.listaUpitaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.listaUpitaToolStripMenuItem.Text = "Lista upita";
            this.listaUpitaToolStripMenuItem.Click += new System.EventHandler(this.ListaUpitaToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vozilabrojPregledaToolStripMenuItem,
            this.prodanaVozilaToolStripMenuItem,
            this.dijeloviINarudzbeToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // vozilabrojPregledaToolStripMenuItem
            // 
            this.vozilabrojPregledaToolStripMenuItem.Name = "vozilabrojPregledaToolStripMenuItem";
            this.vozilabrojPregledaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.vozilabrojPregledaToolStripMenuItem.Text = "Vozila-broj pregleda";
            this.vozilabrojPregledaToolStripMenuItem.Click += new System.EventHandler(this.VozilabrojPregledaToolStripMenuItem_Click);
            // 
            // prodanaVozilaToolStripMenuItem
            // 
            this.prodanaVozilaToolStripMenuItem.Name = "prodanaVozilaToolStripMenuItem";
            this.prodanaVozilaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.prodanaVozilaToolStripMenuItem.Text = "Prodana vozila";
            this.prodanaVozilaToolStripMenuItem.Click += new System.EventHandler(this.ProdanaVozilaToolStripMenuItem_Click);
            // 
            // dijeloviINarudzbeToolStripMenuItem
            // 
            this.dijeloviINarudzbeToolStripMenuItem.Name = "dijeloviINarudzbeToolStripMenuItem";
            this.dijeloviINarudzbeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dijeloviINarudzbeToolStripMenuItem.Text = "Dijelovi i narudzbe";
            this.dijeloviINarudzbeToolStripMenuItem.Click += new System.EventHandler(this.DijeloviINarudzbeToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
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
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // frmAdminIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmAdminIndex";
            this.Text = "Auto Kuca NER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdminIndex_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem uposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviUposlenikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaGradovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviGradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaRadionicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaRadionicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uvozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUpitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilabrojPregledaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodanaVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijeloviINarudzbeToolStripMenuItem;
        private System.Diagnostics.EventLog eventLog1;
    }
}



