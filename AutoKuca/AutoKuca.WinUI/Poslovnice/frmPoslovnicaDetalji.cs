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

namespace AutoKuca.WinUI.Poslovnice
{
    public partial class frmPoslovnicaDetalji : Form
    {
        private int? _id = null;
        private frmPoslovnice _parent = null;
        private readonly APIService _poslovnice = new APIService("Poslovnica");
        private readonly APIService _gradovi = new APIService("Grad");

        public frmPoslovnicaDetalji(int? id=null,frmPoslovnice frm=null)
        {
            InitializeComponent();
            _id = id;
            _parent = frm;
        }

        private async void FrmPoslovnicaDetalji_Load(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                lblPos.Text = "Nova poslovnica";
            }
            await GetPodaci();
        }

        private async Task GetPodaci()
        {
            var gradovi = await _gradovi.Get<List<Model.Gradovi>>(null);

            if (_id.HasValue)
            {
                var res = await _poslovnice.GetById<Model.Poslovnice>(_id);

                txtNaziv.Text = res.Naziv;
                txtAdresa.Text = res.Adresa;
                txtTelefon.Text = res.Telefon;

                if (res.Status == true)
                {
                    Status.Checked = true;
                }
                else
                {
                    Status.Checked = false;
                }

                gradovi.Insert(0, new Model.Gradovi {
                    GradId = res.GradId,
                    Naziv=res.Grad
                });
                cmbGrad.DataSource = gradovi;
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "GradId";
                

            }
            else
            {
                gradovi.Insert(0, new Model.Gradovi());
                cmbGrad.DataSource = gradovi;
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "GradId";
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if (await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else
            {
                PoslovniceUpsertRequest request = new PoslovniceUpsertRequest();

                request.Naziv = txtNaziv.Text;
                request.Adresa = txtAdresa.Text;
                request.Telefon = txtTelefon.Text;

                var idObj = cmbGrad.SelectedValue;

                if (int.TryParse(idObj.ToString(), out int id))
                {
                    request.GradId = id;
                }

                if (Status.Checked == true)
                {
                    request.Status = true;
                }
                else
                {
                    request.Status = false;
                }

                if (_id.HasValue)
                {
                    var nesto=await _poslovnice.Update<Model.Poslovnice>(_id, request);
                    if (nesto != default(Model.Poslovnice))
                    {
                        await _parent.GetPoslovnice();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                    Close();
                }
                else
                {
                    var nesto=await _poslovnice.Insert<Model.Poslovnice>(request);
                    if (nesto != default(Model.Poslovnice))
                    {
                        await _parent.GetPoslovnice();
                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                    Close();
                }
            }
            
        }


        private async Task<bool> Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Obavezno polje !");
               return true;
            }
           
            if (txtNaziv.Text.Length < 4)
            {
                errorProvider1.SetError(txtNaziv, "Naziv mora sadržavati najmanje 4 karaktera");
                return true;
            }
            else if (txtNaziv.Text.Length >= 3)
            {
                var lista = await _poslovnice.Get<List<Model.Poslovnice>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Poslovnica sa istim nazivom već postoji u bazi !");

                        return true;
                    }
                }

            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, "Obavezno polje !");
               return true;
            }
        
            if (txtAdresa.Text.Length < 4)
            {
                errorProvider1.SetError(txtAdresa, "Naziv mora sadržavati najmanje 4 karaktera");
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Obavezno polje !");
                return true;
            }
          
            if (cmbGrad.SelectedIndex == 0 && _id==null)
            {
                errorProvider1.SetError(cmbGrad, "Obavezno polje !");
            }
            return false;
        }

        private void TxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
