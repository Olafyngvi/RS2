using AutoKuca.Model.Requests;
using AutoKuca.WinUI.DetaljiNarudzbe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        private readonly APIService _klijenti = new APIService("Klijent");
        private readonly APIService _narudzbe = new APIService("Narudzba");
        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void FrmKlijenti_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            groupBox2.Hide();
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                int colw = dataGridView1.Columns[i].Width;
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[i].Width = colw;
            }
            await KlijentiLoad();
        }

        private async Task KlijentiLoad()
        {
            var result = await _klijenti.Get<List<Model.Klijenti>>(null);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = result;
        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            KlijentSearchRequest req = new KlijentSearchRequest();
            req.Param = txtPretraga.Text;
            var result = await _klijenti.Get<List<Model.Klijenti>>(req);
            dataGridView1.DataSource = result;
        }

        private async void BtnX_Click(object sender, EventArgs e)
        {
            txtPretraga.Text = string.Empty;
            await KlijentiLoad();
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objId = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Narudzbe")
            {
                NarudzbaSearchRequest req = new NarudzbaSearchRequest
                {
                    KlijentId = int.Parse(objId.ToString())
                };
                dataGridView2.BackgroundColor = Color.White;
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i <= dataGridView2.Columns.Count - 1; i++)
                {
                    int colw = dataGridView2.Columns[i].Width;
                    dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView2.Columns[i].Width = colw;
                }
                var result = await _narudzbe.Get<List<Model.Narudzba>>(req);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = result;
                groupBox2.Show();
                dataGridView2.Show();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var objId = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Detalji")
            {
                frmNarudzbeDetalji form = new frmNarudzbeDetalji(int.Parse(objId.ToString()));
                form.Show();
            }
        }
    }
}
