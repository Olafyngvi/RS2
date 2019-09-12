using AutoKuca.Model.Requests;
using AutoKuca.WinUI.Narudzbe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.DetaljiNarudzbe
{
    public partial class frmNarudzbeDetalji : Form
    {
        private readonly APIService _detalji = new APIService("DetaljiNarudzba");
        private readonly APIService _klijent = new APIService("Klijent");
        private readonly APIService _narudzba = new APIService("Narudzba");
        private readonly APIService _korisnik = new APIService("Korisnik");
        private int _id { get; set; }
        private frmNarudzbe _parent = null;
        public frmNarudzbeDetalji(int id,frmNarudzbe parent = null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            PripremiDgv();
            DetaljiNarudzbaSearchRequest req = new DetaljiNarudzbaSearchRequest
            {
                NarudzbaId = _id
            };
            var result = await _detalji.Get<List<Model.DetaljiNarudzbe>>(req);
            dgvDetalji.AutoGenerateColumns = false;
            dgvDetalji.DataSource = result;
            var narudzba = await _narudzba.GetById<Model.Narudzba>(_id);
            if (narudzba.Zavrsena == true)
            {
                btnZavrsi.Hide();
            }
            var klijent = await _klijent.GetById<Model.Klijenti>(narudzba.KlijentId);
            txtIme.Text = $"{klijent.Ime} {klijent.Prezime}";
            txtKorisnicko.Text = klijent.KorisnickoIme;
            txtAdresa.Text = klijent.Adresa;
            txtGrad.Text = klijent.Grad;
            txtBrojTelefona.Text = klijent.Telefon;
            txtDatum.Text = narudzba.DatumNarudžbe.ToString();
            double ukupno = 0;
            foreach (var x in result)
            {
                ukupno += x.Cijena * x.Kolicina;
            }
            txtUkupno.Text = ukupno.ToString();
        }

        private void PripremiDgv()
        {
            dgvDetalji.BackgroundColor = Color.White;
            dgvDetalji.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDetalji.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDetalji.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= dgvDetalji.Columns.Count - 1; i++)
            {
                int colw = dgvDetalji.Columns[i].Width;
                dgvDetalji.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvDetalji.Columns[i].Width = colw;
            }
        }

        private async void BtnZavrsi_Click(object sender, EventArgs e)
        {
            NarudzbaUpsertRequest req = new NarudzbaUpsertRequest
            {
                NarudzbaId = _id,
                Zavrsena = true
            };
            await _narudzba.Update<NarudzbaUpsertRequest>(_id, req);
            var narudzba = await _narudzba.GetById<Model.Narudzba>(_id);
            var klijent = await _klijent.GetById<Model.Klijenti>(narudzba.KlijentId);
            MessageBox.Show("Narudzba uspjesno zavrsena", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await _klijent.Delete(klijent.KorisnikId);
            NarudzbaSearchRequest reload = new NarudzbaSearchRequest { Zavrsena = false };
            await _parent.LoadNarudzbe(reload);
            Close();
        }

        private void BtnZatvori_Click(object sender, EventArgs e)
        {
        }
    }
}
