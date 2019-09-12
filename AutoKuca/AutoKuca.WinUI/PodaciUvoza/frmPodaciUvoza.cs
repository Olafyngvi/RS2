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

namespace AutoKuca.WinUI.PodaciUvoza
{
    public partial class frmPodaciUvoza : Form
    {
        private readonly APIService _podaci = new APIService("PodaciUvoza");
        private readonly APIService _poslovnica = new APIService("Poslovnica");

        public frmPodaciUvoza()
        {
            InitializeComponent();
        }

        private async void FrmPodaciUvoza_Load(object sender, EventArgs e)
        {
            await GetPodaci();
            await LoadCMb();
        }

        public  async Task LoadCMb()
        {
            var poslovnice = await _poslovnica.Get<List<Model.Poslovnice>>(null);

            poslovnice.Insert(0, new Model.Poslovnice {
                PoslovnicaId = 0,
                Naziv="Poslovnica"
            });

            cmbPoslovnica.DataSource = poslovnice;
            cmbPoslovnica.DisplayMember = "Naziv";
            cmbPoslovnica.ValueMember = "PoslovnicaId";

        }

        public async Task GetPodaci()
        {
            var result = await _podaci.Get<List<Model.PodaciUvoza>>(null);
            dgvPodaci.AutoGenerateColumns = false;
            dgvPodaci.DataSource = result;
        }

        private void DgvPodaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPodaci.Columns[e.ColumnIndex].Name == "Izmjeni")
            {
                var id = dgvPodaci.Rows[e.RowIndex].Cells[0].Value;

                frmPodaciUvozaDetalji frm = new frmPodaciUvozaDetalji(int.Parse(id.ToString()), this);
                frm.Show();
            }
        }

        private async void CmbPoslovnica_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idobj = cmbPoslovnica.SelectedValue;
            if(int.TryParse(idobj.ToString(),out int id))
            {
                await LoadPoslovnice(id);
            }
        }

        private async Task LoadPoslovnice(int id)
        {
            var result = await _podaci.Get<List<Model.PodaciUvoza>>(new PodaciUvozaSearchRequest
            {
                PoslovnicaId = id
            });

            dgvPodaci.DataSource = result;

        }
    }
}
