namespace AutoKuca.WinUI.DetaljiNarudzbe
{
    partial class frmNarudzbeDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalji = new System.Windows.Forms.DataGridView();
            this.DetaljiNarudzbeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.broj = new System.Windows.Forms.Label();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.grad = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.Label();
            this.korisnicko = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDetalji);
            this.groupBox1.Location = new System.Drawing.Point(465, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(596, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke narudzbe";
            // 
            // dgvDetalji
            // 
            this.dgvDetalji.AllowUserToAddRows = false;
            this.dgvDetalji.AllowUserToDeleteRows = false;
            this.dgvDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetaljiNarudzbeId,
            this.Kolicina,
            this.Cijena,
            this.Dio});
            this.dgvDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalji.Location = new System.Drawing.Point(3, 17);
            this.dgvDetalji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDetalji.Name = "dgvDetalji";
            this.dgvDetalji.ReadOnly = true;
            this.dgvDetalji.RowHeadersWidth = 51;
            this.dgvDetalji.RowTemplate.Height = 24;
            this.dgvDetalji.Size = new System.Drawing.Size(590, 296);
            this.dgvDetalji.TabIndex = 0;
            // 
            // DetaljiNarudzbeId
            // 
            this.DetaljiNarudzbeId.HeaderText = "DetaljiNarudzbeId";
            this.DetaljiNarudzbeId.MinimumWidth = 6;
            this.DetaljiNarudzbeId.Name = "DetaljiNarudzbeId";
            this.DetaljiNarudzbeId.ReadOnly = true;
            this.DetaljiNarudzbeId.Visible = false;
            this.DetaljiNarudzbeId.Width = 125;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.MinimumWidth = 6;
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            this.Kolicina.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // Dio
            // 
            this.Dio.DataPropertyName = "Dio";
            this.Dio.HeaderText = "Dio";
            this.Dio.MinimumWidth = 6;
            this.Dio.Name = "Dio";
            this.Dio.ReadOnly = true;
            this.Dio.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDatum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUkupno);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBrojTelefona);
            this.groupBox2.Controls.Add(this.txtGrad);
            this.groupBox2.Controls.Add(this.txtAdresa);
            this.groupBox2.Controls.Add(this.txtKorisnicko);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.broj);
            this.groupBox2.Controls.Add(this.btnZavrsi);
            this.groupBox2.Controls.Add(this.grad);
            this.groupBox2.Controls.Add(this.adresa);
            this.groupBox2.Controls.Add(this.korisnicko);
            this.groupBox2.Controls.Add(this.ime);
            this.groupBox2.Location = new System.Drawing.Point(35, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(363, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o kupcu";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(136, 228);
            this.txtUkupno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(203, 22);
            this.txtUkupno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ukupno KM";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(135, 160);
            this.txtBrojTelefona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(203, 22);
            this.txtBrojTelefona.TabIndex = 9;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(136, 130);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(203, 22);
            this.txtGrad.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(136, 100);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(203, 22);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(136, 69);
            this.txtKorisnicko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(203, 22);
            this.txtKorisnicko.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(136, 31);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(203, 22);
            this.txtIme.TabIndex = 5;
            // 
            // broj
            // 
            this.broj.AutoSize = true;
            this.broj.Location = new System.Drawing.Point(16, 160);
            this.broj.Name = "broj";
            this.broj.Size = new System.Drawing.Size(88, 17);
            this.broj.TabIndex = 4;
            this.broj.Text = "Broj telefona";
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(203, 278);
            this.btnZavrsi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(136, 33);
            this.btnZavrsi.TabIndex = 2;
            this.btnZavrsi.Text = "Zavrsi narudzbu";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.BtnZavrsi_Click);
            // 
            // grad
            // 
            this.grad.AutoSize = true;
            this.grad.Location = new System.Drawing.Point(16, 130);
            this.grad.Name = "grad";
            this.grad.Size = new System.Drawing.Size(40, 17);
            this.grad.TabIndex = 3;
            this.grad.Text = "Grad";
            // 
            // adresa
            // 
            this.adresa.AutoSize = true;
            this.adresa.Location = new System.Drawing.Point(16, 100);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(53, 17);
            this.adresa.TabIndex = 2;
            this.adresa.Text = "Adresa";
            // 
            // korisnicko
            // 
            this.korisnicko.AutoSize = true;
            this.korisnicko.Location = new System.Drawing.Point(16, 69);
            this.korisnicko.Name = "korisnicko";
            this.korisnicko.Size = new System.Drawing.Size(99, 17);
            this.korisnicko.TabIndex = 1;
            this.korisnicko.Text = "Korisnicko ime";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(16, 31);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(91, 17);
            this.ime.TabIndex = 0;
            this.ime.Text = "Ime i prezime";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(135, 196);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(203, 22);
            this.txtDatum.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datum narudzbe";
            // 
            // frmNarudzbeDetalji
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1189, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNarudzbeDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Detalji narudzbi";
            this.Load += new System.EventHandler(this.FrmNarudzbeDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalji)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalji;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetaljiNarudzbeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Label broj;
        private System.Windows.Forms.Label grad;
        private System.Windows.Forms.Label adresa;
        private System.Windows.Forms.Label korisnicko;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
    }
}