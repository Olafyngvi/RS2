using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoKuca.Model.Requests;
using Flurl;
using Flurl.Http;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using AutoKuca.Model;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace AutoKuca.WinUI.Modeli
{
    public partial class frmModeli : Form
    {

        private readonly APIService _apiService = new APIService("model");
        public frmModeli()
        {
            InitializeComponent();
        }

        private async  void BtnPrikazi_Click(object sender, EventArgs e)
        {
            var pretraga = new ModeliSearchRequest() {
                Naziv = txtPretraga.Text
             
            };
            var result = await  _apiService.Get<List<Model.Modeli>>(pretraga);
            dgvModeli.DataSource = result;
        }

        private async void FrmModeli_Load(object sender, EventArgs e)
        {

            await RefreshModeli();
        }

        public async Task RefreshModeli()
        {
            dgvModeli.BackgroundColor = Color.White;
            dgvModeli.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModeli.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvModeli.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvModeli.Columns.Count - 1; i++)
            {
                int colw = dgvModeli.Columns[i].Width;
                dgvModeli.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvModeli.Columns[i].Width = colw;
            }
            var result = await _apiService.Get<List<Model.Modeli>>(null);
            dgvModeli.AutoGenerateColumns = false;
            dgvModeli.DataSource = result;
        }

        public  void PrikaziFormu()
        {
            
          frmModelDetalji forma = new frmModelDetalji(null, this);
           forma.Show();
            
        }


        private async void DgvModeli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvModeli.Columns[e.ColumnIndex].Name == "Izmjeni")
            {
                var id = dgvModeli.Rows[e.RowIndex].Cells[0].Value;

                frmModelDetalji forma = new frmModelDetalji(int.Parse(id.ToString()),this);
                forma.Show();
            }

           else if (dgvModeli.Columns[e.ColumnIndex].Name == "Obriši")
            {
                var id = dgvModeli.Rows[e.RowIndex].Cells[0].Value;
                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HttpResponseMessage delete = await _apiService.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                        await RefreshModeli();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                  
                }
            }
           


        }

       

    }
}
