using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Kategorije
{
    public partial class frmKategorije : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorija");
        public frmKategorije()
        {
            InitializeComponent();
        }

        private async void FrmKategorije_Load(object sender, EventArgs e)
        {
            dgvKategorije.BackgroundColor = Color.White;
            dgvKategorije.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKategorije.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvKategorije.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvKategorije.Columns.Count - 1; i++)
            {
                int colw = dgvKategorije.Columns[i].Width;
                dgvKategorije.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvKategorije.Columns[i].Width = colw;
            }
            var result = await _kategorije.Get<List<Model.Kategorija>>(null);
            dgvKategorije.AutoGenerateColumns = false;
            dgvKategorije.DataSource = result;
        }

        private async void DgvKategorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvKategorije.Rows[e.RowIndex].Cells[0].Value;
            if (dgvKategorije.Columns[e.ColumnIndex].Name == "Obrisi") { 
                if (MessageBox.Show("Da li se sigurni da zelite obrisati odabranu kategoriju ?", "Brisanje", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
              
                    HttpResponseMessage delete = await _kategorije.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                         RefreshKategorije();
                        MessageBox.Show("Zapis uspjesno obrisan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                } 
            }
            if(dgvKategorije.Columns[e.ColumnIndex].Name== "Izmijeni")
            {
                frmNovaKategorija forma = new frmNovaKategorija(int.Parse(id.ToString()), new frmKategorije());
                forma.Show();
            }
        }
        public async void RefreshKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorija>>(null);
            dgvKategorije.AutoGenerateColumns = false;
            dgvKategorije.DataSource = result;
        }
    }
}
