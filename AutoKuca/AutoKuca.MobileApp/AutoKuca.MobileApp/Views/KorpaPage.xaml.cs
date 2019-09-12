using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.ViewModels;
using AutoKuca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKuca.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorpaPage : ContentPage
    {
        private KorpaViewModel model = null;
        public KorpaPage()
        {
            Title = "Sadrzaj korpe";
            InitializeComponent();
            BindingContext = model = new KorpaViewModel(Navigation);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //model.Init();
            if (Global.aktivnaNarudzba != null)
            {
                lista.ItemsSource = Global.aktivnaNarudzba.narudzbaStavke;
                double Ukupno = 0;
                foreach(var x in Global.aktivnaNarudzba.narudzbaStavke)
                {
                    Ukupno += x.Cijena * x.Kolicina;
                }
                ukupno.Text = "Ukupan iznos: " + Math.Round(Ukupno, 2) + " KM";
            }
        }

        private async void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var result = await Application.Current.MainPage.DisplayAlert("Brisanje", "Jeste li sigurni da zelite obrisati odabrani artikal iz korpe ?", "Da", "Ne");
            if (result)
            {
                var dio = e.SelectedItem as NarudzbaStavke;
                var nadjen = Global.aktivnaNarudzba.narudzbaStavke.RemoveAll(x => x.DioId == dio.DioId);
                lista.ItemsSource = null;
                lista.ItemsSource = Global.aktivnaNarudzba.narudzbaStavke;
                double Ukupno = 0;
                foreach (var x in Global.aktivnaNarudzba.narudzbaStavke)
                {
                    Ukupno += x.Cijena * x.Kolicina;
                }
                ukupno.Text = "Ukupan iznos: " + Math.Round(Ukupno, 2) + " KM";
            }
        }
    }
}