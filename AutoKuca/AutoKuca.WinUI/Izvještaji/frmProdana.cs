using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Vozila
{
    public partial class frmProdana : Form
    {
        private readonly APIService _vozila = new APIService("Prodana");
        private frmVozila _formV = null;
        public frmProdana()
        {
            InitializeComponent();
           
        }

        private void FrmProdana_Load(object sender, EventArgs e)
        {
            GetVozila();
        }

        public async void GetVozila()
        {
            dgvProdana.BackgroundColor = Color.White;
            dgvProdana.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProdana.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvProdana.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvProdana.Columns.Count - 1; i++)
            {
                int colw = dgvProdana.Columns[i].Width;
                dgvProdana.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvProdana.Columns[i].Width = colw;
            }
            var result = await _vozila.Get<List<Model.VozilaM>>(null);
            dgvProdana.AutoGenerateColumns = false;
            dgvProdana.DataSource = result;


        }


       

        private void DgvProdana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdana.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvProdana.Rows[e.RowIndex].Cells[0].Value;

                frmDetaljiVozila forma = new frmDetaljiVozila(int.Parse(id.ToString()), null,this);
                forma.Show();
            }
        }
    }
}
