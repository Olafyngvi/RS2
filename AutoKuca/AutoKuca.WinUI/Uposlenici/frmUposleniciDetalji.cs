using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Uposlenici
{
    public partial class frmUposleniciDetalji : Form
    {
        private int? _id = null;
        private frmUposlenici _parent = null;
        private readonly APIService _uposlenik = new APIService("Uposlenik");
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _poslovnice = new APIService("Poslovnica");
        private readonly APIService _vrsta = new APIService("VrstaUposlenika");


        public frmUposleniciDetalji(int? id=null, frmUposlenici frm=null)
        {
            InitializeComponent();
            _id = id;
            _parent = frm;
        }

        private async Task LoadForma()
        {
            var gradovi = await _gradovi.Get<List<Model.Gradovi>>(null);
            var poslovnice = await _poslovnice.Get<List<Model.Poslovnice>>(null);
            var vrsta = await _vrsta.Get<List<Model.VrsteUposlenika>>(null);

            if (_id.HasValue)
            {
                var uposlenik = await _uposlenik.GetById<Model.Uposlenici>(_id);

                txtIme.Text = uposlenik.Ime;
                txtPrezime.Text = uposlenik.Prezime;
                txtAdresa.Text = uposlenik.Adresa;
                txtKorsIme.Text = uposlenik.KorisnickoIme;
                txtLozinka.Text = uposlenik.LozinkaHash;
                txtLozinka.PasswordChar = '*';
                txtLozinka2.PasswordChar = '*';

                txtKorsIme.ReadOnly = true;
                txtJMBG.Text = uposlenik.Jmbg;
                txtTelefon.Text = uposlenik.Telefon;
                if (uposlenik.Status == true)
                { 
                    Status.Checked = true;
                }
                else
                {
                    Status.Checked = false;
                }
                string format = "yyyy/MM/dd HH:mm:ss";
                txtDatumRodj.MinDate = new DateTime(1753, 6, 20);
                txtDatumRodj.MaxDate = new DateTime(2020, 1, 1);
                txtDatumRodj.Text = uposlenik.DatumRodjenja.ToString(format);

                txtdatumZapos.MinDate = new DateTime(1753, 6, 20);
                txtdatumZapos.MaxDate = new DateTime(2020, 1, 1);
                txtdatumZapos.Text = uposlenik.DatumZaposljavanja.ToString();

                gradovi.Insert(0, new Model.Gradovi
                {
                    GradId = uposlenik.GradId,
                    Naziv = uposlenik.Grad

                });
                cmbGrad.DataSource = gradovi;
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "GradId";

                poslovnice.Insert(0, new Model.Poslovnice
                {
                    PoslovnicaId = uposlenik.PoslovnicaId,
                    Naziv = uposlenik.Poslovnica

                });
                cmbPoslovnica.DataSource = poslovnice;
                cmbPoslovnica.DisplayMember = "Naziv";
                cmbPoslovnica.ValueMember = "PoslovnicaId";

                vrsta.Insert(0, new Model.VrsteUposlenika
                {
                    VrstaUposlenikaId = uposlenik.VrstaUposlenikaId,
                    Naziv = uposlenik.VrstaUposlenika

                });
                cmbVrsta.DataSource = vrsta;
                cmbVrsta.DisplayMember = "Naziv";
                cmbVrsta.ValueMember = "VrstaUposlenikaId";
            }
            else
            {
                gradovi.Insert(0, new Model.Gradovi());
                cmbGrad.DataSource = gradovi;
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "GradId";

                poslovnice.Insert(0, new Model.Poslovnice());
                cmbPoslovnica.DataSource = poslovnice;
                cmbPoslovnica.DisplayMember = "Naziv";
                cmbPoslovnica.ValueMember = "PoslovnicaId";

                vrsta.Insert(0, new Model.VrsteUposlenika());
                cmbVrsta.DataSource = vrsta;
                cmbVrsta.DisplayMember = "Naziv";
                cmbVrsta.ValueMember = "VrstaUposlenikaId";
            }
        }

        private async void FrmUposleniciDetalji_Load(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                lblU.Text = "Novi uposlenik";
            }
            await LoadForma();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {


            if ( await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else
            {

            
            UposleniciUpsertRequest model = new UposleniciUpsertRequest();

            model.Ime = txtIme.Text;
            model.Prezime = txtPrezime.Text;
            model.Adresa = txtAdresa.Text;
            model.KorisnickoIme = txtKorsIme.Text;
            model.Lozinka = txtLozinka.Text;
            model.DatumRodjenja = txtDatumRodj.Value;
            model.DatumZaposljavanja = txtdatumZapos.Value;
            model.Jmbg = txtJMBG.Text;
            model.Telefon = txtTelefon.Text;



            if (Status.Checked == true)
            {
                model.Status = true;
            }
            else
            {
                model.Status = false;
            }

            var gradID = cmbGrad.SelectedValue;
            if (int.TryParse(gradID.ToString(), out int gid))
            {
                model.GradId = gid;
            }

            var posID = cmbPoslovnica.SelectedValue;
            if (int.TryParse(posID.ToString(), out int pid))
            {
                model.PoslovnicaId = pid;
            }

            var vrsID = cmbVrsta.SelectedValue;
            if (int.TryParse(vrsID.ToString(), out int vid))
            {
                model.VrstaUposlenikaId = vid;
            }

            if (_id.HasValue && txtLozinka.Text == txtLozinka2.Text)
            {

                var nesto=await _uposlenik.Update<Model.Uposlenici>(_id, model);
                    if (nesto!=default(Model.Uposlenici))
                    {
                        await _parent.GetRadnici();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
             
                Close();
            }
            else if (txtLozinka.Text == txtLozinka2.Text)
            {
                 
                
                var nesto= await _uposlenik.Insert<Model.Uposlenici>(model);
                    if (nesto != default(Model.Uposlenici))
                    {
                        await _parent.GetRadnici();
                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                Close();

            }
            else
            {
                MessageBox.Show("Lozinke se ne slažu!");
            }
            }

        }


        private async Task<bool> Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Obavezno polje !");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
            if (txtIme.Text.Length < 4 || txtIme.Text.Length > 15)
            {
                errorProvider1.SetError(txtIme, "Ime mora sadržavati barem 4 karaktera, ne više od 15 !");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

             if(string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "Obavezno polje !");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");


                return true;
            }

             if(txtPrezime.Text.Length < 4 || txtPrezime.Text.Length > 15)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "Prezime mora sadržavati barem 4 karaktera, ne više od 15 !");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;

            }

             if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "Obavezno polje !");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

             if (txtAdresa.Text.Length < 4 || txtAdresa.Text.Length > 30)
            {
                errorProvider1.SetError(txtAdresa, "Adresa mora sadržavati barem 4 karaktera, ne više od 30 !");
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

             if (string.IsNullOrWhiteSpace(txtKorsIme.Text))
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "Obavezno polje !");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

            else if (txtKorsIme.Text.Length < 4 || txtKorsIme.Text.Length > 10)
            {
                errorProvider1.SetError(txtKorsIme, "Korisnicko ime mora sadržavati barem 4 karaktera, ne više od 10 !");
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
             if (txtKorsIme.Text.Length >= 4 || txtKorsIme.Text.Length <= 10)
            {
                var lista = await _uposlenik.Get<List<Model.Uposlenici>>(null);
                foreach (var item in lista)
                {
                    if(_id==null)
                    if(txtKorsIme.Text==item.KorisnickoIme)
                    {
                        errorProvider1.SetError(txtKorsIme, "Korisničko ime zauzeto, odaberite drugo !");
                        errorProvider1.SetError(txtIme, "");
                        errorProvider1.SetError(txtPrezime, "");
                        errorProvider1.SetError(txtAdresa, "");
                        errorProvider1.SetError(txtLozinka, "");
                        errorProvider1.SetError(txtLozinka2, "");
                        errorProvider1.SetError(txtTelefon, "");
                        errorProvider1.SetError(txtJMBG, "");
                        errorProvider1.SetError(cmbGrad, "");
                        errorProvider1.SetError(cmbVrsta, "");
                        errorProvider1.SetError(cmbPoslovnica, "");
                        return true;
                    }
                }
             
            }

             if (string.IsNullOrWhiteSpace(txtLozinka.Text) && _id==null)
            {
                
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "Obavezno polje !");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return  true;
            }
             if (txtLozinka.Text.Length < 5 && _id == null)
            {
                errorProvider1.SetError(txtLozinka, "Lozinka  mora sadržavati barem 5 karaktera!");
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
             if (string.IsNullOrWhiteSpace(txtLozinka2.Text) && _id == null)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "Obavezno polje !");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
             if (txtLozinka2.Text.Length < 5 && _id == null)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                errorProvider1.SetError(txtKorsIme, "Lozinka  mora sadržavati barem 5 karaktera!");
                return true;
            }


             if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "Obavezno polje !");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
            if (txtTelefon.Text.Length<9)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "Telefon mora sadržavati minimalno 9 brojeva !");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

            else if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "Obavezno polje !");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }

             if (txtJMBG.Text.Length !=13)
            {
                errorProvider1.SetError(txtJMBG, "JBMG  mora sadržavati 13 brojeva!");
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
           
             if (cmbGrad.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "Obavezno polje !");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
             if (cmbPoslovnica.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "Obavezno polje !");
                errorProvider1.SetError(cmbPoslovnica, "");
                return true;
            }
             if (cmbVrsta.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(txtIme, "");
                errorProvider1.SetError(txtPrezime, "");
                errorProvider1.SetError(txtAdresa, "");
                errorProvider1.SetError(txtKorsIme, "");
                errorProvider1.SetError(txtLozinka, "");
                errorProvider1.SetError(txtLozinka2, "");
                errorProvider1.SetError(txtTelefon, "");
                errorProvider1.SetError(txtJMBG, "");
                errorProvider1.SetError(cmbGrad, "");
                errorProvider1.SetError(cmbVrsta, "");
                errorProvider1.SetError(cmbPoslovnica, "Obavezno polje !");
                return true;
            }
            else
            {
                errorProvider1.SetError(cmbPoslovnica, "");

                return false;

            }
            return false;

        }

        private void TxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}














