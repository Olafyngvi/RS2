namespace AutoKuca.WinUI.PodaciUvoza
{
    partial class frmPodaciUvoza
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
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.VozilaPoslovniceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUvoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poslovnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Šifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPoslovnica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VozilaPoslovniceId,
            this.DatumUvoza,
            this.Poslovnica,
            this.Šifra,
            this.Marka,
            this.Model,
            this.Izmjeni});
            this.dgvPodaci.Location = new System.Drawing.Point(2, 123);
            this.dgvPodaci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.RowTemplate.Height = 24;
            this.dgvPodaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPodaci.Size = new System.Drawing.Size(716, 224);
            this.dgvPodaci.TabIndex = 0;
            this.dgvPodaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPodaci_CellContentClick);
            // 
            // VozilaPoslovniceId
            // 
            this.VozilaPoslovniceId.DataPropertyName = "VozilaPoslovniceId";
            this.VozilaPoslovniceId.HeaderText = "VozilaPoslovniceId";
            this.VozilaPoslovniceId.Name = "VozilaPoslovniceId";
            this.VozilaPoslovniceId.ReadOnly = true;
            this.VozilaPoslovniceId.Visible = false;
            // 
            // DatumUvoza
            // 
            this.DatumUvoza.DataPropertyName = "DatumUvoza";
            this.DatumUvoza.HeaderText = "DatumUvoza";
            this.DatumUvoza.Name = "DatumUvoza";
            this.DatumUvoza.ReadOnly = true;
            // 
            // Poslovnica
            // 
            this.Poslovnica.DataPropertyName = "Poslovnica";
            this.Poslovnica.HeaderText = "Poslovnica";
            this.Poslovnica.Name = "Poslovnica";
            this.Poslovnica.ReadOnly = true;
            // 
            // Šifra
            // 
            this.Šifra.DataPropertyName = "Sifra";
            this.Šifra.HeaderText = "Šifra";
            this.Šifra.Name = "Šifra";
            this.Šifra.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Izmjeni
            // 
            this.Izmjeni.HeaderText = "";
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Text = "Izmjena";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraga:";
            // 
            // cmbPoslovnica
            // 
            this.cmbPoslovnica.FormattingEnabled = true;
            this.cmbPoslovnica.Location = new System.Drawing.Point(92, 80);
            this.cmbPoslovnica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPoslovnica.Name = "cmbPoslovnica";
            this.cmbPoslovnica.Size = new System.Drawing.Size(138, 21);
            this.cmbPoslovnica.TabIndex = 2;
            this.cmbPoslovnica.SelectedIndexChanged += new System.EventHandler(this.CmbPoslovnica_SelectedIndexChanged);
            // 
            // frmPodaciUvoza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 366);
            this.Controls.Add(this.cmbPoslovnica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPodaci);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPodaciUvoza";
            this.Text = "Podaci uvoza";
            this.Load += new System.EventHandler(this.FrmPodaciUvoza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPoslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn VozilaPoslovniceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUvoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslovnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Šifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
    }
}