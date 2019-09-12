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

namespace AutoKuca.WinUI.TipVozila
{
    public partial class frmTipovi : Form
    {
        private readonly APIService _tip = new APIService("TipVozila");
        public frmTipovi()
        {
            InitializeComponent();
        }

        private async void FrmTipovi_Load(object sender, EventArgs e)
        {
       
            await RefreshTipovi();
        }

        public async Task RefreshTipovi()
        {
            dgvTipovi.BackgroundColor = Color.White;
            dgvTipovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTipovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTipovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvTipovi.Columns.Count - 1; i++)
            {
                int colw = dgvTipovi.Columns[i].Width;
                dgvTipovi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvTipovi.Columns[i].Width = colw;
            }
            var data = await _tip.Get<List<Model.TipoviVozila>>(null);
            dgvTipovi.AutoGenerateColumns = false;
            dgvTipovi.DataSource = data;
        }
        private async void DgvTipovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvTipovi.Columns[e.ColumnIndex].Name == "Izmjeni")
            {
                var id = dgvTipovi.Rows[e.RowIndex].Cells[0].Value;

                frmDetaljiTipova forma = new frmDetaljiTipova(int.Parse(id.ToString()),this);
                forma.Show();
            }

            if (dgvTipovi.Columns[e.ColumnIndex].Name == "Obriši")
            {
                var id = dgvTipovi.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                    HttpResponseMessage delete = await _tip.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                        await RefreshTipovi();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                }

            }
        }

       
    }
}
