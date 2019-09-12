using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoKuca.WinUI
{
    public partial class frmLogin : Form
    {
        private APIService aPI = new APIService("Uposlenik");

        public int? _id=null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.username = txtKorIme.Text;
                APIService.pass = txtPass.Text;



                var result = await aPI.Get<List<Model.Uposlenici>>(null);

                foreach (var item in result)
                {
                    if (item.KorisnickoIme == txtKorIme.Text)
                    {
                        if (item.VrstaUposlenikaId == 1)
                        {
                            _id = 1;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                        else if (item.VrstaUposlenikaId == 3)

                        {
                            _id = 3;
                            this.DialogResult = DialogResult.OK;
                            break;                        
                        }
                        else if (item.VrstaUposlenikaId == 2)
                        {
                            _id = 2;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                        else
                        {
                            _id = 2;
                            this.DialogResult = DialogResult.OK;
                            break;
                        }
                    }
                }
                if(_id==null)
                MessageBox.Show("Neispravan unos korisničkog imena ili lozinke!", "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
          
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxtKorIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorIme.Text))
            {
                errorProvider1.SetError(txtKorIme, "Obavezno polje !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorIme, null);
            }
        }

        private void TxtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Obavezno polje !");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPass,null);
            }
        }
    }
}
