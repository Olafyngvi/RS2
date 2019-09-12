namespace AutoKuca.WinUI.Dijelovi
{
    partial class frmDijelovi
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
            this.dgvDijelovi = new System.Windows.Forms.DataGridView();
            this.DioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModeli = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDijelovi
            // 
            this.dgvDijelovi.AllowUserToAddRows = false;
            this.dgvDijelovi.AllowUserToDeleteRows = false;
            this.dgvDijelovi.AllowUserToOrderColumns = true;
            this.dgvDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijelovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DioId,
            this.Naziv,
            this.Cijena,
            this.Sifra,
            this.Stanje,
            this.Kategorija,
            this.Model,
            this.Obrisi});
            this.dgvDijelovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDijelovi.Location = new System.Drawing.Point(3, 17);
            this.dgvDijelovi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDijelovi.Name = "dgvDijelovi";
            this.dgvDijelovi.ReadOnly = true;
            this.dgvDijelovi.RowHeadersWidth = 51;
            this.dgvDijelovi.RowTemplate.Height = 24;
            this.dgvDijelovi.Size = new System.Drawing.Size(1333, 537);
            this.dgvDijelovi.TabIndex = 0;
            this.dgvDijelovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // DioId
            // 
            this.DioId.DataPropertyName = "DioId";
            this.DioId.HeaderText = "DioId";
            this.DioId.MinimumWidth = 6;
            this.DioId.Name = "DioId";
            this.DioId.ReadOnly = true;
            this.DioId.Visible = false;
            this.DioId.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
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
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.MinimumWidth = 6;
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            this.Sifra.Width = 125;
            // 
            // Stanje
            // 
            this.Stanje.DataPropertyName = "Stanje";
            this.Stanje.HeaderText = "Stanje";
            this.Stanje.MinimumWidth = 6;
            this.Stanje.Name = "Stanje";
            this.Stanje.ReadOnly = true;
            this.Stanje.Width = 125;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            this.Kategorija.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Text = "Obrisi";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDijelovi);
            this.groupBox1.Location = new System.Drawing.Point(61, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1339, 556);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dijelovi";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(960, 121);
            this.cmbKategorija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(161, 24);
            this.cmbKategorija.TabIndex = 1;
            this.cmbKategorija.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(956, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filteri :";
            // 
            // cmbModeli
            // 
            this.cmbModeli.FormattingEnabled = true;
            this.cmbModeli.Location = new System.Drawing.Point(1235, 119);
            this.cmbModeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbModeli.Name = "cmbModeli";
            this.cmbModeli.Size = new System.Drawing.Size(161, 24);
            this.cmbModeli.TabIndex = 3;
            this.cmbModeli.SelectedIndexChanged += new System.EventHandler(this.CmbModeli_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(65, 116);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 31);
            this.txtSearch.TabIndex = 4;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(255, 116);
            this.btnPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 31);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // frmDijelovi
            // 
            this.AcceptButton = this.btnPretraga;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 779);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbModeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDijelovi";
            this.Text = "Dijelovi";
            this.Load += new System.EventHandler(this.FrmDijelovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModeli;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn DioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
    }
}