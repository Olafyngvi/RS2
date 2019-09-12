using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.Poslovnice
{
    public partial class frmPoslovnice : Form
    {

        private readonly APIService _poslovnice = new APIService("Poslovnica");
        public frmPoslovnice()
        {
            InitializeComponent();
        }

        private async void FrmPoslovnice_Load(object sender, EventArgs e)
        {
            await GetPoslovnice();
        }

        public async Task GetPoslovnice()
        {
            var result = await _poslovnice.Get<List<Model.Poslovnice>>(null);

            dgvPoslovnice.AutoGenerateColumns = false;
            dgvPoslovnice.DataSource = result;
        }

        private async void DgvPoslovnice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPoslovnice.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvPoslovnice.Rows[e.RowIndex].Cells[0].Value;

                frmPoslovnicaDetalji forma = new frmPoslovnicaDetalji(int.Parse(id.ToString()), this);
                forma.Show();
            }

            else if (dgvPoslovnice.Columns[e.ColumnIndex].Name == "Zatvori")
            {
                var id = dgvPoslovnice.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite zatvoriti ovu poslovnicu?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _poslovnice.Delete(id);
                    await GetPoslovnice();
                    MessageBox.Show("Status poslovnice promijenjen");
                }
            }
        }
    }
}
