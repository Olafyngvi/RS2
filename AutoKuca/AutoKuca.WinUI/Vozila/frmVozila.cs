using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using Newtonsoft.Json;

namespace AutoKuca.WinUI.Vozila
{
    public partial class frmVozila : Form
    {

        private readonly APIService _vozila=new APIService("Vozila");
        private readonly APIService _tip = new APIService("TipVozila");
        private readonly APIService _marka = new APIService("Marka");
        private readonly APIService _trans = new APIService("Transmisija");
        private int? _tipTrenutno = null;
        private int? _markaTrenutno = null;
        private int? _transTrenutno = null;
        public frmVozila()
        {
            InitializeComponent();
        }



        public  async Task GetVozila()
        {
            dgvVozila.BackgroundColor = Color.White;
            dgvVozila.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVozila.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvVozila.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvVozila.Columns.Count - 1; i++)
            {
                int colw = dgvVozila.Columns[i].Width;
                dgvVozila.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvVozila.Columns[i].Width = colw;
            }
            var result = await _vozila.Get<List<Model.VozilaM>>(null);
            dgvVozila.AutoGenerateColumns = false;        
            dgvVozila.DataSource = result;

        }

        public async Task LoadCmB()
        {
            var marke = await _marka.Get<List<Model.Marke>>(null);
            var trans = await _trans.Get<List<Model.Transmisija>>(null);
            var tip = await _tip.Get<List<Model.TipoviVozila>>(null);


            List<Sort> lista = new List<Sort>();

            lista.Add(new Sort {
                ID = 0,
                Naziv="Sortiraj"
                
            });
            lista.Add(new Sort
            {
                ID = 1,
                Naziv = "Marka"

            });
            lista.Add(new Sort
            {
                ID = 2,
                Naziv = "Cijena"

            });

            cmbSort.DataSource = lista;
            cmbSort.DisplayMember = "Naziv";
            cmbSort.ValueMember = "ID";

            marke.Insert(0, new Model.Marke {
                MarkaId = 0,
                Naziv="Marka"
                
            });
            cmbMarke.DataSource = marke;
            cmbMarke.DisplayMember = "Naziv";
            cmbMarke.ValueMember = "MarkaId";

            trans.Insert(0,new Model.Transmisija
            {
                TransmisijaId = 0,
                Naziv="Transmisija"
                
            });
            cmbTransmisija.DataSource = trans;
            cmbTransmisija.DisplayMember = "Naziv";
            cmbTransmisija.ValueMember = "TransmisijaId";

            tip.Insert(0, new Model.TipoviVozila {
                    TipVozilaId=0,
                    Naziv="Tip vozila"
            });
            cmbTipVozila.DataSource = tip;
            cmbTipVozila.DisplayMember = "Naziv";
            cmbTipVozila.ValueMember = "TipVozilaId";


        }

        private async void DgvVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVozila.Columns[e.ColumnIndex].Name == "Detalji")
            {
                var id = dgvVozila.Rows[e.RowIndex].Cells[0].Value;

                frmDetaljiVozila forma = new frmDetaljiVozila(int.Parse(id.ToString()), this);
                forma.Show();
            }

            else if (dgvVozila.Columns[e.ColumnIndex].Name == "Arhiviraj")
            {
                var id = dgvVozila.Rows[e.RowIndex].Cells[0].Value;

                if (MessageBox.Show("Da li ste sigurni da želite arhivirati podatke o ovom vozilu?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _vozila.Delete(id);
                    await GetVozila();
                    MessageBox.Show("Zapis uspješno arhiviran");
                }
            }
        }

        private async void CmbMarke_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbMarke.SelectedValue;

            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadAutaMarka(id);
            }
        }

        private async Task LoadAutaMarka(int id)
        {
            VozilaSearchRequest req = new VozilaSearchRequest();
            if (_transTrenutno != null && _tipTrenutno!=null)
            {
                req.TransmisijaId = _transTrenutno ?? default(int);
                req.TipVozilaId = _tipTrenutno ?? default(int);

                req.MarkaId = id;
            }
            else
            {
                req.MarkaId = id;
            }
            _markaTrenutno = id;
            var result = await _vozila.Get<List<Model.VozilaM>>(req);
            dgvVozila.DataSource = result;


        }

        private async void CmbTransmisija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbTransmisija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadTransAuta(id);
            }
        }

        private async Task LoadTransAuta(int id)
        {
            VozilaSearchRequest req = new VozilaSearchRequest();

            if (_markaTrenutno != null && _tipTrenutno != null)
            {
                req.MarkaId = _markaTrenutno ?? default(int);
                req.TipVozilaId = _tipTrenutno ?? default(int);

                req.TransmisijaId = id;
            }
            else
            {
                req.TransmisijaId = id;
            }
            _transTrenutno = id;
            var result = await _vozila.Get<List<Model.VozilaM>>(req);
            dgvVozila.DataSource = result;
          
            
        }

        private async void CmbTipVozila_SelectedIndexChanged(object sender, EventArgs e)
        {
          var  idObj=cmbTipVozila.SelectedValue;

            if(int.TryParse(idObj.ToString(),out int id))
            {
                await LoadTipoviAuta(id);
            }
        }

        private async Task LoadTipoviAuta(int id)
        {
            VozilaSearchRequest req = new VozilaSearchRequest();

            if (_markaTrenutno != null && _transTrenutno != null)
            {
                req.MarkaId = _markaTrenutno ?? default(int);
                req.TransmisijaId = _transTrenutno ?? default(int);

                req.TipVozilaId = id;
            }
            else
            {
                req.TipVozilaId = id;
            }
            _tipTrenutno = id;
            var result = await _vozila.Get<List<Model.VozilaM>>(req);
            dgvVozila.DataSource = result;

        }

        private async void BtnPretraga_Click(object sender, EventArgs e)
        {
            var godina = txtGodina.Text;
            await PretražiGodinu(godina);
        }

        private async Task PretražiGodinu(string godina)
        {
           
            if(int.TryParse(godina,out int godinaInt))
            {
                var result = await _vozila.Get<List<Model.VozilaM>>(new VozilaSearchRequest
                {
                    Godina = godinaInt
                });
                dgvVozila.DataSource = result;
            }
        }

        private async void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbSort.SelectedValue;
           
            if(int.TryParse(idObj.ToString(),out int id))
            {
                await Sort(id);
            }

        }

        private async Task Sort(int id)
        {
            var result = await _vozila.Get<List<Model.VozilaM>>(new VozilaSearchRequest {
                Sortiraj = id
            });

            dgvVozila.DataSource = result;
            
        }

     
    }
}
