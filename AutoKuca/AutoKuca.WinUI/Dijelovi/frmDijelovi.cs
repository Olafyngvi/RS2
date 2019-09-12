using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Dijelovi
{
    public partial class frmDijelovi : Form
    {
        private readonly APIService _dijelovi = new APIService("Dio");
        private readonly APIService _modeli = new APIService("Model");
        private readonly APIService _kategorije = new APIService("Kategorija");
        private int? _kategorijaTrenutno = null;
        private int? _modelTrenutno = null;

        public frmDijelovi()
        {
            InitializeComponent();
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objId = dgvDijelovi.Rows[e.RowIndex].Cells[0].Value;
            if (dgvDijelovi.Columns[e.ColumnIndex].Name == "Obrisi")
            {
                if(MessageBox.Show("Jeste li sigurni da zelite obrisati odabrani dio ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    HttpResponseMessage delete = await _dijelovi.Delete(objId);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                        await ReloadDijelovi();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                }
            }
            else {
                if (int.TryParse(objId.ToString(), out int id))
                {
                    frmNoviDio forma = new frmNoviDio(id, this);
                    forma.Show();
                }
            }
        }

        private async void FrmDijelovi_Load(object sender, EventArgs e)
        {
            await ReloadDijelovi();

        }

        public async Task ReloadDijelovi()
        {
            await LoadDijelovi();
            await LoadKategorije();
            await LoadModeli();
        }

        private async Task LoadModeli()
        {
            var result = await _modeli.Get<List<Model.Modeli>>(null);
            result.Insert(0, new Model.Modeli
            {
                Naziv = "Modeli",
                ModelId = 0
            });
            cmbModeli.DataSource = result;
            cmbModeli.DisplayMember = "Naziv";
            cmbModeli.ValueMember = "ModelId";

        }

        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija
            {
                Naziv = "Kategorije",
                KategorijaId = 0
            });
            cmbKategorija.DataSource = result;
            cmbKategorija.DisplayMember = "Naziv";
            cmbKategorija.ValueMember = "KategorijaId";

        }

        private async Task LoadDijelovi()
        {
            dgvDijelovi.BackgroundColor = Color.White;
            dgvDijelovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDijelovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDijelovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvDijelovi.Columns.Count - 1; i++)
            {
                int colw = dgvDijelovi.Columns[i].Width;
                dgvDijelovi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvDijelovi.Columns[i].Width = colw;
            }
            var result = await _dijelovi.Get<List<Model.Dio>>(null);
            dgvDijelovi.AutoGenerateColumns = false;
            dgvDijelovi.DataSource = result;
        }

        private async void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var objId = cmbKategorija.SelectedValue;
            if (int.TryParse(objId.ToString(), out int id))
            {
                await ReloadDijeloviKategorije(id);
            }
        }

        private async Task ReloadDijeloviKategorije(int id)
        {
            DioSearchRequest req = new DioSearchRequest();
            if (_modelTrenutno != null)
            {
                req.ModelId = _modelTrenutno??default(int);
                req.KategorijaId = id;
            }
            else {
                req.KategorijaId = id;
            };
            _kategorijaTrenutno = id;
            var result = await _dijelovi.Get<List<Model.Dio>>(req);
            dgvDijelovi.DataSource = result;
          
        }

        private async void CmbModeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objId = cmbModeli.SelectedValue;
            if(int.TryParse(objId.ToString(),out int id))
            {
                await ReloadDijeloviModeli(id);
            }
        }

        private async Task ReloadDijeloviModeli(int id)
        {
            DioSearchRequest req = new DioSearchRequest();
            if (_kategorijaTrenutno != null)
            {
                req.KategorijaId = _kategorijaTrenutno ?? default(int);
                req.ModelId = id;
            }
            else
            {
                req.ModelId = id;
            }
            _modelTrenutno = id;
            var result = await _dijelovi.Get<List<Model.Dio>>(req);
            dgvDijelovi.DataSource = result;
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            DioSearchRequest req = new DioSearchRequest();
            if (_modelTrenutno != null)
            {
                req.ModelId = _modelTrenutno ?? default(int);
            }
            else if (_kategorijaTrenutno != null)
            {
                req.KategorijaId = _kategorijaTrenutno ?? default(int);
            }
            req.Naziv = txtSearch.Text;
            var result = await _dijelovi.Get<List<Model.Dio>>(req);
            dgvDijelovi.DataSource = result;
        }
    }
}
