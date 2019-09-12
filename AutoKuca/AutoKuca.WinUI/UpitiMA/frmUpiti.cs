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

namespace AutoKuca.WinUI.UpitiMA
{
    public partial class frmUpiti : Form
    {
        private readonly APIService _upiti = new APIService("UpitiVozila");
        public frmUpiti()
        {
            InitializeComponent();
        }

        private async void FrmUpiti_Load(object sender, EventArgs e)
        {
            await LoadUpiti();
        }

        public async Task LoadUpiti()
        {
            UpitiVozilaSearchRequest upit = new UpitiVozilaSearchRequest
            {
                VrstaUpitaID = 1
            };
            dgvUpiti.BackgroundColor = Color.White;
            dgvUpiti.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUpiti.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUpiti.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvUpiti.Columns.Count - 1; i++)
            {
                int colw = dgvUpiti.Columns[i].Width;
                dgvUpiti.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvUpiti.Columns[i].Width = colw;
            }
            var result = await _upiti.Get<List<Model.UpitiVozila>>(upit);
            dgvUpiti.AutoGenerateColumns = false;
            dgvUpiti.DataSource = result;

            List<Model.VrstaUpita> lista = new List<Model.VrstaUpita>();

            lista.Add(new Model.VrstaUpita {
                ID = 1,
                Vrsta = "Neodgovoreni"

            });

            lista.Add(new Model.VrstaUpita {
                ID = 2,
                Vrsta="Odgovoreni"
            });

            cmbUpiti.DataSource = lista;
            cmbUpiti.DisplayMember = "Vrsta";
            cmbUpiti.ValueMember = "ID";
            

        }

        private async void CmbUpiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbUpiti.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
                await LoadUpitiSearch(id);
        }

        private  async Task LoadUpitiSearch(int id)
        {
            UpitiVozilaSearchRequest upit = new UpitiVozilaSearchRequest
            {
                VrstaUpitaID = id
            };
            var result = await _upiti.Get<List<Model.UpitiVozila>>(upit);
            dgvUpiti.DataSource = result;

        }

        private void DgvUpiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUpiti.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvUpiti.Rows[e.RowIndex].Cells[0].Value;

                frmDetaljiUpita frm = new frmDetaljiUpita(this,int.Parse(id.ToString()));
                frm.Show();
            }
        }
    }
}
