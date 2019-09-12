using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKuca.WinUI.UpitiMA
{
    public partial class frmDetaljiUpita : Form
    {

        private int? _id = null;
        private readonly APIService _upiti = new APIService("UpitiVozila");
        private frmUpiti _parent;
        public frmDetaljiUpita(frmUpiti frm ,int? id=null)
        {

            InitializeComponent();
            _id = id;
            _parent = frm;
        }

        private async void FrmDetaljiUpita_Load(object sender, EventArgs e)
        {
            await LoadPodataka();
        }

        private async Task LoadPodataka()
        {
            var upit = await _upiti.GetById<Model.UpitiVozila>(_id);
            txtDatum.Text = upit.DatumVrijeme.ToString();
            txtEmail.Text = upit.Email;
            txtIme.Text = upit.ImePrezime;
            txtSifra.Text = upit.SifraAutomobila;
            txtPoruka.Text = upit.Poruka;
            var myTextBoxes = this.Controls.OfType<TextBox>();
            foreach (var item in myTextBoxes)
            {
                item.ReadOnly = true;
            }
            txtPoruka.ReadOnly = true;

        }

        private  async void BtnSend_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOdgovor.Text) )
            {
                errorProvider1.SetError(txtOdgovor, "Obavezno polje !");
                MessageBox.Show("Unesite tražena polja!");

            }
            else { 
            var odgovor = txtOdgovor.Text;
            var email = txtEmail.Text;
             PošaljiEmail(odgovor, email);

            MessageBox.Show("Odgovor uspiješno poslan!");
            await _upiti.Delete(_id);
            await _parent.LoadUpiti();
            this.Close();
            }

        }

        private   void PošaljiEmail(string odgovor, string email)
        {
          
            string adresa1 = "menadzerprodajeNER@gmail.com";


            var fromAddress = new MailAddress(adresa1, "Auto-Kuća NER");
            var toAddress = new MailAddress(email, "Poštovani");
            const string fromPassword = "kamin123kamin!";
            const string subject = "AutoKucaNER-UPIT";
            string body = "Poštovani, \n" + odgovor + "\nLijep pozdrav, NER Team";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };

             smtp.Send(message);
        }
        
    }
}
