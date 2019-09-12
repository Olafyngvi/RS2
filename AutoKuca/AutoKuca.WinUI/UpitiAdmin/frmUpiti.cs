using AutoKuca.Model;
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

namespace AutoKuca.WinUI.UpitiAdmin
{
    public partial class frmUpiti : Form
    {

        private readonly APIService _upiti = new APIService("AdminUpiti");

        public frmUpiti()
        {
            InitializeComponent();
        }

        private async void FrmUpiti_Load(object sender, EventArgs e)
        {
            await LoadPodaci();
        }

        public async Task LoadPodaci()
        {

            UpitiVozilaSearchRequest vrsta = new UpitiVozilaSearchRequest
            {
                VrstaUpitaID = 1
            };

            var result = await _upiti.Get<List<Model.UpitiAdmin>>(vrsta);

            dgvUpiti.AutoGenerateColumns = false;
            dgvUpiti.DataSource = result;

            List<VrstaUpita> vrsta2 = new List<VrstaUpita>();

            vrsta2.Add(new VrstaUpita {
                ID = 1,
                Vrsta = "Neodgovoreni"
            });

            vrsta2.Add(new VrstaUpita
            {
                ID=2,
                Vrsta="Odgovoreni"
            });

            cbPretraga.DataSource = vrsta2;
            cbPretraga.DisplayMember = "Vrsta";
            cbPretraga.ValueMember = "ID";
            
        }

        private async void CbPretraga_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cbPretraga.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
                await LoadSearch(id);
        }

        private async Task LoadSearch(int id)
        {

            UpitiVozilaSearchRequest vrsta = new UpitiVozilaSearchRequest
            {
                VrstaUpitaID = id
            };

            dgvUpiti.DataSource = await _upiti.Get<List<Model.UpitiAdmin>>(vrsta);
        }

        private void DgvUpiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUpiti.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvUpiti.Rows[e.RowIndex].Cells[0].Value;

                frmUpitDetalji frm = new frmUpitDetalji(this,int.Parse(id.ToString()));
                frm.Show();
            }
        }
    }
}
