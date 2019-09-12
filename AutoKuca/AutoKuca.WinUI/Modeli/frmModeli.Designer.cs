namespace AutoKuca.WinUI.Modeli
{
    partial class frmModeli
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
            this.listaModeli = new System.Windows.Forms.GroupBox();
            this.dgvModeli = new System.Windows.Forms.DataGridView();
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izmjeni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Obriši = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaModeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).BeginInit();
            this.SuspendLayout();
            // 
            // listaModeli
            // 
            this.listaModeli.Controls.Add(this.dgvModeli);
            this.listaModeli.Location = new System.Drawing.Point(8, 115);
            this.listaModeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaModeli.Name = "listaModeli";
            this.listaModeli.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaModeli.Size = new System.Drawing.Size(466, 240);
            this.listaModeli.TabIndex = 0;
            this.listaModeli.TabStop = false;
            this.listaModeli.Text = "Modeli";
            // 
            // dgvModeli
            // 
            this.dgvModeli.AllowUserToAddRows = false;
            this.dgvModeli.AllowUserToDeleteRows = false;
            this.dgvModeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelID,
            this.Model,
            this.Marka,
            this.Izmjeni,
            this.Obriši});
            this.dgvModeli.Location = new System.Drawing.Point(2, 17);
            this.dgvModeli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvModeli.Name = "dgvModeli";
            this.dgvModeli.ReadOnly = true;
            this.dgvModeli.RowHeadersWidth = 51;
            this.dgvModeli.RowTemplate.Height = 24;
            this.dgvModeli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvModeli.Size = new System.Drawing.Size(464, 219);
            this.dgvModeli.TabIndex = 0;
            this.dgvModeli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvModeli_CellContentClick);
            // 
            // ModelID
            // 
            this.ModelID.DataPropertyName = "ModelID";
            this.ModelID.HeaderText = "ModelID";
            this.ModelID.MinimumWidth = 6;
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
            this.ModelID.Visible = false;
            this.ModelID.Width = 125;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Naziv";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 125;
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "NazivMarke";
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            this.Marka.Width = 125;
            // 
            // Izmjeni
            // 
            this.Izmjeni.HeaderText = "";
            this.Izmjeni.MinimumWidth = 6;
            this.Izmjeni.Name = "Izmjeni";
            this.Izmjeni.ReadOnly = true;
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
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(218, 80);
            this.btnPrikazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(117, 28);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(82, 88);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(121, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(191, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modeli";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmModeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.listaModeli);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModeli";
            this.Text = "Modeli";
            this.Load += new System.EventHandler(this.FrmModeli_Load);
            this.listaModeli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModeli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listaModeli;
        private System.Windows.Forms.DataGridView dgvModeli;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewButtonColumn Izmjeni;
        private System.Windows.Forms.DataGridViewButtonColumn Obriši;
        private System.Windows.Forms.Label label3;
    }
}