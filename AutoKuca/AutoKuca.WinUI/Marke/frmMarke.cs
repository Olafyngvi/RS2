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

namespace AutoKuca.WinUI.Marke
{
    public partial class frmMarke : Form
    {
        private readonly APIService _marke = new APIService("Marka");
        public frmMarke()
        {
            InitializeComponent();
        }

        private async void FrmMarke_Load(object sender, EventArgs e)
        {
            var result = await _marke.Get<List<Model.Marke>>(null);
            dgvMarke.AutoGenerateColumns = false;
            dgvMarke.DataSource = result;
        }

        public async void RefreshMarke()
        {
            dgvMarke.BackgroundColor = Color.White;
            dgvMarke.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMarke.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMarke.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvMarke.Columns.Count - 1; i++)
            {
                int colw = dgvMarke.Columns[i].Width;
                dgvMarke.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvMarke.Columns[i].Width = colw;
            }
            var result = await _marke.Get<List<Model.Marke>>(null);
            dgvMarke.AutoGenerateColumns = false;
            dgvMarke.DataSource = result;
        }

   

        private  async void DgvMarke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarke.Columns[e.ColumnIndex].Name == "Izmjeni")
            {
                var  id = dgvMarke.Rows[e.RowIndex].Cells[0].Value;

                frmMarkeDetallji forma = new frmMarkeDetallji(int.Parse(id.ToString()),this);
                forma.Show();
            }

            if (dgvMarke.Columns[e.ColumnIndex].Name == "Obriši")
            {
               var  id = dgvMarke.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                
                    HttpResponseMessage delete = await _marke.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                         RefreshMarke();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                }




            }
        }
    }
}
