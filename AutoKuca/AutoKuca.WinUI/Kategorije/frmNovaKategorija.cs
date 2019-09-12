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

namespace AutoKuca.WinUI.Kategorije
{
    public partial class frmNovaKategorija : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorija");
        private frmKategorije _parent = null;
        private int? _id = null;
        public frmNovaKategorija(int? id = null, frmKategorije parent = null)
        {
            InitializeComponent();
            _parent = parent;
            _id = id;
        }

        private async void FrmNovaKategorija_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var res = await _kategorije.GetById<Model.Kategorija>(_id);
                txtNaziv.Text = res.Naziv;
                MemoryStream str = new MemoryStream(res.Slika);
                Image image = Image.FromStream(str);
                pictureBox1.Image = image;
            }
        }
        KategorijaUpsertRequest request = new KategorijaUpsertRequest();
        private void BtnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private async void BtnSpremi_Click(object sender, EventArgs e)
        {

            if ( await Validacija())
            {
                MessageBox.Show("Unesite tražena polja!");
            }
            else
            {
                request.Naziv = txtNaziv.Text;
                if (_id.HasValue)
                {
                    var nesto=await _kategorije.Update<Model.Kategorija>(_id, request);
                    if (nesto != default(Model.Kategorija))
                    {
                         _parent.RefreshKategorije();
                        MessageBox.Show("Uspješno promijenjen zapis!");
                    }
                    Close();
                  
                }
                else
                {
                    var nesto=await _kategorije.Insert<Model.Kategorija>(request);
                    if (nesto != default(Model.Kategorija))
                    {
                        MessageBox.Show("Uspješno ste dodali zapis!");
                        _parent.RefreshKategorije();
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
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }
            if (txtNaziv.Text.Length < 4)
            {
                errorProvider1.SetError(txtNaziv, "Naziv mora sadržavati barem 4 karaktera!");
                return true;
            }
            if ((txtNaziv.Text.Length) >= 4)
            {
                var lista = await _kategorije.Get<List<Model.Kategorija>>(null);
                foreach (var item in lista)
                {
                    if (txtNaziv.Text == item.Naziv)
                    {
                        errorProvider1.SetError(txtNaziv, "Kategorija već postoji u bazi !");

                        return true;
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                errorProvider1.SetError(txtSlika, "Obavezno polje !");
                return true;
            }
            return false;
        }

        private void TxtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
