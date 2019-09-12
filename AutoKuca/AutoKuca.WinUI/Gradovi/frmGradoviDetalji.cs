using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Gradovi
{
    public partial class frmGradoviDetalji : Form
    {

        private readonly APIService _gradovi = new APIService("Grad");
        private int? _id = null;
        private frmGradovi _parent = null;
        public frmGradoviDetalji(int? id = null, frmGradovi frm = null)
        {
            InitializeComponent();
            _id = id;
            _parent = frm;
        }

        private async void FrmGradoviDetalji_Load(object sender, EventArgs e)
        {
            if (!_id.HasValue)
            {
                lblG.Text = "Novi grad";

            }
            else
            {
                var result = await _gradovi.GetById<Model.Gradovi>(_id);
                txtNaziv.Text = result.Naziv;
            }


        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if ( await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else
            {

                if (_id.HasValue)
                {
                   var nesto= await _gradovi.Update<Model.Gradovi>(_id, new GradoviUpsertRequest
                    {
                        Naziv = txtNaziv.Text
                    });
                    if (nesto != default(Model.Gradovi))
                    {
                        await _parent.GetGradovi();
                        MessageBox.Show("Zapis uspiješno promijenjen!");
                    }
                    Close();
                }
                else
                {
                   var nesto=await _gradovi.Insert<Model.Gradovi>(new GradoviUpsertRequest
                    {
                        Naziv = txtNaziv.Text
                    });
                    if (nesto != default(Model.Gradovi))
                    {
                        await _parent.GetGradovi();
                        MessageBox.Show("Zapis uspiješno sačuvan!");
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
           else if (txtNaziv.Text.Length <=2)
            {
                errorProvider1.SetError(txtNaziv, "Naziv mora sadržavati barem 3 karaktera!");
                return true;

            }
            else if (txtNaziv.Text.Length >= 3)
            {
                var lista = await _gradovi.Get<List<Model.Gradovi>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Grad već postoji u bazi !");
                       
                        return true;
                    }
                }

            }
            return false;
        }

        private void TxtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
