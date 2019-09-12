using AutoKuca.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.TipVozila
{
    public partial class frmDetaljiTipova : Form
    {
        private readonly APIService _tip = new APIService("TipVozila");
        private int? _id = null;
        private frmTipovi _parent = null;
        public frmDetaljiTipova(int ? id=null,frmTipovi parent=null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmDetaljiTipova_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _tip.GetById<Model.TipoviVozila>(_id);
                txtNaziv.Text = model.Naziv;
            }
        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {

            if (await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else
            {

            
            TipoviUpsertRequest request = new TipoviUpsertRequest()
            {
                Naziv = txtNaziv.Text
            };

        
            if (_id.HasValue)
            {
                var nesto=await _tip.Update<Model.TipoviVozila>(_id,request);
                    if (nesto != default(Model.TipoviVozila))
                    {
                        await _parent.RefreshTipovi();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                Close();
            }
            else
            {

                var nesto=await _tip.Insert<Model.TipoviVozila>(request);
                    if (nesto != default(Model.TipoviVozila))
                    {
                        await _parent.RefreshTipovi();
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
         
            if (txtNaziv.Text.Length <2 )
            {
                errorProvider1.SetError(txtNaziv, "Naziv mora sadržavati barem 3 karaktera !");
               return true;
            }
            if ((txtNaziv.Text.Length) > 2)
            {
                var lista = await _tip.Get<List<Model.TipoviVozila>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Tip vozila već postoji u bazi !");

                        return true;
                    }
                }
            }
            return false;
        }

      
    }
}
