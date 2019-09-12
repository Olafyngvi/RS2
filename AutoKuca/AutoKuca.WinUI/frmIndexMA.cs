using AutoKuca.WinUI.Izvještaji;
using AutoKuca.WinUI.Marke;
using AutoKuca.WinUI.Modeli;
using AutoKuca.WinUI.Oprema;
using AutoKuca.WinUI.TipVozila;
using AutoKuca.WinUI.UpitiMA;
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
    public partial class frmIndexMA : Form
    {
        private int childFormNumber = 0;
        private frmModeli _modeli;
        private frmOprema _oprema;
        private frmMarke _marke;
        private frmTipovi _tipovi;
        private frmVozila _vozila;
        private frmProdana _prodana;
        private frmBrojPregleda _brojP;
        private frmUpiti _upiti;



        public frmIndexMA()
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

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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
            frmModeli modeli = new frmModeli();
            frmTipovi tipovi = new frmTipovi();
            frmOprema oprema = new frmOprema();
            frmMarke marke = new frmMarke();
            frmVozila vozila = new frmVozila();
            frmProdana prodana = new frmProdana();
            frmBrojPregleda broj = new frmBrojPregleda();
            frmUpiti upiti = new frmUpiti();
            _modeli = modeli;
            _tipovi = tipovi;
            _oprema = oprema;
            _marke = marke;
            _vozila = vozila;
            _prodana = prodana;
            _brojP = broj;
            _upiti = upiti;
        }
        private void FrmIndexMA_Load(object sender, EventArgs e)
        {
            Alociraj();
        }

        public void PretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            _modeli.MdiParent = this;
            _modeli.WindowState = FormWindowState.Maximized;
            _modeli.Show();
        }

        private void NoviModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelDetalji forma = new frmModelDetalji(null, _modeli);
            forma.Show();
        }

        private void PretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            _marke.MdiParent = this;
            _marke.WindowState = FormWindowState.Maximized;
            _marke.Show();
        }

        private void NovaMarkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarkeDetallji forma = new frmMarkeDetallji(null,_marke);

            forma.Show();
        }

        private void PregledOpremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            _oprema.MdiParent = this;
            _oprema.WindowState = FormWindowState.Maximized;
            _oprema.Show();
        }

        private void NovaOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpremaDetalji forma = new frmOpremaDetalji(null, _oprema);
            forma.Show();
        }

        private void PregledTipovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            _tipovi.MdiParent = this;
            _tipovi.WindowState = FormWindowState.Maximized;
            _tipovi.Show();
        }

        private void NoviTipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetaljiTipova forma = new frmDetaljiTipova(null, _tipovi);
            forma.Show();
        }

     

        private async void ListaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await _vozila.GetVozila();
            await _vozila.LoadCmB();
            _vozila.MdiParent = this;
            _vozila.WindowState = FormWindowState.Maximized;
            _vozila.Show();
        }

        private void NovoVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetaljiVozila frm = new frmDetaljiVozila(null, _vozila,_prodana);
            frm.Show();
        }

      

        private void ProdanaVozilaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _prodana.GetVozila();
            _prodana.MdiParent = this;
            _prodana.WindowState = FormWindowState.Maximized;
            _prodana.Show();
        }

        private void BrojPregledaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _brojP.MdiParent = this;
            _brojP.WindowState = FormWindowState.Maximized;
            _brojP.Show();
        }

        private void NeodgovoreniUpitiToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
