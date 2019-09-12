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

namespace AutoKuca.WinUI.Oprema
{
    public partial class frmOpremaDetalji : Form
    {
        private int? _id = null;
        private frmOprema _parent = null;
        private readonly APIService _oprema = new APIService("Oprema");
        public frmOpremaDetalji(int? id=null,frmOprema parent=null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmOpremaDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue){
                var model = await _oprema.GetById<Model.Opreme>(_id);
                txtNaziv.Text = model.Naziv;
                txtOpis.Text = model.Opis;
            }
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {

            if (await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else { 

            OpremeUpsertRequest request = new OpremeUpsertRequest();

            request.Naziv = txtNaziv.Text;
            request.Opis = txtOpis.Text;

            if (_id.HasValue)
            {
                var nesto=await _oprema.Update<Model.Opreme>(_id, request);
                    if (nesto != default(Model.Opreme))
                    {
                        await _parent.RefreshOprema();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                Close();
            }
            else
            {
                var nesto=await _oprema.Insert<Model.Opreme>(request);
                    if (nesto != default(Model.Opreme))
                    {
                        await _parent.RefreshOprema();
                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                Close();
            }
            }

        }

        private async Task <bool> Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Obavezno polje !");
                 return true;
            }
            if ((txtNaziv.Text.Length) > 1)
            {
                var lista = await _oprema.Get<List<Model.Opreme>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Oprema već postoji u bazi !");

                        return true;
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, "Obavezno polje !");
                return  true;
            }
          
            if (txtOpis.Text.Length < 20)
            {
                errorProvider1.SetError(txtOpis, "Opis mora sadržavati najmanje 20 karaktera");
                return true;
            }

            return false;
        }

     
    }
}
