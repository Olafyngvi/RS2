using AutoKuca.WinUI.Gradovi;
using AutoKuca.WinUI.Izvještaji;
using AutoKuca.WinUI.PodaciUvoza;
using AutoKuca.WinUI.Poslovnice;
using AutoKuca.WinUI.UpitiAdmin;
using AutoKuca.WinUI.Uposlenici;
using AutoKuca.WinUI.Vozila;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI
{
    public partial class frmAdminIndex : Form
    {
        private int childFormNumber = 0;

        private frmUposlenici _uposlenici;
        private frmGradovi _gradovi;
        private frmPoslovnice _poslovnice;
        private frmPodaciUvoza _podaci;
        private frmUpiti _upiti;
        private frmProdana _prodana;
        private frmBrojPregleda _brojP;


        public frmAdminIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

  

     

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Alociraj()
        {
            frmUposlenici uposlenici = new frmUposlenici();
            frmGradovi gradovi = new frmGradovi();
            frmPoslovnice poslovnice = new frmPoslovnice();
            frmPodaciUvoza podaci = new frmPodaciUvoza();
            frmUpiti upiti = new frmUpiti();
            frmBrojPregleda broj = new frmBrojPregleda();
            frmProdana prodana = new frmProdana();
            _uposlenici = uposlenici;
            _gradovi = gradovi;
            _poslovnice = poslovnice;
            _podaci = podaci;
            _upiti = upiti;
            _prodana = prodana;
            _brojP = broj;
        }

        private void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _uposlenici.MdiParent = this;
            _uposlenici.WindowState = FormWindowState.Maximized;
            _uposlenici.Show();
        }

        private void FrmAdminIndex_Load(object sender, EventArgs e)
        {
            Alociraj();
        }

        private void NoviUposlenikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUposleniciDetalji forma = new frmUposleniciDetalji(null, _uposlenici);
            forma.Show();
        }

        private void ListaGradovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _gradovi.MdiParent = this;
            _gradovi.WindowState = FormWindowState.Maximized;
            _gradovi.Show();
        }

        private void NoviGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradoviDetalji frm = new frmGradoviDetalji(null, _gradovi);
            frm.Show();
        }

        private void ListaRadionicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _poslovnice.MdiParent = this;
            _poslovnice.WindowState = FormWindowState.Maximized;
            _poslovnice.Show();
        }

        private void NovaRadionicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoslovnicaDetalji frm = new frmPoslovnicaDetalji(null, _poslovnice);
            frm.Show();
        }

        private void ListaPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _podaci.MdiParent = this;
            _podaci.WindowState = FormWindowState.Maximized;
            _podaci.Show();
        }

        private void ListaUpitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upiti.MdiParent = this;
            _upiti.WindowState = FormWindowState.Maximized;
            _upiti.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zelite se odjaviti ?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                Application.Restart();
            }
        }

        private void VozilabrojPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _brojP.MdiParent = this;
            _brojP.WindowState = FormWindowState.Maximized;
            _brojP.Show();
        }

        private void ProdanaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _prodana.GetVozila();
            _prodana.MdiParent = this;
            _prodana.WindowState = FormWindowState.Maximized;
            _prodana.Show();
        }

        private void DijeloviINarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijeloviIzvjestaj forma = new frmDijeloviIzvjestaj();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
    }
}
