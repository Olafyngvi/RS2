using AutoKuca.Model.Requests;
using AutoKuca.WinUI.Dijelovi;
using AutoKuca.WinUI.Izvještaji;
using AutoKuca.WinUI.Kategorije;
using AutoKuca.WinUI.Klijenti;
using AutoKuca.WinUI.Marke;
using AutoKuca.WinUI.Modeli;
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

namespace AutoKuca.WinUI
{
    public partial class frmDijeloviIndex : Form
    {
        private int childFormNumber = 0;
        private readonly APIService aPIService = new APIService("Kategorija");

        public frmDijeloviIndex()
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

        private void PrikaziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKategorije forma = new frmKategorije();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zelite se odjaviti ?", "Odjava", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                Application.Restart();
            }
        }

        private void DodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaKategorija forma = new frmNovaKategorija(null,new frmKategorije());
            forma.Show();
        }

        private void FrmDijeloviIndex_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = $"Dobro dosao {APIService.username}";
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(46, 116, 174);
        }


        private void PrikaziDijeloveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PrikaziDijeloveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDijelovi forma = new frmDijelovi();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void DodajNoviDioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNoviDio forma = new frmNoviDio(null,null);
            forma.Show();
        }

        private void NarudzbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNarudzbe form = new frmNarudzbe();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void PrikaziMarkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarke form = new frmMarke();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void DodajNovuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMarkeDetallji form = new frmMarkeDetallji();
            form.Show();
        }

        private void PrikaziModeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeli form = new frmModeli();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void DodajNoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelDetalji form = new frmModelDetalji();
            form.Show();
        }

        private void KlijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlijenti forma = new frmKlijenti();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }

        private void ModeliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IzvjestajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDijeloviIzvjestaj forma = new frmDijeloviIzvjestaj();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
    }
}
