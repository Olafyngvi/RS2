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

namespace AutoKuca.WinUI.Izvještaji
{
    public partial class frmDijeloviIzvjestaj : Form
    {
        private readonly APIService _dijelovi = new APIService("Dio");
        private readonly APIService _narudzbe = new APIService("Narudzba");
        private readonly APIService _detalji = new APIService("DetaljiNarudzba");
        public frmDijeloviIzvjestaj()
        {
            InitializeComponent();
        }

        private async void FrmDijeloviIzvjestaj_Load(object sender, EventArgs e)
        {
            double ukupno = 0;
            double ukupnoTrenutniMjesec = 0;
            NarudzbaSearchRequest requ = new NarudzbaSearchRequest()
            {
                Zavrsena = true
            };
            var narudzbe = await _narudzbe.Get<List<Narudzba>>(requ);
            foreach(var x in narudzbe)
            {
                DetaljiNarudzbaSearchRequest req = new DetaljiNarudzbaSearchRequest()
                {
                    NarudzbaId = x.NarudzbaId
                };
                var detalji = await _detalji.Get<List<Model.DetaljiNarudzbe>>(req);
                foreach(var y in detalji)
                {
                    ukupno += y.Cijena * y.Kolicina;
                    if (x.DatumNarudžbe.Month == DateTime.Now.Month)
                    {
                        ukupnoTrenutniMjesec += y.Cijena * y.Kolicina;
                    }
                }
            }
            int dioBroj = 0;
            var dijelovi = await _dijelovi.Get<List<Dio>>(null);
            List < DioIzvjestaj > lista = new List<DioIzvjestaj>();
            foreach(var x in dijelovi)
            {
                DetaljiNarudzbaSearchRequest req = new DetaljiNarudzbaSearchRequest()
                {
                    DioId = x.DioId
                };
                var stavke = await _detalji.Get<List<Model.DetaljiNarudzbe>>(req);
                if (stavke.Count > 0)
                {
                    DioIzvjestaj diodio = new DioIzvjestaj()
                    {
                        Naziv = x.Naziv,
                        Cijena = x.Cijena,
                        Sifra = x.Sifra,
                        Model = x.Model,
                    };
                    var list= stavke.Where(g => g.DioId == x.DioId).Select(w => w.Kolicina);
                    foreach(var t in list)
                    {
                        dioBroj += t;
                    }
                    diodio.BrojProdanih = dioBroj;
                    lista.Add(diodio);
                    dioBroj = 0;
                }
            }
            List<DioIzvjestaj> sortirana = lista.OrderByDescending(x => x.BrojProdanih).ToList();
            dgvDijelovi.BackgroundColor = Color.White;
            dgvDijelovi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDijelovi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDijelovi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvDijelovi.Columns.Count - 1; i++)
            {
                int colw = dgvDijelovi.Columns[i].Width;
                dgvDijelovi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvDijelovi.Columns[i].Width = colw;
            }
            dgvDijelovi.DataSource = sortirana;

            dgvNarudzbe.BackgroundColor = Color.White;
            dgvNarudzbe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNarudzbe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvNarudzbe.Columns.Count - 1; i++)
            {
                int colw = dgvNarudzbe.Columns[i].Width;
                dgvNarudzbe.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvNarudzbe.Columns[i].Width = colw;
            }
            dgvNarudzbe.DataSource = narudzbe;
            txtUkupno.Text = $"Ukupna zarada : \t{ukupno} KM";
            txtUkupnoTrenutni.Text = $"Ukupna zarada tekuci mjesec: {ukupnoTrenutniMjesec} KM";
        }
    }
}
