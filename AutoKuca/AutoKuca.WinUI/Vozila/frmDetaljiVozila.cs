using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Vozila
{
    public partial class frmDetaljiVozila : Form
    {

        private int? _id = null;
        private frmVozila _forma = null;
        private frmProdana _formaP = null;
        private byte[] _file = null;

     
     


        private readonly APIService _model = new APIService("Model");
        private readonly APIService _oprema = new APIService("Oprema");
        private readonly APIService _tip = new APIService("TipVozila");
        private readonly APIService _vrata = new APIService("BrojVrata");
        private readonly APIService _trans = new APIService("Transmisija");
        private readonly APIService _auto = new APIService("Vozila");
        private readonly APIService _gorivo = new APIService("Gorivo");
        private readonly APIService _slike = new APIService("Slike");
        private readonly APIService _pos = new APIService("Poslovnica");



        public frmDetaljiVozila(int? id=null,frmVozila frm=null, frmProdana forma1=null)
        {
            InitializeComponent();
            _id = id;
            _forma = frm;
            _formaP = forma1; 
        }

       

        private async void LoadPodataka()
        {
            var modeli = await _model.Get<List<Model.Modeli>>(null);
            var opreme = await _oprema.Get<List<Model.Opreme>>(null);
            var tip = await _tip.Get<List<Model.TipoviVozila>>(null);
            var trans = await _trans.Get<List<Model.Transmisija>>(null);
            var vrata = await _vrata.Get<List<Model.BrojVrata>>(null);
            var gorivo = await _gorivo.Get<List<Model.Goriva>>(null);
            var poslovnice = await _pos.Get<List<Model.Poslovnice>>(null);

          

            if (_id.HasValue)
            {


                 var auto = await _auto.GetById<Model.VozilaM>(_id);
       

                modeli.Insert(0, new Model.Modeli {
                    ModelId=auto.ModelId,
                    Naziv = auto.Model
                });
                cmbModel.DataSource = modeli;
                cmbModel.DisplayMember = "Naziv"; 
                cmbModel.ValueMember = "ModelId";

                opreme.Insert(0, new Model.Opreme
                {
                    Naziv = auto.Oprema,
                    OpremaId = auto.OpremaId
                });
                cmbOprema.DataSource = opreme;
                cmbOprema.DisplayMember = "Naziv";
                cmbOprema.ValueMember = "OpremaId";

                tip.Insert(0, new Model.TipoviVozila
                {
                    Naziv = auto.TipVozila,
                    TipVozilaId = auto.TipVozilaId
                });
                cmbTip.DataSource = tip;
                cmbTip.DisplayMember = "Naziv";
                cmbTip.ValueMember = "TipVozilaId";
                trans.Insert(0, new Model.Transmisija
                {
                    Naziv = auto.Transmisija,
                    TransmisijaId = auto.TransmisijaId
                });
                cmbTransmisija.DataSource = trans;
                cmbTransmisija.DisplayMember = "Naziv";
                cmbTransmisija.ValueMember = "TransmisijaId";

                vrata.Insert(0, new Model.BrojVrata
                {
                    Naziv = auto.BrojVrata,
                    BrojVrataId = auto.BrojVrataId
                });
                cmbBrojVrata.DataSource = vrata;
                cmbBrojVrata.DisplayMember = "Naziv";
                cmbBrojVrata.ValueMember = "BrojVrataId";

                gorivo.Insert(0, new Model.Goriva
                {
                    GorivoId = auto.GorivoId,
                    Naziv = auto.Gorivo
                });
                cmbGorivo.DataSource = gorivo;
                cmbGorivo.DisplayMember = "Naziv";
                cmbGorivo.ValueMember = "GorivoId";

                poslovnice.Insert(0, new Model.Poslovnice
                {
                    PoslovnicaId = auto.PoslovnicaId,
                    Naziv=auto.PoslovnicaNaziv,
                });
                cmbPoslovnice.DataSource = poslovnice;
                cmbPoslovnice.DisplayMember = "Naziv";
                cmbPoslovnice.ValueMember = "PoslovnicaId";

                

                txtCijena.Text = auto.Cijena.ToString();
                string format = "yyyy/MM/dd HH:mm:ss";
                txtDatum.MinDate = new DateTime(1753, 6, 20);
                txtDatum.MaxDate = new DateTime(2020, 1, 1);

                txtDatum.Text = auto.DatumProizvodnje.ToString(format);
                txtdatumUvoza.MinDate = new DateTime(1753, 6, 20);
                txtdatumUvoza.MaxDate = new DateTime(2020, 1, 1);

                txtdatumUvoza.Text = auto.DatumUvoza.ToString(format);
                txtKilom.Text = auto.Kilometraza;
                txtKubik.Text = auto.Kubikaza;
                txtSnaga.Text = auto.SnagaMotora;
                txtSifra.Text = auto.SifraAutomobila;

                if (auto.Status == true)
                {
                    Status.Checked = true;
                }
                else
                {
                    Status.Checked = false;
                }




            }
            else
            {
                modeli.Insert(0, new Model.Modeli()
                
                );
                cmbModel.DataSource = modeli;
                cmbModel.DisplayMember = "Naziv";
                cmbModel.ValueMember = "ModelId";

                opreme.Insert(0, new Model.Opreme
                ());
                cmbOprema.DataSource = opreme;
                cmbOprema.DisplayMember = "Naziv";
                cmbOprema.ValueMember = "OpremaId";

                tip.Insert(0, new Model.TipoviVozila
                ());
                cmbTip.DataSource = tip;
                cmbTip.DisplayMember = "Naziv";
                cmbTip.ValueMember = "TipVozilaId";
                trans.Insert(0, new Model.Transmisija
                ());
                cmbTransmisija.DataSource = trans;
                cmbTransmisija.DisplayMember = "Naziv";
                cmbTransmisija.ValueMember = "TransmisijaId";

                vrata.Insert(0, new Model.BrojVrata
                ());
                cmbBrojVrata.DataSource = vrata;
                cmbBrojVrata.DisplayMember = "Naziv";
                cmbBrojVrata.ValueMember = "BrojVrataId";

                gorivo.Insert(0, new Model.Goriva
              ());
                cmbGorivo.DataSource = gorivo;
                cmbGorivo.DisplayMember = "Naziv";
                cmbGorivo.ValueMember = "GorivoId";
                

                poslovnice.Insert(0, new Model.Poslovnice
         ());
                cmbPoslovnice.DataSource = poslovnice;
                cmbPoslovnice.DisplayMember = "Naziv";
                cmbPoslovnice.ValueMember = "PoslovnicaId";

                Status.Checked = false;
            
            }
        }

  
    
   

        private async void LoadSlike()
        {
            SlikeSearchRequest request = new SlikeSearchRequest
            {
                VoziloID = _id
            };

            if (_id.HasValue)
            {
                var restult = await _slike.Get<List<Model.Slike>>(request);
                dgvSlike.DataSource = restult;
                dgvSlike.Columns[1].Visible = false;
                dgvSlike.Columns[3].Visible = false;

                setRowNumber(dgvSlike);
            }
          

          
        }

        private async void RefreshSlika()
        {
           
            SlikeSearchRequest request = new SlikeSearchRequest
            {
                VoziloID = _id
            };

            var restult = await _slike.Get<List<Model.Slike>>(request);
            dgvSlike.DataSource = restult;
       
            setRowNumber(dgvSlike);
        }


        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private   void FrmDetaljiVozila_Load(object sender, EventArgs e)
        {
            if (_forma != null)
            {
                Status.Visible = false;
                lblStatus.Visible = false;
              
                label19.Visible = false;

               
            }

            if (_formaP != null)
            {
             
                label19.Visible = false;

            }

    
            if (pictureBox1.Image == null)
            {
                btnSaveGalerija.Visible = false;
            }
            if (!_id.HasValue)
            {
                label12.Visible = false;
                dgvSlike.Visible = false;
                txtSlikaInput.Visible = false;
                btnDodaj.Visible = false;
                pictureBox1.Visible = false;
                btnSaveGalerija.Visible = false;
                label19.Visible = true;
                btnSnimi.Text = "Sačuvaj vozilo";
                NASLOV.Visible = false;
                this.AutoSize = true;
                this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                btnSnimi.AutoSize = true;
                btnSnimi.Width = 410;

          
            }
            txtSifra.Visible = false;



          

             LoadPodataka();
             LoadSlike();
           
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {


            if (Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");

            }
            else
            {
                var result = await _auto.Get<List<Model.VozilaM>>(null);
                int broj = result.Count();
                string sifra = "AutoKucaNerVoziloBr" + broj.ToString();


                VozilaUpsertRequest vozilo = new VozilaUpsertRequest();


                var ModelID = cmbModel.SelectedValue;

                if (int.TryParse(ModelID.ToString(), out int modelid))
                {
                    vozilo.ModelId = modelid;
                }
                var transID = cmbTransmisija.SelectedValue;

                if (int.TryParse(transID.ToString(), out int transid))
                {
                    vozilo.TransmisijaId = transid;
                }
                var vrataID = cmbBrojVrata.SelectedValue;

                if (int.TryParse(vrataID.ToString(), out int vrataid))
                {
                    vozilo.BrojVrataId = vrataid;
                }
                var tipID = cmbTip.SelectedValue;

                if (int.TryParse(tipID.ToString(), out int tipid))
                {
                    vozilo.TipVozilaId = tipid;
                }
                var opremaID = cmbOprema.SelectedValue;

                if (int.TryParse(opremaID.ToString(), out int opremaid))
                {
                    vozilo.OpremaId = opremaid;
                }

                var gorivoID = cmbGorivo.SelectedValue;

                if (int.TryParse(gorivoID.ToString(), out int gorivoid))
                {
                    vozilo.GorivoId = gorivoid;
                }
                var poslovnica = cmbPoslovnice.SelectedValue;
                if (!_id.HasValue)
                    if (int.TryParse(poslovnica.ToString(), out int pos))
                    {
                        vozilo.PoslovnicaId = pos;
                    }

                vozilo.Kubikaza = txtKubik.Text;
                vozilo.SnagaMotora = txtSnaga.Text;
                if (double.TryParse(txtCijena.Text, out double cijena))
                {
                    vozilo.Cijena = cijena;
                }

                bool DoesContainsWhitespace()
                {
                    return txtKilom.Text.Contains(" ");
                }
                if (DoesContainsWhitespace())
                {
                    vozilo.Kilometraza = txtKilom.Text;
                    vozilo.Kilometraza = vozilo.Kilometraza.Replace(" ", "");
                }
                else
                {
                    vozilo.Kilometraza = txtKilom.Text;

                }
                vozilo.DatumProizvodnje = txtDatum.Value;
                vozilo.SifraAutomobila = txtSifra.Text;
                vozilo.DatumUvoza = txtdatumUvoza.Value;

                if (Status.Checked == true)
                {
                    vozilo.Status = true;
                }
                else
                {
                    vozilo.Status = false;
                }



                if (_id.HasValue)
                {
                   var nesto= await _auto.Update<Model.VozilaM>(_id, vozilo);
                    if (nesto != default(Model.VozilaM))
                    {
                        if (_forma != null)
                            await _forma.GetVozila();
                        if (_formaP != null)
                            _formaP.GetVozila();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                
                    Close();
                }
                else
                {
                    vozilo.SifraAutomobila = sifra;
                 var nesto=  await _auto.Insert<Model.VozilaM>(vozilo);
                    if (nesto != default(Model.VozilaM))
                    {
                        if (_forma != null)
                            await _forma.GetVozila();
                        if (_formaP != null)
                            _formaP.GetVozila();

                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                    Close();
                }
            }

        }

        private void DgvSlike_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object id = dgvSlike.CurrentRow.Cells[1].Value;
            frmSlika frm = new frmSlika(int.Parse(id.ToString()));
            frm.Show();
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                 _file = File.ReadAllBytes(fileName);

                Image slika = Image.FromFile(fileName);
                txtSlikaInput.Text = fileName;
                pictureBox1.Image = slika;
            }

            btnSaveGalerija.Visible = true;
        }

        private async void BtnSaveGalerija_Click(object sender, EventArgs e)
        {
            SlikeUpsertRequest request = new SlikeUpsertRequest();

            request.VoziloId = _id;
            request.Slika = _file;

            await _slike.Insert<Model.Slike>(request);
            RefreshSlika();
            pictureBox1.Image = null;
            txtSlikaInput.Text = "";
            btnSaveGalerija.Visible = false;
            MessageBox.Show("Slika dodana u galeriju!");
       
        }

        private async void DgvSlike_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (dgvSlike.Columns[e.ColumnIndex].Name == "Ukloni")
            {
                var id = dgvSlike.Rows[e.RowIndex].Cells[1].Value;

                if (MessageBox.Show("Da li ste sigurni da želite ukloniti ovu fotografiju ?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _slike.Delete(id);
                    RefreshSlika();
                    MessageBox.Show("Zapis uspješno obrisan");
                }
            }
        }

        private void TxtKilom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

     

          private bool Validacija()
        {
           
        
         
            if (cmbModel.SelectedIndex == 0 && _id==null)
            {
                errorProvider1.SetError(cmbModel, "Obavezno polje !");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;

            }

            else if (cmbTransmisija.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbTransmisija, "Obavezno polje !");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (cmbBrojVrata.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbBrojVrata, "Obavezno polje !");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (cmbTip.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbTip, "Obavezno polje !");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (cmbOprema.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbOprema, "Obavezno polje !");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (cmbGorivo.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbGorivo, "Obavezno polje !");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (string.IsNullOrWhiteSpace(txtKubik.Text))
            {
                errorProvider1.SetError(txtKubik, "Obavezno polje !");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (txtKubik.Text.Any(char.IsLetter))
            {

                errorProvider1.SetError(txtKubik, "Kubikaža ne može sadržavati slova !");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;

            }
            else if (string.IsNullOrWhiteSpace(txtSnaga.Text))
            {
                errorProvider1.SetError(txtSnaga, "Obavezno polje !");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (txtSnaga.Text.Any(char.IsLetter))
            {

                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtSnaga, "Snaga motora ne može sadržavati slova!");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;

            }
            else if (string.IsNullOrWhiteSpace(txtCijena.Text))
                {
                    errorProvider1.SetError(txtCijena, "Obavezno polje !");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (txtCijena.Text.Any(char.IsLetter))
            {

                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "Cijena ne može sadržavati slova!");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;

            }
            else if (txtCijena.Text.Length< 1 || txtCijena.Text.Length> 6)
                {
                    errorProvider1.SetError(txtCijena, "Cijena mora biti u intervalu od 1 do 150 000 !");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
           
            else if (string.IsNullOrWhiteSpace(txtKilom.Text))
            {
                errorProvider1.SetError(txtKilom, "Obavezno polje !");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }
            else if (txtKilom.Text.Any(char.IsLetter))
            {

                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtKilom, "Kilometraža ne može sadržavati slova!");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;

            }
            else if (txtKilom.Text.Length< 1 || txtKilom.Text.Length> 6)
                {
                    errorProvider1.SetError(txtKilom, "Kilometraža mora biti u intervalu od 1 do 1 000 000 !");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbPoslovnice, "");
                return true;
            }                           
                else if (cmbPoslovnice.SelectedIndex == 0 && _id == null)
                {
                    errorProvider1.SetError(cmbPoslovnice, "Obavezno polje !");
                errorProvider1.SetError(txtKilom, "");
                errorProvider1.SetError(txtCijena, "");
                errorProvider1.SetError(txtSnaga, "");
                errorProvider1.SetError(txtKubik, "");
                errorProvider1.SetError(cmbGorivo, "");
                errorProvider1.SetError(cmbOprema, "");
                errorProvider1.SetError(cmbTip, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                errorProvider1.SetError(cmbTransmisija, "");
                errorProvider1.SetError(cmbModel, "");
                errorProvider1.SetError(cmbBrojVrata, "");
                return true;
            }
                else
            {
                errorProvider1.SetError(cmbPoslovnice, "");
                return false;

            }
        }

        private void TxtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtSnaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtKubik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
