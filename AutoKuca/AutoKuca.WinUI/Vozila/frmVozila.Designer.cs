namespace AutoKuca.WinUI.Vozila
{
    partial class frmVozila
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
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.VoziloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipVozilaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Šifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Arhiviraj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbMarke = new System.Windows.Forms.ComboBox();
            this.cmbTipVozila = new System.Windows.Forms.ComboBox();
            this.cmbTransmisija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToAddRows = false;
            this.dgvVozila.AllowUserToDeleteRows = false;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VoziloID,
            this.ModelID,
            this.Marka,
            this.TipVozilaID,
            this.Cijena,
            this.Šifra,
            this.Detalji,
            this.Arhiviraj});
            this.dgvVozila.Location = new System.Drawing.Point(11, 219);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.ReadOnly = true;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.Size = new System.Drawing.Size(1045, 351);
            this.dgvVozila.TabIndex = 0;
            this.dgvVozila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVozila_CellContentClick);
            // 
            // VoziloID
            // 
            this.VoziloID.DataPropertyName = "VoziloId";
            this.VoziloID.HeaderText = "VoziloID";
            this.VoziloID.Name = "VoziloID";
            this.VoziloID.ReadOnly = true;
            this.VoziloID.Visible = false;
            // 
            // ModelID
            // 
            this.ModelID.DataPropertyName = "Model";
            this.ModelID.HeaderText = "Model";
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            // 
            // TipVozilaID
            // 
            this.TipVozilaID.DataPropertyName = "TipVozila";
            this.TipVozilaID.HeaderText = "Tip vozila";
            this.TipVozilaID.Name = "TipVozilaID";
            this.TipVozilaID.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Šifra
            // 
            this.Šifra.DataPropertyName = "SifraAutomobila";
            this.Šifra.HeaderText = "Šifra vozila";
            this.Šifra.Name = "Šifra";
            this.Šifra.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji vozila";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // Arhiviraj
            // 
            this.Arhiviraj.HeaderText = "";
            this.Arhiviraj.Name = "Arhiviraj";
            this.Arhiviraj.ReadOnly = true;
            this.Arhiviraj.Text = "Arhiviraj";
            this.Arhiviraj.UseColumnTextForButtonValue = true;
            // 
            // cmbMarke
            // 
            this.cmbMarke.FormattingEnabled = true;
            this.cmbMarke.Location = new System.Drawing.Point(156, 106);
            this.cmbMarke.Name = "cmbMarke";
            this.cmbMarke.Size = new System.Drawing.Size(146, 24);
            this.cmbMarke.TabIndex = 1;
            this.cmbMarke.SelectedIndexChanged += new System.EventHandler(this.CmbMarke_SelectedIndexChanged);
            // 
            // cmbTipVozila
            // 
            this.cmbTipVozila.FormattingEnabled = true;
            this.cmbTipVozila.Location = new System.Drawing.Point(524, 106);
            this.cmbTipVozila.Name = "cmbTipVozila";
            this.cmbTipVozila.Size = new System.Drawing.Size(146, 24);
            this.cmbTipVozila.TabIndex = 2;
            this.cmbTipVozila.SelectedIndexChanged += new System.EventHandler(this.CmbTipVozila_SelectedIndexChanged);
            // 
            // cmbTransmisija
            // 
            this.cmbTransmisija.FormattingEnabled = true;
            this.cmbTransmisija.Location = new System.Drawing.Point(340, 106);
            this.cmbTransmisija.Name = "cmbTransmisija";
            this.cmbTransmisija.Size = new System.Drawing.Size(146, 24);
            this.cmbTransmisija.TabIndex = 3;
            this.cmbTransmisija.SelectedIndexChanged += new System.EventHandler(this.CmbTransmisija_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraga:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 70);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vozila na stanju";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(699, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Godina proizvodnje:";
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(840, 106);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(105, 22);
            this.txtGodina.TabIndex = 10;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(951, 101);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(105, 32);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.BtnPretraga_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sortiraj:";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Location = new System.Drawing.Point(156, 156);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(146, 24);
            this.cmbSort.TabIndex = 13;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // frmVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 582);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtGodina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTransmisija);
            this.Controls.Add(this.cmbTipVozila);
            this.Controls.Add(this.cmbMarke);
            this.Controls.Add(this.dgvVozila);
            this.Name = "frmVozila";
            this.Text = "Vozila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoziloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipVozilaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Šifra;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.DataGridViewButtonColumn Arhiviraj;
        private System.Windows.Forms.ComboBox cmbMarke;
        private System.Windows.Forms.ComboBox cmbTipVozila;
        private System.Windows.Forms.ComboBox cmbTransmisija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSort;
    }
}