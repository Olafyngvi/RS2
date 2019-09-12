using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoKuca.MobileApp.ViewModels
{
    public class KontaktVM:BaseViewModel
    {
        private ApiService _upit = new ApiService("AdminUpiti");
        private ApiService _pos = new ApiService("Poslovnica");


        string _imeprezime = string.Empty;
        string _email = string.Empty;
        string _poruka = string.Empty;

        string _imeError = string.Empty;
        string _emailError = string.Empty;
        string _porukaError = string.Empty;

        bool _visibleIme = false;
        bool _visibleEmail = false;
        bool _visiblePoruka = false;





        public KontaktVM()
        {
            Title = "Kontakt";
      
            Send = new Command(async () => await SendUpit());
        }

        public string ImePrezime
        {
            get { return _imeprezime; }
            set { SetProperty(ref _imeprezime, value); }
        }
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        public string Poruka
        {
            get { return _poruka; }
            set
            {
                SetProperty(ref _poruka, value);
            }
        }

        public string ImeError
        {
            get { return _imeError; }
            set
            { SetProperty(ref _imeError, value); }
        }
        public string EmailError
        {
            get { return _emailError; }
            set
            { SetProperty(ref _emailError, value); }
        }
        public string PorukaError
        {
            get { return _porukaError; }
            set
            { SetProperty(ref _porukaError, value); }
        }

        public bool VisibleIme
        {
            get { return _visibleIme; }
            set
            { SetProperty(ref _visibleIme, value); }
        }
        public bool VisibleEmail
        {
            get { return _visibleEmail; }
            set
            { SetProperty(ref _visibleEmail, value); }
        }
        public bool VisiblePoruka
        {
            get { return _visiblePoruka; }
            set
            { SetProperty(ref _visiblePoruka, value); }
        }

        public ICommand Send { get; set; }

        public ObservableCollection<Poslovnice> poslovniceList { get; set; } = new ObservableCollection<Poslovnice>();

        public async Task PopuniPoslovnice()
        {
            var list = await _pos.Get<IEnumerable<Poslovnice>>(null);

            poslovniceList.Clear();
            foreach (var item in list)
            {
                poslovniceList.Add(item);
            }
        }

        private async Task SendUpit()
        {
            if (Validacija())
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite tražena polja!", "OK");

            }
            else
            {
                IsBusy = true;
                UpitiVozilaUpsertRequest model = new UpitiVozilaUpsertRequest();
                model.ImePrezime = ImePrezime;
                model.Pregledano = false;
                model.Email = Email;
                model.Poruka = Poruka;
                model.DatumVrijeme = DateTime.Now;

                try
                {
                    await _upit.Insert<UpitiAdmin>(model);

                    await Application.Current.MainPage.DisplayAlert("Poruka", "Hvala na kontaktiranju, naš tim će se potruditi da što prije odgovori na Vaš upit.Lijep pozdrav!", "OK");
                    ImePrezime = string.Empty;
                    Email = string.Empty;
                    Poruka = string.Empty;

                }
                catch (Exception)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Dogodila se pogreška!", "OK");
                    throw;
                }
            }
        }

        private bool Validacija()
        {
            if (ImePrezime == string.Empty)
            {
                ImeError = "Unos imena i prezime je obavezno!";
                VisibleIme = true;
                VisibleEmail = false;
                VisiblePoruka = false;

                return true;
            }
            else if (ImePrezime.Any(char.IsDigit))
            {
                ImeError = "Ime i prezime ne mogu sadržavati brojeve!";
                VisibleIme = true;
                VisibleEmail = false;
                VisiblePoruka = false;

                return true;
            }
            else if (ImePrezime.Length < 7)
            {
                ImeError = "Ime i prezime mora sadžavati minimalno 7 karaktera!";
                VisibleIme = true;
                VisibleEmail = false;
                VisiblePoruka = false;

                return true;
            }
            else if (Email == string.Empty)
            {
                EmailError = "Email je obavezan!";
                VisibleIme = false;
                VisibleEmail = true;
                VisiblePoruka = false;
                return true;
            }
            else if (validateEmail(Email))
            {
                EmailError = "Unesite ispravan format email-a!";
                VisibleIme = false;
                VisibleEmail = true;
                VisiblePoruka = false;
                return true;
            }
            else if (Poruka == string.Empty)
            {
                PorukaError = "Poruka je obavezna!";
                VisibleIme = false;
                VisibleEmail = false;
                VisiblePoruka = true;
                return true;
            }
            else if (Poruka.Length < 10)
            {
                PorukaError = "Poruka mora sadržavati minimalno 10 karaktera!";
                VisibleIme = false;
                VisibleEmail = false;
                VisiblePoruka = true;
                return true;
            }
            else
            {
                VisiblePoruka = false;
                return false;

            }
        }


        private bool validateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return false;
            }
            catch (FormatException)
            {

                return true;
            }

        }

    }
}
