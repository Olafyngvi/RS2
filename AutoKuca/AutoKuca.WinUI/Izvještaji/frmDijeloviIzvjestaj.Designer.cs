namespace AutoKuca.WinUI.Izvještaji
{
    partial class frmDijeloviIzvjestaj
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
            this.dgvDijelovi = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProdanih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.DatumNarudžbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zavrsena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.Label();
            this.txtUkupnoTrenutni = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDijelovi);
            this.groupBox1.Location = new System.Drawing.Point(51, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prodani dijelovi";
            // 
            // dgvDijelovi
            // 
            this.dgvDijelovi.AllowUserToAddRows = false;
            this.dgvDijelovi.AllowUserToDeleteRows = false;
            this.dgvDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijelovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Model,
            this.Cijena,
            this.Sifra,
            this.BrojProdanih});
            this.dgvDijelovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDijelovi.Location = new System.Drawing.Point(3, 16);
            this.dgvDijelovi.Name = "dgvDijelovi";
            this.dgvDijelovi.ReadOnly = true;
            this.dgvDijelovi.Size = new System.Drawing.Size(542, 239);
            this.dgvDijelovi.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // BrojProdanih
            // 
            this.BrojProdanih.DataPropertyName = "BrojProdanih";
            this.BrojProdanih.HeaderText = "Broj prodanih";
            this.BrojProdanih.Name = "BrojProdanih";
            this.BrojProdanih.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNarudzbe);
            this.groupBox2.Location = new System.Drawing.Point(664, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zavrsene Narudzbe";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatumNarudžbe,
            this.Zavrsena});
            this.dgvNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbe.Location = new System.Drawing.Point(3, 16);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.Size = new System.Drawing.Size(378, 239);
            this.dgvNarudzbe.TabIndex = 0;
            // 
            // DatumNarudžbe
            // 
            this.DatumNarudžbe.DataPropertyName = "DatumNarudžbe";
            this.DatumNarudžbe.HeaderText = "Datum narudzbe";
            this.DatumNarudžbe.Name = "DatumNarudžbe";
            this.DatumNarudžbe.ReadOnly = true;
            // 
            // Zavrsena
            // 
            this.Zavrsena.DataPropertyName = "Zavrsena";
            this.Zavrsena.HeaderText = "Zavrsena";
            this.Zavrsena.Name = "Zavrsena";
            this.Zavrsena.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtUkupno
            // 
            this.txtUkupno.AutoSize = true;
            this.txtUkupno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkupno.Location = new System.Drawing.Point(48, 44);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.Size = new System.Drawing.Size(0, 31);
            this.txtUkupno.TabIndex = 2;
            // 
            // txtUkupnoTrenutni
            // 
            this.txtUkupnoTrenutni.AutoSize = true;
            this.txtUkupnoTrenutni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUkupnoTrenutni.Location = new System.Drawing.Point(51, 103);
            this.txtUkupnoTrenutni.Name = "txtUkupnoTrenutni";
            this.txtUkupnoTrenutni.Size = new System.Drawing.Size(0, 31);
            this.txtUkupnoTrenutni.TabIndex = 3;
            // 
            // frmDijeloviIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 682);
            this.Controls.Add(this.txtUkupnoTrenutni);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDijeloviIzvjestaj";
            this.Text = "Dijelovi i narudzbe";
            this.Load += new System.EventHandler(this.FrmDijeloviIzvjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudžbe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zavrsena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUkupno;
        private System.Windows.Forms.Label txtUkupnoTrenutni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProdanih;
    }
}