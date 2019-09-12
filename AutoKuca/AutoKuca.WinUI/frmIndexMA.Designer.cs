namespace AutoKuca.WinUI
{
    partial class frmIndexMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndexMA));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoVoziloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novaMarkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledOpremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaOpremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviVozilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledTipovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviTipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojPregledaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodanaVozilaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neodgovoreniUpitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vozilaToolStripMenuItem,
            this.modeliToolStripMenuItem,
            this.markeToolStripMenuItem,
            this.opremaToolStripMenuItem,
            this.tipoviVozilaToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.upitiToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // vozilaToolStripMenuItem
            // 
            this.vozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaVozilaToolStripMenuItem,
            this.novoVoziloToolStripMenuItem});
            this.vozilaToolStripMenuItem.Name = "vozilaToolStripMenuItem";
            this.vozilaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.vozilaToolStripMenuItem.Text = "Vozila";
            // 
            // listaVozilaToolStripMenuItem
            // 
            this.listaVozilaToolStripMenuItem.Name = "listaVozilaToolStripMenuItem";
            this.listaVozilaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.listaVozilaToolStripMenuItem.Text = "Lista vozila";
            this.listaVozilaToolStripMenuItem.Click += new System.EventHandler(this.ListaVozilaToolStripMenuItem_Click);
            // 
            // novoVoziloToolStripMenuItem
            // 
            this.novoVoziloToolStripMenuItem.Name = "novoVoziloToolStripMenuItem";
            this.novoVoziloToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.novoVoziloToolStripMenuItem.Text = "Novo vozilo";
            this.novoVoziloToolStripMenuItem.Click += new System.EventHandler(this.NovoVoziloToolStripMenuItem_Click);
            // 
            // modeliToolStripMenuItem
            // 
            this.modeliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviModelToolStripMenuItem});
            this.modeliToolStripMenuItem.Name = "modeliToolStripMenuItem";
            this.modeliToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.modeliToolStripMenuItem.Text = "Modeli";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.pretragaToolStripMenuItem.Text = "Pregled modela";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.PretragaToolStripMenuItem_Click);
            // 
            // noviModelToolStripMenuItem
            // 
            this.noviModelToolStripMenuItem.Name = "noviModelToolStripMenuItem";
            this.noviModelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.noviModelToolStripMenuItem.Text = "Novi model";
            this.noviModelToolStripMenuItem.Click += new System.EventHandler(this.NoviModelToolStripMenuItem_Click);
            // 
            // markeToolStripMenuItem
            // 
            this.markeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem1,
            this.novaMarkaToolStripMenuItem});
            this.markeToolStripMenuItem.Name = "markeToolStripMenuItem";
            this.markeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.markeToolStripMenuItem.Text = "Marke";
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.pretragaToolStripMenuItem1.Text = "Pregled marki";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.PretragaToolStripMenuItem1_Click);
            // 
            // novaMarkaToolStripMenuItem
            // 
            this.novaMarkaToolStripMenuItem.Name = "novaMarkaToolStripMenuItem";
            this.novaMarkaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.novaMarkaToolStripMenuItem.Text = "Nova marka";
            this.novaMarkaToolStripMenuItem.Click += new System.EventHandler(this.NovaMarkaToolStripMenuItem_Click);
            // 
            // opremaToolStripMenuItem
            // 
            this.opremaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledOpremeToolStripMenuItem,
            this.novaOpremaToolStripMenuItem});
            this.opremaToolStripMenuItem.Name = "opremaToolStripMenuItem";
            this.opremaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.opremaToolStripMenuItem.Text = "Oprema";
            // 
            // pregledOpremeToolStripMenuItem
            // 
            this.pregledOpremeToolStripMenuItem.Name = "pregledOpremeToolStripMenuItem";
            this.pregledOpremeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledOpremeToolStripMenuItem.Text = "Pregled opreme";
            this.pregledOpremeToolStripMenuItem.Click += new System.EventHandler(this.PregledOpremeToolStripMenuItem_Click);
            // 
            // novaOpremaToolStripMenuItem
            // 
            this.novaOpremaToolStripMenuItem.Name = "novaOpremaToolStripMenuItem";
            this.novaOpremaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.novaOpremaToolStripMenuItem.Text = "Nova oprema";
            this.novaOpremaToolStripMenuItem.Click += new System.EventHandler(this.NovaOpremaToolStripMenuItem_Click);
            // 
            // tipoviVozilaToolStripMenuItem
            // 
            this.tipoviVozilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledTipovaToolStripMenuItem,
            this.noviTipToolStripMenuItem});
            this.tipoviVozilaToolStripMenuItem.Name = "tipoviVozilaToolStripMenuItem";
            this.tipoviVozilaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tipoviVozilaToolStripMenuItem.Text = "Tipovi vozila";
            // 
            // pregledTipovaToolStripMenuItem
            // 
            this.pregledTipovaToolStripMenuItem.Name = "pregledTipovaToolStripMenuItem";
            this.pregledTipovaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pregledTipovaToolStripMenuItem.Text = "Pregled tipova";
            this.pregledTipovaToolStripMenuItem.Click += new System.EventHandler(this.PregledTipovaToolStripMenuItem_Click);
            // 
            // noviTipToolStripMenuItem
            // 
            this.noviTipToolStripMenuItem.Name = "noviTipToolStripMenuItem";
            this.noviTipToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.noviTipToolStripMenuItem.Text = "Novi tip";
            this.noviTipToolStripMenuItem.Click += new System.EventHandler(this.NoviTipToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojPregledaToolStripMenuItem,
            this.prodanaVozilaToolStripMenuItem1});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // brojPregledaToolStripMenuItem
            // 
            this.brojPregledaToolStripMenuItem.Name = "brojPregledaToolStripMenuItem";
            this.brojPregledaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.brojPregledaToolStripMenuItem.Text = "Broj pregleda";
            this.brojPregledaToolStripMenuItem.Click += new System.EventHandler(this.BrojPregledaToolStripMenuItem_Click);
            // 
            // prodanaVozilaToolStripMenuItem1
            // 
            this.prodanaVozilaToolStripMenuItem1.Name = "prodanaVozilaToolStripMenuItem1";
            this.prodanaVozilaToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.prodanaVozilaToolStripMenuItem1.Text = "Prodana vozila";
            this.prodanaVozilaToolStripMenuItem1.Click += new System.EventHandler(this.ProdanaVozilaToolStripMenuItem1_Click);
            // 
            // upitiToolStripMenuItem
            // 
            this.upitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neodgovoreniUpitiToolStripMenuItem});
            this.upitiToolStripMenuItem.Name = "upitiToolStripMenuItem";
            this.upitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.upitiToolStripMenuItem.Text = "Upiti";
            // 
            // neodgovoreniUpitiToolStripMenuItem
            // 
            this.neodgovoreniUpitiToolStripMenuItem.Name = "neodgovoreniUpitiToolStripMenuItem";
            this.neodgovoreniUpitiToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.neodgovoreniUpitiToolStripMenuItem.Text = "Lista upita";
            this.neodgovoreniUpitiToolStripMenuItem.Click += new System.EventHandler(this.NeodgovoreniUpitiToolStripMenuItem_Click);
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
            this.toolStripStatusLabel,
            this.toolStripProgressBar1});
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
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(75, 16);
            // 
            // frmIndexMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndexMA";
            this.Text = "Auto Kuca NER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIndexMA_Load);
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
        private System.Windows.Forms.ToolStripMenuItem modeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem markeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novaMarkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledOpremeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaOpremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledTipovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviTipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaVozilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoVoziloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojPregledaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodanaVozilaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neodgovoreniUpitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}



