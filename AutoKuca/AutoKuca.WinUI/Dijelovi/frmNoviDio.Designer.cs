namespace AutoKuca.WinUI.Dijelovi
{
    partial class frmNoviDio
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
            this.Naziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.Cijena = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.Model = new System.Windows.Forms.Label();
            this.Kategorija = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.Stanje = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbMarke = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Naziv
            // 
            this.Naziv.AutoSize = true;
            this.Naziv.Location = new System.Drawing.Point(9, 31);
            this.Naziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(37, 15);
            this.Naziv.TabIndex = 0;
            this.Naziv.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(11, 47);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(153, 19);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(11, 93);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(2);
            this.txtCijena.Multiline = true;
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(153, 19);
            this.txtCijena.TabIndex = 3;
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCijena_KeyPress);
            // 
            // Cijena
            // 
            this.Cijena.AutoSize = true;
            this.Cijena.Location = new System.Drawing.Point(9, 77);
            this.Cijena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cijena.Name = "Cijena";
            this.Cijena.Size = new System.Drawing.Size(42, 15);
            this.Cijena.TabIndex = 2;
            this.Cijena.Text = "Cijena";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(11, 141);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifra.Multiline = true;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(153, 19);
            this.txtSifra.TabIndex = 5;
            // 
            // Sifra
            // 
            this.Sifra.AutoSize = true;
            this.Sifra.Location = new System.Drawing.Point(9, 124);
            this.Sifra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(32, 15);
            this.Sifra.TabIndex = 4;
            this.Sifra.Text = "Sifra";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(14, 336);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(153, 21);
            this.cmbModel.TabIndex = 6;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(12, 319);
            this.Model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(42, 15);
            this.Model.TabIndex = 7;
            this.Model.Text = "Model";
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Location = new System.Drawing.Point(9, 219);
            this.Kategorija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(63, 15);
            this.Kategorija.TabIndex = 9;
            this.Kategorija.Text = "Kategorija";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(11, 236);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(153, 21);
            this.cmbKategorija.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(87, 373);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(80, 28);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(11, 190);
            this.txtStanje.Margin = new System.Windows.Forms.Padding(2);
            this.txtStanje.Multiline = true;
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(153, 19);
            this.txtStanje.TabIndex = 12;
            this.txtStanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStanje_KeyPress);
            // 
            // Stanje
            // 
            this.Stanje.AutoSize = true;
            this.Stanje.Location = new System.Drawing.Point(9, 174);
            this.Stanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Stanje.Name = "Stanje";
            this.Stanje.Size = new System.Drawing.Size(42, 15);
            this.Stanje.TabIndex = 11;
            this.Stanje.Text = "Stanje";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbMarke
            // 
            this.cmbMarke.FormattingEnabled = true;
            this.cmbMarke.Location = new System.Drawing.Point(11, 287);
            this.cmbMarke.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarke.Name = "cmbMarke";
            this.cmbMarke.Size = new System.Drawing.Size(153, 21);
            this.cmbMarke.TabIndex = 13;
            this.cmbMarke.SelectedIndexChanged += new System.EventHandler(this.CmbMarke_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marka";
            // 
            // frmNoviDio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarke);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.Stanje);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.Kategorija);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.Cijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.Naziv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNoviDio";
            this.Text = "Dio";
            this.Load += new System.EventHandler(this.FrmNoviDio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label Cijena;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label Sifra;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Kategorija;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtStanje;
        private System.Windows.Forms.Label Stanje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbMarke;
        private System.Windows.Forms.Label label1;
    }
}