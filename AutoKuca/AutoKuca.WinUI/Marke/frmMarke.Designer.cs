namespace AutoKuca.WinUI.Marke
{
    partial class frmMarke
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
            this.dgvMarke = new System.Windows.Forms.DataGridView();
            this.MarkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarke
            // 
            this.dgvMarke.AllowUserToAddRows = false;
            this.dgvMarke.AllowUserToDeleteRows = false;
            this.dgvMarke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarkaId,
            this.Naziv,
            this.Izmjeni,
            this.Obriši});
            this.dgvMarke.Location = new System.Drawing.Point(0, 90);
            this.dgvMarke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMarke.Name = "dgvMarke";
            this.dgvMarke.ReadOnly = true;
            this.dgvMarke.RowHeadersWidth = 51;
            this.dgvMarke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMarke.Size = new System.Drawing.Size(448, 275);
            this.dgvMarke.TabIndex = 0;
            this.dgvMarke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarke_CellContentClick);
            // 
            // MarkaId
            // 
            this.MarkaId.DataPropertyName = "MarkaID";
            this.MarkaId.HeaderText = "MarkaId";
            this.MarkaId.MinimumWidth = 6;
            this.MarkaId.Name = "MarkaId";
            this.MarkaId.ReadOnly = true;
            this.MarkaId.Visible = false;
            this.MarkaId.Width = 125;
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
            // Izmjeni
            // 
            this.Izmjeni.HeaderText = "";
            this.Izmjeni.MinimumWidth = 6;
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
            this.Izmjeni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izmjeni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izmjeni.Text = "Izmjeni";
            this.Izmjeni.UseColumnTextForButtonValue = true;
            this.Izmjeni.Width = 125;
            // 
            // Obriši
            // 
            this.Obriši.HeaderText = "";
            this.Obriši.MinimumWidth = 6;
            this.Obriši.Name = "Obriši";
            this.Obriši.ReadOnly = true;
            this.Obriši.Text = "Obriši";
            this.Obriši.UseColumnTextForButtonValue = true;
            this.Obriši.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(140, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marke";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMarke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMarke);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMarke";
            this.Text = "Marke";
            this.Load += new System.EventHandler(this.FrmMarke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarke;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}