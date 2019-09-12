using AutoKuca.MobileApp.Models;
using eProdaja.Mobile.ViewModels;
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
    public partial class DioDetaljiPage : ContentPage
    {
        DioDetaljiViewModel viewModel = null;

        public DioDetaljiPage(DioKategorija dio)
        {
            Title = "Dio";
            InitializeComponent();
            BindingContext = viewModel = new DioDetaljiViewModel()
            {
                Dio = dio
            };
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Global.prijavljeniKorisnik == null)
            {
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                if (Global.aktivnaNarudzba == null)
                {
                    Global.aktivnaNarudzba = new Narudzba()
                    {
                        DatumNarudžbe = DateTime.Now.Date,
                        KlijentId = Global.prijavljeniKorisnik.KorisnikId
                    };
                    bool pronadjen = false;
                    foreach (var x in Global.aktivnaNarudzba.narudzbaStavke)
                    {
                        if (viewModel.Dio.DioId == x.DioId)
                        {
                            x.Kolicina += int.Parse(viewModel.Kolicina.ToString());
                            pronadjen = true;
                            await DisplayAlert("Uspjeh", "Uspjesno ste izmijenili kolicinu proizvoda u korpi.", "ok");

                            break;
                        }
                    }
                    if (!pronadjen)
                    {
                        NarudzbaStavke stavka = new NarudzbaStavke()
                        {
                            Model = viewModel.Dio.Model,
                            Slika = viewModel.Dio.Slika,
                            Dio = viewModel.Dio.Naziv,
                            DioId = viewModel.Dio.DioId,
                            Kolicina = int.Parse(viewModel.Kolicina.ToString()),
                            Cijena = viewModel.Dio.Cijena
                        };
                        Global.aktivnaNarudzba.narudzbaStavke.Add(stavka);

                        await DisplayAlert("Uspjeh", "Uspjesno ste dodali proizvod u korpu.", "ok");
                        this.Navigation.PushAsync(new DijeloviPage());
                        this.Navigation.RemovePage(this);
                    }
                    else
                    {
                        this.Navigation.PushAsync(new DijeloviPage());
                        this.Navigation.RemovePage(this);
                    }
                }
                else
                {
                    bool pronadjen = false;
                    foreach (var x in Global.aktivnaNarudzba.narudzbaStavke)
                    {
                        if (viewModel.Dio.DioId == x.DioId)
                        {
                            x.Kolicina += int.Parse(viewModel.Kolicina.ToString());
                            pronadjen = true;
                            await DisplayAlert("Uspjeh", "Uspjesno ste izmijenili kolicinu proizvoda u korpi.", "ok");
                            this.Navigation.PushAsync(new DijeloviPage());
                            this.Navigation.RemovePage(this);
                            break;
                        }
                    }
                    if (!pronadjen)
                    {
                        NarudzbaStavke stavka = new NarudzbaStavke()
                        {
                            Model = viewModel.Dio.Model,
                            Slika = viewModel.Dio.Slika,
                            Dio = viewModel.Dio.Naziv,
                            DioId = viewModel.Dio.DioId,
                            Kolicina = int.Parse(viewModel.Kolicina.ToString()),
                            Cijena = viewModel.Dio.Cijena
                        };
                        Global.aktivnaNarudzba.narudzbaStavke.Add(stavka);

                        await DisplayAlert("Uspjeh", "Uspjesno ste dodali proizvod u korpu.", "ok");
                        this.Navigation.PushAsync(new DijeloviPage());
                        this.Navigation.RemovePage(this);
                    }
                    else
                    {
                        this.Navigation.PushAsync(new DijeloviPage());
                        this.Navigation.RemovePage(this);
                    }
                }
            }
        }
    }
}