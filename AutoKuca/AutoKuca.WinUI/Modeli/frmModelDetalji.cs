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

namespace AutoKuca.WinUI.Modeli
{
    public partial class frmModelDetalji : Form
    {
        private int? _id = null;
        private frmModeli _parent = null;
        private readonly APIService _model = new APIService("Model");
        private readonly APIService _marke = new APIService("Marka");

        public frmModelDetalji(int? id=null, frmModeli parent=null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmModelDetalji_Load(object sender, EventArgs e)
        {
           await LoadMarke();
        }

        private async Task LoadMarke()
        {
            if (_id.HasValue)
            {
                var model = await _model.GetById<Model.Modeli>(_id);
                var marke = await _marke.Get<List<Model.Marke>>(null);
                marke.Insert(0, new Model.Marke
                {
                    MarkaId = model.MarkaId,
                    Naziv = model.NazivMarke
                }

                );
                txtModel.Text = model.Naziv;
                cmbMarke.DataSource = marke;
                cmbMarke.DisplayMember = "Naziv";
                cmbMarke.ValueMember = "MarkaId";

            }
            else
            {
                var marke = await _marke.Get<List<Model.Marke>>(null);
                marke.Insert(0, new Model.Marke());
                cmbMarke.DataSource = marke;
                cmbMarke.DisplayMember = "Naziv";
                cmbMarke.ValueMember = "MarkaId";

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
                ModeliUpsertRequest request = new ModeliUpsertRequest();

                var MarkaId = cmbMarke.SelectedValue;

                if (int.TryParse(MarkaId.ToString(), out int id))
                {
                    request.MarkaId = id;
                }

                request.Naziv = txtModel.Text;

                if (_id.HasValue)
                {
                  var nesto= await _model.Update<Model.Modeli>(_id, request);
                    if (nesto != default(Model.Modeli))
                    {
                        await _parent.RefreshModeli();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                    Close();
                }
                else
                {
                   var nesto= await _model.Insert<Model.Modeli>(request);
                    if (nesto != default(Model.Modeli))
                    {
                        if (_parent != null)
                        {
                            await _parent.RefreshModeli();
                        }
                        MessageBox.Show("Uspješno ste dodali zapis!");
                    }
                    Close();

                }
            }
            

        }   

        private async Task< bool> Validacija()
        {
               
            
             if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                errorProvider1.SetError(txtModel, "Obavezno polje !");
                return true;

            }
            if ((txtModel.Text.Length) > 1)
            {
                var lista = await _model.Get<List<Model.Modeli>>(null);
                foreach (var item in lista)
                {
                    if (txtModel.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtModel, "Model već postoji u bazi !");

                        return true;
                    }
                }
            }
         
            if (cmbMarke.SelectedIndex == 0 && _id==null)
            {
                errorProvider1.SetError(cmbMarke, "Obavezno polje !");
                return true;
            }
            return false;
        }

      

      
    }
}
