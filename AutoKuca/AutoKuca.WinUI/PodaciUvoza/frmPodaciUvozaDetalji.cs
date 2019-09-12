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
    public partial class frmPodaciUvozaDetalji : Form
    {

        private int? _id = null;
        private frmPodaciUvoza _parent = null;
        private readonly APIService _podaci = new APIService("PodaciUvoza");
        private readonly APIService _poslovnica = new APIService("Poslovnica");
        private readonly APIService _vozilo = new APIService("Vozila");

        public frmPodaciUvozaDetalji(int? id = null, frmPodaciUvoza parent = null)
        {
            InitializeComponent();
            _id = id;
            _parent = parent;
        }

        private async void FrmPodaciUvozaDetalji_Load(object sender, EventArgs e)
        {
            await Popuni();
        }

        private async Task Popuni()
        {
            var podaci = await _podaci.GetById<Model.PodaciUvoza>(_id);
            var poslovnice = await _poslovnica.GetById<List<Model.Poslovnice>>(null);
            var vozila = await _vozilo.GetById<List<Model.VozilaM>>(null);

            txtDatum.Value = podaci.DatumUvoza;

            poslovnice.Insert(0, new Model.Poslovnice {
                PoslovnicaId=podaci.PoslovnicaId,
                Naziv=podaci.Poslovnica
            });

            cmbPoslovnica.DataSource = poslovnice;
            cmbPoslovnica.ValueMember = "PoslovnicaId";
            cmbPoslovnica.DisplayMember = "Naziv";

            vozila.Insert(0, new Model.VozilaM {
                VoziloId = podaci.VoziloId,
                SifraAutomobila=podaci.Sifra
            });

            cmbSifra.DataSource = vozila;
            cmbSifra.DisplayMember = "SifraAutomobila";
            cmbSifra.ValueMember = "VoziloId";
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            if(cmbPoslovnica.SelectedIndex==0 || cmbSifra.SelectedIndex == 0)
            {
                errorProvider1.SetError(cmbSifra, "Obavezno polje !");
                errorProvider1.SetError(cmbPoslovnica, "Obavezno polje !");
            }
            else
            {
                errorProvider1.SetError(cmbPoslovnica, null);
                errorProvider1.SetError(cmbSifra, null);
                PodaciUvozaUpsertRequest model = new PodaciUvozaUpsertRequest();

                model.DatumUvoza = txtDatum.Value;

                var idobj = cmbPoslovnica.SelectedValue;

                if(int.TryParse(idobj.ToString(),out int id)){

                    model.PoslovnicaId = id;
                }
                var idobj2 = cmbSifra.SelectedValue;

                if (int.TryParse(idobj2.ToString(), out int id2))
                {

                    model.VoziloId = id2;
                }


                var nesto=await _podaci.Update<Model.PodaciUvoza>(_id,model);
                if (nesto != default(Model.PodaciUvoza))
                {
                    await _parent.GetPodaci();
                    MessageBox.Show("Podaci uspješno promjenjeni!");
                }
                Close();
            }
            
        }
    }
}
