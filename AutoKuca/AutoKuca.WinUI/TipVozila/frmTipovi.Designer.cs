namespace AutoKuca.WinUI.TipVozila
{
    partial class frmTipovi
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
            this.dgvTipovi = new System.Windows.Forms.DataGridView();
            this.TipVozilaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipovi
            // 
            this.dgvTipovi.AllowUserToAddRows = false;
            this.dgvTipovi.AllowUserToDeleteRows = false;
            this.dgvTipovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipVozilaID,
            this.Naziv,
            this.Izmjeni,
            this.Obriši});
            this.dgvTipovi.Location = new System.Drawing.Point(9, 64);
            this.dgvTipovi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTipovi.Name = "dgvTipovi";
            this.dgvTipovi.ReadOnly = true;
            this.dgvTipovi.RowTemplate.Height = 24;
            this.dgvTipovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTipovi.Size = new System.Drawing.Size(345, 249);
            this.dgvTipovi.TabIndex = 0;
            this.dgvTipovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipovi_CellContentClick);
            // 
            // TipVozilaID
            // 
            this.TipVozilaID.DataPropertyName = "TipVozilaID";
            this.TipVozilaID.HeaderText = "TipVozilaID";
            this.TipVozilaID.Name = "TipVozilaID";
            this.TipVozilaID.ReadOnly = true;
            this.TipVozilaID.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.DataPropertyName = "TipVozilaID";
            this.Izmjeni.HeaderText = "";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izmjeni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "";
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obriši.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(108, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipovi vozila";
            // 
            // frmTipovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTipovi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTipovi";
            this.Text = "Tipovi";
            this.Load += new System.EventHandler(this.FrmTipovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipVozilaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.Label label3;
    }
}