namespace AutoKuca.WinUI.UpitiAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPretraga = new System.Windows.Forms.ComboBox();
            this.dgvUpiti = new System.Windows.Forms.DataGridView();
            this.KontaktUpitiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta upita:";
            // 
            // cbPretraga
            // 
            this.cbPretraga.FormattingEnabled = true;
            this.cbPretraga.Location = new System.Drawing.Point(119, 113);
            this.cbPretraga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPretraga.Name = "cbPretraga";
            this.cbPretraga.Size = new System.Drawing.Size(138, 21);
            this.cbPretraga.TabIndex = 1;
            this.cbPretraga.SelectedIndexChanged += new System.EventHandler(this.CbPretraga_SelectedIndexChanged);
            // 
            // dgvUpiti
            // 
            this.dgvUpiti.AllowUserToAddRows = false;
            this.dgvUpiti.AllowUserToDeleteRows = false;
            this.dgvUpiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KontaktUpitiId,
            this.ImePrezime,
            this.Email,
            this.DatumVrijeme,
            this.Detalji});
            this.dgvUpiti.Location = new System.Drawing.Point(9, 157);
            this.dgvUpiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUpiti.Name = "dgvUpiti";
            this.dgvUpiti.ReadOnly = true;
            this.dgvUpiti.RowTemplate.Height = 24;
            this.dgvUpiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvUpiti.Size = new System.Drawing.Size(463, 197);
            this.dgvUpiti.TabIndex = 2;
            this.dgvUpiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUpiti_CellContentClick);
            // 
            // KontaktUpitiId
            // 
            this.KontaktUpitiId.DataPropertyName = "kontaktUpitiId";
            this.KontaktUpitiId.HeaderText = "Upitid";
            this.KontaktUpitiId.Name = "KontaktUpitiId";
            this.KontaktUpitiId.ReadOnly = true;
            this.KontaktUpitiId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(196, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upiti";
            // 
            // frmUpiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUpiti);
            this.Controls.Add(this.cbPretraga);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUpiti";
            this.Text = "Upiti";
            this.Load += new System.EventHandler(this.FrmUpiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPretraga;
        private System.Windows.Forms.DataGridView dgvUpiti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktUpitiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}