using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.Views;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoKuca.MobileApp.ViewModels
{
    public class KorpaViewModel : BaseViewModel
    {
        private readonly ApiService _narudzbe = new ApiService("Narudzba");
        private readonly ApiService _detalji = new ApiService("DetaljiNarudzba");
        public INavigation Navigation { get; set; }
        public KorpaViewModel(INavigation navigation)
        {
            Navigation = navigation;
            InitCommand = new Command(() => Init());
            ButtonCommand = new Command(() => Zavrsi());
        }
        public KorpaViewModel()
        {
            InitCommand = new Command(() => Init());
            ButtonCommand = new Command(() => Zavrsi());
        }

        public ObservableCollection<NarudzbaStavke> StavkeList { get; set; } = new ObservableCollection<NarudzbaStavke>();
        public ICommand InitCommand { get; set; }
        public ICommand ButtonCommand { private set; get; }
        double _ukupno = 0;
        public double Ukupno
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

        public void Init()
        {
            
        }
        public async void Zavrsi()
        {
            if (Global.aktivnaNarudzba == null)
            {
                await Application.Current.MainPage.DisplayAlert("", "Vasa korpa je prazna.", "Ok");
                await this.Navigation.PushAsync(new DijeloviPage());
                return;
            }
            var answer = await Application.Current.MainPage.DisplayAlert("Zavrsi narudzbu", "Da li zelite da zavrsite narudzbu ?", "Da", "Ne");
            if (answer)
            {
                NarudzbaUpsertRequest req = new NarudzbaUpsertRequest()
                {
                    DatumNarudžbe = Global.aktivnaNarudzba.DatumNarudžbe,
                    Zavrsena = false,
                    KlijentId = Global.prijavljeniKorisnik.KorisnikId
                };
                var nar = await _narudzbe.Insert<NarudzbaUpsertRequest>(req);
                foreach(var x in Global.aktivnaNarudzba.narudzbaStavke)
                {
                    DetaljiNarudzbeUpsertRequest request = new DetaljiNarudzbeUpsertRequest()
                    {
                        Kolicina = x.Kolicina,
                        Cijena = x.Cijena,
                        NarudzbaId = nar.NarudzbaId,
                        DioId = x.DioId
                    };
                    await _detalji.Insert<DetaljiNarudzbeUpsertRequest>(request);
                }
                await Application.Current.MainPage.DisplayAlert("Narudzba napravljena", "Narudzba uspjesno napravljena .", "Ok");
                Global.aktivnaNarudzba = null;
                await this.Navigation.PopToRootAsync();
                await this.Navigation.PushAsync(new DijeloviPage());
            }
        }
    }
}
