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

namespace AutoKuca.WinUI.Marke
{
    public partial class frmMarkeDetallji : Form
    {
        private int? _id = null;
        private frmMarke _parent = null;
        private readonly APIService _marke = new APIService("Marka");
        public frmMarkeDetallji(int? id = null, frmMarke parent = null)
        {

            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmMarkeDetallji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var marka = await _marke.GetById<Model.Marke>(_id);
                txtNaziv.Text = marka.Naziv;
            }

        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {

            if (await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");

            }
            else { 

            MarkeUpsertRequest request = new MarkeUpsertRequest();

            request.Naziv = txtNaziv.Text;

            if (_id.HasValue)
            {
               var nesto= await _marke.Update<Model.Marke>(_id, request);
                    if (nesto != default(Model.Marke))
                    {
                        _parent.RefreshMarke();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                Close();
            }
            else
            {
                var nesto=await _marke.Insert<Model.Marke>(request);
                    if (nesto != default(Model.Marke))
                    {
                        _parent.RefreshMarke();
                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                Close();
            }
            }

        }


        private async Task< bool>  Validacija()
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, "Obavezno polje !");
                return true;
            }
            if ((txtNaziv.Text.Length) > 1)
            {
                var lista = await _marke.Get<List<Model.Marke>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Marka već postoji u bazi !");

                        return true;
                    }
                }
            }
            return false;
        }
      

     
    }
}
