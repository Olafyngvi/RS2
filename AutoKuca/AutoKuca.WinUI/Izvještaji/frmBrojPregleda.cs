using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Izvještaji
{
    public partial class frmBrojPregleda : Form
    {

        private readonly APIService _vozila = new APIService("Vozila");
        public frmBrojPregleda()
        {
            InitializeComponent();
        }

        private async void FrmBrojPregleda_Load(object sender, EventArgs e)
        {
            await GetPodatci();
        }

        private async Task GetPodatci()
        {
            var result = await _vozila.Get<List<Model.VozilaM>>(null);
            var broj = 0;
            foreach (var item in result)
            {
                broj += item.BrojPregleda;
            }
            lblBroj.Text = broj.ToString();
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = result;
        }
    }
}
