namespace AutoKuca.WinUI.UpitiMA
{
    partial class frmUpiti
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
            this.dgvUpiti = new System.Windows.Forms.DataGridView();
            this.UpitiVozilaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUpiti = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpiti
            // 
            this.dgvUpiti.AllowUserToAddRows = false;
            this.dgvUpiti.AllowUserToDeleteRows = false;
            this.dgvUpiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpitiVozilaId,
            this.Ime,
            this.Email,
            this.Datum,
            this.Detalji});
            this.dgvUpiti.Location = new System.Drawing.Point(9, 155);
            this.dgvUpiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUpiti.Name = "dgvUpiti";
            this.dgvUpiti.ReadOnly = true;
            this.dgvUpiti.RowTemplate.Height = 24;
            this.dgvUpiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUpiti.Size = new System.Drawing.Size(404, 201);
            this.dgvUpiti.TabIndex = 0;
            this.dgvUpiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUpiti_CellContentClick);
            // 
            // UpitiVozilaId
            // 
            this.UpitiVozilaId.DataPropertyName = "UpitiVozilaId";
            this.UpitiVozilaId.HeaderText = "UpitiVozilaId";
            this.UpitiVozilaId.Name = "UpitiVozilaId";
            this.UpitiVozilaId.ReadOnly = true;
            this.UpitiVozilaId.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "ImePrezime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumVrijeme";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upiti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta upita:";
            // 
            // cmbUpiti
            // 
            this.cmbUpiti.FormattingEnabled = true;
            this.cmbUpiti.Location = new System.Drawing.Point(89, 106);
            this.cmbUpiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUpiti.Name = "cmbUpiti";
            this.cmbUpiti.Size = new System.Drawing.Size(131, 21);
            this.cmbUpiti.TabIndex = 3;
            this.cmbUpiti.SelectedIndexChanged += new System.EventHandler(this.CmbUpiti_SelectedIndexChanged);
            // 
            // frmUpiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.cmbUpiti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUpiti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpiti";
            this.Text = "Upiti";
            this.Load += new System.EventHandler(this.FrmUpiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpitiVozilaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUpiti;
    }
}