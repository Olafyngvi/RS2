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

namespace AutoKuca.WinUI.Dijelovi
{
    public partial class frmNoviDio : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorija");
        private readonly APIService _model = new APIService("Model");
        private readonly APIService _dio = new APIService("Dio");
        private readonly APIService _marka = new APIService("Marka");
        private readonly int? _id = null;
        private readonly frmDijelovi _parent = null;

        public frmNoviDio(int? id=null, frmDijelovi parent =null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmNoviDio_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var dio =await _dio.GetById<Model.Dio>(_id);
                txtNaziv.Text = dio.Naziv;
                txtCijena.Text = dio.Cijena.ToString();
                txtSifra.Text = dio.Sifra;
                txtStanje.Text = dio.Stanje.ToString();
                var kategorije =await _kategorije.Get<List<Model.Kategorija>>(null);
                kategorije.Insert(0, new Model.Kategorija
                {
                    KategorijaId = dio.KategorijaId,
                    Naziv = dio.Kategorija
                });
                cmbKategorija.DataSource = kategorije;
                cmbKategorija.DisplayMember = "Naziv";
                cmbKategorija.ValueMember = "KategorijaId";
                cmbKategorija.SelectedIndex = dio.KategorijaId;
                var modeli = await _model.Get<List<Model.Modeli>>(null);
                modeli.Insert(0, new Model.Modeli
                {
                    ModelId = dio.ModelId,
                    Naziv = dio.Model,
                });
                cmbModel.DataSource = modeli;
                cmbModel.DisplayMember = "Naziv";
                cmbModel.ValueMember = "ModelId";
                cmbModel.SelectedIndex = dio.ModelId;

                
            }
            else
            {
                var kategorije = await _kategorije.Get<List<Model.Kategorija>>(null);
                kategorije.Insert(0, new AutoKuca.Model.Kategorija
                {
                    KategorijaId = 0,
                    Naziv = "Kategorije"
                });
                cmbKategorija.DataSource = kategorije;
                cmbKategorija.DisplayMember = "Naziv";
                cmbKategorija.ValueMember = "KategorijaId";
                cmbKategorija.SelectedIndex = 0;
                
                var marke =await _marka.Get<List<Model.Marke>>(null);
                marke.Insert(0, new AutoKuca.Model.Marke
                {
                    MarkaId = 0,
                    Naziv = "Marke"
                });
                cmbMarke.DataSource = marke;
                cmbMarke.DisplayMember = "Naziv";
                cmbMarke.ValueMember = "MarkaId";
                cmbMarke.SelectedIndex = 0;

                cmbModel.Enabled = false;

            }
        }

        private async void BtnSpremi_Click(object sender, EventArgs e)
        {
            if (await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");

            }
            else
            {
                errorProvider1.SetError(cmbKategorija, null);
                errorProvider1.SetError(cmbModel, null);
                DioUpsertRequest req = new DioUpsertRequest
                {
                    Naziv = txtNaziv.Text,
                    Cijena = double.Parse(txtCijena.Text),
                    Sifra = txtSifra.Text,
                    Stanje = int.Parse(txtStanje.Text),
                    KategorijaId = int.Parse(cmbKategorija.SelectedValue.ToString()),
                    ModelId = int.Parse(cmbModel.SelectedValue.ToString())
                };
                if (_id.HasValue)
                {
                    req.DioId = _id ?? default(int);

                    var nesto=await _dio.Update<Model.Dio>(_id, req);
                    if (nesto != default(Model.Dio))
                    {
                      await  _parent.ReloadDijelovi();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
               
                    Close();
                }
                else
                {
                    var nesto=await _dio.Insert<Model.Dio>(req);
                    if (nesto != default(Model.Dio))
                    {
                        if (_parent != null)
                        {
                            await _parent.ReloadDijelovi();
                            MessageBox.Show("Uspješno ste dodali zapis!");
                            Close();
                        }
                        else
                        {
                            Close();
                            frmDijelovi forma = new frmDijelovi();
                            forma.Show();
                        }
                       
                    }
                  
                }
            

            }
        }


        private async Task< bool> Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Obavezno polje !");
                return true;
            }
          
            if (txtNaziv.Text.Length < 3 || txtNaziv.Text.Length > 30)
            {
                errorProvider1.SetError(txtNaziv, "Naziv mora sadržavati barem 3 karaktera, ne više od 30 !");
                return true;
            }
            
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, "Obavezno polje !");
                return true;
            }
          
            if (txtCijena.Text.Length < 1 || txtCijena.Text.Length > 5)
            {
                errorProvider1.SetError(txtCijena, "Cijena mora biti u intervalu od 1 do 3000 !");
                return true;
            }
         
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                errorProvider1.SetError(txtSifra, "Obavezno polje !");
                return true;
            }

            if (txtSifra.Text.Length < 4 || txtSifra.Text.Length > 5)
            {
                errorProvider1.SetError(txtSifra, "Šifra mora sadržavati od 4 do 5 karaktera !");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtStanje.Text))
            {
                errorProvider1.SetError(txtStanje, "Obavezno polje !");
                return true;
            }
         
            if (txtStanje.Text.Length < 1 || txtStanje.Text.Length > 3)
            {
                errorProvider1.SetError(txtStanje, "Stanje mora biti u intervalu od 1 do 100 !");
                return true;
            }
          
            if (cmbKategorija.SelectedIndex == 0 && _id==null )
            {

                errorProvider1.SetError(cmbKategorija, "Obavezno polje !");
                return true;

            }
            if (cmbModel.SelectedIndex == 0 && _id == null)
            {
                errorProvider1.SetError(cmbModel, "Obavezno polje !");
                return true;

            }

            return false;
          
        }

        private void TxtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void TxtStanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private async void CmbMarke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Enabled = false;
            var selected = cmbMarke.SelectedItem as Model.Marke;
            ModeliSearchRequest req = new ModeliSearchRequest()
            {
                MarkaId = selected.MarkaId
            };
            var modeli = await _model.Get<List<Model.Modeli>>(req);
            modeli.Insert(0, new AutoKuca.Model.Modeli
            {
                ModelId = 0,
                Naziv = "Modeli",
            });
            cmbModel.DataSource = modeli;
            cmbModel.DisplayMember = "Naziv";
            cmbModel.ValueMember = "ModelId";
            cmbModel.SelectedIndex = 0;
            cmbModel.Enabled = true;
        }
    }
}
