namespace AutoKuca.WinUI.Vozila
{
    partial class frmProdana
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
            this.dgvProdana = new System.Windows.Forms.DataGridView();
            this.VoziloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipVozila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdana)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdana
            // 
            this.dgvProdana.AllowUserToAddRows = false;
            this.dgvProdana.AllowUserToDeleteRows = false;
            this.dgvProdana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoziloID,
            this.Model,
            this.Marka,
            this.TipVozila,
            this.Cijena,
            this.Sifra,
            this.Detalji});
            this.dgvProdana.Location = new System.Drawing.Point(9, 80);
            this.dgvProdana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProdana.Name = "dgvProdana";
            this.dgvProdana.ReadOnly = true;
            this.dgvProdana.RowTemplate.Height = 24;
            this.dgvProdana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProdana.Size = new System.Drawing.Size(644, 200);
            this.dgvProdana.TabIndex = 0;
            this.dgvProdana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdana_CellContentClick);
            // 
            // VoziloID
            // 
            this.VoziloID.DataPropertyName = "VoziloId";
            this.VoziloID.HeaderText = "VoziloID";
            this.VoziloID.Name = "VoziloID";
            this.VoziloID.ReadOnly = true;
            this.VoziloID.Visible = false;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // TipVozila
            // 
            this.TipVozila.DataPropertyName = "TipVozila";
            this.TipVozila.HeaderText = "Tip vozila";
            this.TipVozila.Name = "TipVozila";
            this.TipVozila.ReadOnly = true;
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
            this.Sifra.DataPropertyName = "SifraAutomobila";
            this.Sifra.HeaderText = "Šifra automobila";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalji.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalji.Text = "Detalji vozila";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(206, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prodana vozila";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProdana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdana);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProdana";
            this.Text = "Prodana vozila";
            this.Load += new System.EventHandler(this.FrmProdana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdana;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoziloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.Label label1;
    }
}