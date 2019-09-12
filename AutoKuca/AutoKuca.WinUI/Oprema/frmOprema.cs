using AutoKuca.Model;
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

namespace AutoKuca.WinUI.Oprema
{
    public partial class frmOprema : Form
    {
        private readonly APIService _oprema = new APIService("Oprema");
        public frmOprema()
        {
            InitializeComponent();
        }

        private async void Oprema_Load(object sender, EventArgs e)
        {

            await RefreshOprema();
        }

        public async Task RefreshOprema()
        {
            dgvOprema.BackgroundColor = Color.White;
            dgvOprema.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOprema.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvOprema.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvOprema.Columns.Count - 1; i++)
            {
                int colw = dgvOprema.Columns[i].Width;
                dgvOprema.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvOprema.Columns[i].Width = colw;
            }
            var result = await _oprema.Get<List<Opreme>>(null);
            dgvOprema.DataSource = result;
        }
        private async void DgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOprema.Columns[e.ColumnIndex].Name == "Izmjeni")
            {
                var id = dgvOprema.Rows[e.RowIndex].Cells[1].Value;

                frmOpremaDetalji forma = new frmOpremaDetalji(int.Parse(id.ToString()),this);
                forma.Show();
            }

            if (dgvOprema.Columns[e.ColumnIndex].Name == "Obriši")
            {
                var id = dgvOprema.Rows[e.RowIndex].Cells[1].Value;

                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    

                    HttpResponseMessage delete = await _oprema.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                        await RefreshOprema();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                }




            }
        }
    }
}
