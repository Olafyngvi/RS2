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

namespace AutoKuca.WinUI.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        public frmGradovi()
        {
            InitializeComponent();
        }

        private  async void FrmGradovi_Load(object sender, EventArgs e)
        {
           await  GetGradovi();
        }

        public async Task GetGradovi()
        {
           
                var result = await _gradovi.Get<List<Model.Gradovi>>(null);
                dgvGradovi.AutoGenerateColumns = false;
                dgvGradovi.DataSource = result;
            
          
       
           
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(new GradoviSearchRequst {
                Naziv = txtPretraga.Text
            });

            dgvGradovi.DataSource = result;
        }

        private async void DgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGradovi.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvGradovi.Rows[e.RowIndex].Cells[0].Value;

                frmGradoviDetalji frm = new frmGradoviDetalji(int.Parse(id.ToString()), this);
                frm.Show();

            }
            else if (dgvGradovi.Columns[e.ColumnIndex].Name == "Obriši")
            {
                var id = dgvGradovi.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
             
                    HttpResponseMessage delete = await _gradovi.Delete(id);
                    if (delete.StatusCode != System.Net.HttpStatusCode.InternalServerError)
                    {
                        await GetGradovi();
                        MessageBox.Show("Zapis uspješno obrisan");
                    }
                }
            }
        }
    }
}
