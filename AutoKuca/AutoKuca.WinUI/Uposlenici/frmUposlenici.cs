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

namespace AutoKuca.WinUI.Uposlenici
{
    public partial class frmUposlenici : Form
    {

        private readonly APIService _radnici = new APIService("Uposlenik");
        private readonly APIService _vrsta = new APIService("VrstaUposlenika");

        public frmUposlenici()
        {
            InitializeComponent();
        }

        private async void FrmUposlenici_Load(object sender, EventArgs e)
        {
            await GetRadnici();
            await LoadVrste();
        }

        public async Task GetRadnici()
        {
            var result= await _radnici.Get<List<Model.Uposlenici>>(null);

       

            dgvRadnici.AutoGenerateColumns = false;
            dgvRadnici.DataSource = result;
           
           
        }

       
     

        private async Task LoadVrste()
        {
            var vrste = await _vrsta.Get<List<Model.VrsteUposlenika>>(null);

            vrste.Insert(0, new Model.VrsteUposlenika {
                VrstaUposlenikaId = 0,
                Naziv="Vrsta uposlenika"
            });
            cmbVrsta.DataSource = vrste;
            cmbVrsta.DisplayMember = "Naziv";
            cmbVrsta.ValueMember = "VrstaUposlenikaId";
        }

        private async void DgvRadnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRadnici.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvRadnici.Rows[e.RowIndex].Cells[0].Value;
                frmUposleniciDetalji forma = new frmUposleniciDetalji(int.Parse(id.ToString()), this);
                forma.Show();
            }

            if (dgvRadnici.Columns[e.ColumnIndex].Name == "Otpusti")
            {
                if(dgvRadnici.Rows[e.RowIndex].Cells[7].Value.ToString() == "Ne radi")
                {
                    MessageBox.Show("Radnik je već otpušten!");
                    return;
                }
                var id = dgvRadnici.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite otpustiti ovog radnika", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _radnici.Delete(id);
                    await GetRadnici();
                    MessageBox.Show("Status radnika promijenjen!");
                }
            }
        }

        private async void CmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrsta.SelectedValue;
            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadVrstaRadnici(id);
            }
        }

        private async Task LoadVrstaRadnici(int id)
        {
            UposleniciSearchRequest model = new UposleniciSearchRequest
            {
                vrstaID = id
            };
            var result = await _radnici.Get<List<Model.Uposlenici>>(model);
            dgvRadnici.DataSource = result;
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            var result =  await _radnici.Get<List<Model.Uposlenici>>(new UposleniciUpsertRequest {
                Ime = txtPret.Text,
            });

            dgvRadnici.DataSource = result;
        }
    }
}
