namespace AutoKuca.WinUI.Vozila
{
    partial class frmDetaljiVozila
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
            this.txtKubik = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKilom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbTransmisija = new System.Windows.Forms.ComboBox();
            this.txtSnaga = new System.Windows.Forms.TextBox();
            this.cmbBrojVrata = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbOprema = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.CheckBox();
            this.NASLOV = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.DateTimePicker();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGorivo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSlike = new System.Windows.Forms.DataGridView();
            this.Ukloni = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.btnSaveGalerija = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbPoslovnice = new System.Windows.Forms.ComboBox();
            this.txtdatumUvoza = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKubik
            // 
            this.txtKubik.Location = new System.Drawing.Point(23, 424);
            this.txtKubik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKubik.Name = "txtKubik";
            this.txtKubik.Size = new System.Drawing.Size(178, 20);
            this.txtKubik.TabIndex = 4;
            this.txtKubik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKubik_KeyPress);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(246, 98);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(174, 20);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCijena_KeyPress);
            // 
            // txtKilom
            // 
            this.txtKilom.Location = new System.Drawing.Point(246, 148);
            this.txtKilom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKilom.Name = "txtKilom";
            this.txtKilom.Size = new System.Drawing.Size(174, 20);
            this.txtKilom.TabIndex = 9;
            this.txtKilom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKilom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transmisija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Broj vrata:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kubikaža:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Snaga motora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Oprema:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cijena:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Datum proizvodnje:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 132);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Kilometraža:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(244, 344);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status:";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(23, 97);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(178, 21);
            this.cmbModel.TabIndex = 26;
            // 
            // cmbTransmisija
            // 
            this.cmbTransmisija.FormattingEnabled = true;
            this.cmbTransmisija.Location = new System.Drawing.Point(23, 148);
            this.cmbTransmisija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTransmisija.Name = "cmbTransmisija";
            this.cmbTransmisija.Size = new System.Drawing.Size(178, 21);
            this.cmbTransmisija.TabIndex = 27;
            // 
            // txtSnaga
            // 
            this.txtSnaga.Location = new System.Drawing.Point(23, 474);
            this.txtSnaga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSnaga.Name = "txtSnaga";
            this.txtSnaga.Size = new System.Drawing.Size(178, 20);
            this.txtSnaga.TabIndex = 5;
            this.txtSnaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSnaga_KeyPress);
            // 
            // cmbBrojVrata
            // 
            this.cmbBrojVrata.FormattingEnabled = true;
            this.cmbBrojVrata.Location = new System.Drawing.Point(23, 200);
            this.cmbBrojVrata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBrojVrata.Name = "cmbBrojVrata";
            this.cmbBrojVrata.Size = new System.Drawing.Size(178, 21);
            this.cmbBrojVrata.TabIndex = 28;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(23, 254);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(178, 21);
            this.cmbTip.TabIndex = 29;
            // 
            // cmbOprema
            // 
            this.cmbOprema.FormattingEnabled = true;
            this.cmbOprema.Location = new System.Drawing.Point(23, 308);
            this.cmbOprema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOprema.Name = "cmbOprema";
            this.cmbOprema.Size = new System.Drawing.Size(178, 21);
            this.cmbOprema.TabIndex = 30;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(308, 334);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(46, 35);
            this.Status.TabIndex = 31;
            this.Status.UseVisualStyleBackColor = true;
            // 
            // NASLOV
            // 
            this.NASLOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NASLOV.Location = new System.Drawing.Point(17, 15);
            this.NASLOV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NASLOV.Name = "NASLOV";
            this.NASLOV.Size = new System.Drawing.Size(227, 46);
            this.NASLOV.TabIndex = 32;
            this.NASLOV.Text = "Detalji vozila";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimi.Location = new System.Drawing.Point(19, 521);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(226, 67);
            this.btnSnimi.TabIndex = 34;
            this.btnSnimi.Text = "Sačuvaj promjene";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.BtnSnimi_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(475, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 46);
            this.label12.TabIndex = 35;
            this.label12.Text = "Galerija slika";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(246, 198);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(174, 20);
            this.txtDatum.TabIndex = 36;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(533, 581);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(178, 20);
            this.txtSifra.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 351);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gorivo:";
            // 
            // cmbGorivo
            // 
            this.cmbGorivo.FormattingEnabled = true;
            this.cmbGorivo.Location = new System.Drawing.Point(23, 367);
            this.cmbGorivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGorivo.Name = "cmbGorivo";
            this.cmbGorivo.Size = new System.Drawing.Size(178, 21);
            this.cmbGorivo.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Tip vozila:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(456, 351);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(267, 25);
            this.btnDodaj.TabIndex = 42;
            this.btnDodaj.Text = "Dodaj sliku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 381);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSlike
            // 
            this.dgvSlike.AllowUserToAddRows = false;
            this.dgvSlike.AllowUserToDeleteRows = false;
            this.dgvSlike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlike.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ukloni});
            this.dgvSlike.Location = new System.Drawing.Point(456, 63);
            this.dgvSlike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSlike.Name = "dgvSlike";
            this.dgvSlike.ReadOnly = true;
            this.dgvSlike.RowHeadersWidth = 51;
            this.dgvSlike.RowTemplate.Height = 80;
            this.dgvSlike.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlike.Size = new System.Drawing.Size(267, 263);
            this.dgvSlike.TabIndex = 33;
            this.dgvSlike.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSlike_CellContentClick);
            this.dgvSlike.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvSlike_MouseDoubleClick);
            // 
            // Ukloni
            // 
            this.Ukloni.HeaderText = "";
            this.Ukloni.MinimumWidth = 6;
            this.Ukloni.Name = "Ukloni";
            this.Ukloni.ReadOnly = true;
            this.Ukloni.Text = "Ukloni iz galerije";
            this.Ukloni.UseColumnTextForButtonValue = true;
            this.Ukloni.Width = 125;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(456, 331);
            this.txtSlikaInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(268, 20);
            this.txtSlikaInput.TabIndex = 44;
            // 
            // btnSaveGalerija
            // 
            this.btnSaveGalerija.Location = new System.Drawing.Point(523, 532);
            this.btnSaveGalerija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveGalerija.Name = "btnSaveGalerija";
            this.btnSaveGalerija.Size = new System.Drawing.Size(200, 30);
            this.btnSaveGalerija.TabIndex = 45;
            this.btnSaveGalerija.Text = "Spremi u galeriju";
            this.btnSaveGalerija.UseVisualStyleBackColor = true;
            this.btnSaveGalerija.Click += new System.EventHandler(this.BtnSaveGalerija_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 427);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "kW";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 477);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "ks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(424, 154);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "km";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(424, 101);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "KM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(244, 236);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Datum uvoza:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(244, 292);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Poslovnica:";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.Location = new System.Drawing.Point(127, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(227, 46);
            this.label19.TabIndex = 54;
            this.label19.Text = "Novo vozilo";
            // 
            // cmbPoslovnice
            // 
            this.cmbPoslovnice.FormattingEnabled = true;
            this.cmbPoslovnice.Location = new System.Drawing.Point(246, 308);
            this.cmbPoslovnice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPoslovnice.Name = "cmbPoslovnice";
            this.cmbPoslovnice.Size = new System.Drawing.Size(178, 21);
            this.cmbPoslovnice.TabIndex = 52;
            // 
            // txtdatumUvoza
            // 
            this.txtdatumUvoza.Location = new System.Drawing.Point(246, 253);
            this.txtdatumUvoza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdatumUvoza.Name = "txtdatumUvoza";
            this.txtdatumUvoza.Size = new System.Drawing.Size(174, 20);
            this.txtdatumUvoza.TabIndex = 50;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetaljiVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(732, 609);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbPoslovnice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtdatumUvoza);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveGalerija);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbGorivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.dgvSlike);
            this.Controls.Add(this.NASLOV);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.cmbOprema);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbBrojVrata);
            this.Controls.Add(this.cmbTransmisija);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilom);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtSnaga);
            this.Controls.Add(this.txtKubik);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDetaljiVozila";
            this.Text = "Vozilo";
            this.Load += new System.EventHandler(this.FrmDetaljiVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKubik;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtKilom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbTransmisija;
        private System.Windows.Forms.TextBox txtSnaga;
        private System.Windows.Forms.ComboBox cmbBrojVrata;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbOprema;
        private System.Windows.Forms.CheckBox Status;
        private System.Windows.Forms.Label NASLOV;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txtDatum;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGorivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSlike;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Button btnSaveGalerija;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewButtonColumn Ukloni;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbPoslovnice;
        private System.Windows.Forms.DateTimePicker txtdatumUvoza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}