using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.Views;
using AutoKuca.Model;
using System.Windows.Input;
using System.Collections.Generic;
using AutoKuca.Model.Requests;

namespace AutoKuca.MobileApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private readonly ApiService _vozila = new ApiService("Vozila");
        private readonly ApiService _dijeloviService = new ApiService("Dio");
        private readonly ApiService _kategorijeService = new ApiService("Kategorija");
        private readonly ApiService _narudzbe = new ApiService("Narudzba");
        private readonly ApiService _detalji = new ApiService("DetaljiNarudzba");

        public ObservableCollection<VozilaM> VozilaList { get; set; } = new ObservableCollection<VozilaM>();
        public ObservableCollection<DioKategorija> DijeloviList { get; set; } = new ObservableCollection<DioKategorija>();
        public ObservableCollection<Item> Vozila { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Auto Kuća 'NER'";
            InitCommand = new Command(async () => await PopuniVozila());

        }


        public ICommand InitCommand { get; set; }

        public async Task PopuniVozila()
        {
            VozilaSearchRequest search = new VozilaSearchRequest
            {
                pocetna = true
            };

            var list = await _vozila.Get<IEnumerable<VozilaM>>(search);

            VozilaList.Clear();
            foreach (var item in list)
            {
                VozilaList.Add(item);
            }
            if (Global.prijavljeniKorisnik != null)
            {
                NarudzbaSearchRequest req = new NarudzbaSearchRequest()
                {
                    KlijentId = Global.prijavljeniKorisnik.KorisnikId
                };
                var narudzbe = await _narudzbe.Get<List<Model.Narudzba>>(req);
                if (narudzbe.Count > 0)
                {
                    DetaljiNarudzbaSearchRequest requ = new DetaljiNarudzbaSearchRequest()
                    {
                        NarudzbaId = narudzbe[0].NarudzbaId
                    };
                    var detalji = await _detalji.Get<List<DetaljiNarudzbe>>(requ);

                    if (detalji.Count > 0)
                    {
                        var dio = await _dijeloviService.GetById<Dio>(detalji[0].DioId);
                        DioSearchRequest request = new DioSearchRequest()
                        {
                            ModelId = dio.ModelId
                        };
                        var lista = await _dijeloviService.Get<List<Dio>>(request);

                        DijeloviList.Clear();

                        if (lista.Count > 3)
                        {
                            for(int i = 0; i < 3; i++)
                            {
                                Kategorija y = await _kategorijeService.GetById<Kategorija>(lista[i].KategorijaId);
                                DioKategorija novi = new DioKategorija
                                {
                                    DioId = lista[i].DioId,
                                    Naziv = lista[i].Naziv,
                                    Cijena = lista[i].Cijena,
                                    Sifra = lista[i].Sifra,
                                    KategorijaId = lista[i].KategorijaId,
                                    ModelId = lista[i].ModelId,
                                    Model = lista[i].Model,
                                    Slika = y.Slika
                                };
                                DijeloviList.Add(novi);
                            }
                        }
                        else
                        {
                            foreach (var x in lista)
                            {
                                Kategorija y = await _kategorijeService.GetById<Kategorija>(x.KategorijaId);
                                DioKategorija novi = new DioKategorija
                                {
                                    DioId = x.DioId,
                                    Naziv = x.Naziv,
                                    Cijena = x.Cijena,
                                    Sifra = x.Sifra,
                                    KategorijaId = x.KategorijaId,
                                    ModelId = x.ModelId,
                                    Model = x.Model,
                                    Slika = y.Slika
                                };
                                DijeloviList.Add(novi);
                            }
                        }
                    }
                }
                else
                {
                    var lista = await _dijeloviService.Get<List<Dio>>(null);

                    DijeloviList.Clear();

                    for (int i = 0; i < 3; i++)
                    {
                        Kategorija y = await _kategorijeService.GetById<Kategorija>(lista[i].KategorijaId);
                        DioKategorija novi = new DioKategorija
                        {
                            DioId = lista[i].DioId,
                            Naziv = lista[i].Naziv,
                            Cijena = lista[i].Cijena,
                            Sifra = lista[i].Sifra,
                            KategorijaId = lista[i].KategorijaId,
                            ModelId = lista[i].ModelId,
                            Model = lista[i].Model,
                            Slika = y.Slika
                        };
                        DijeloviList.Add(novi);
                    }
                }
            }
            else
            {
                var lista = await _dijeloviService.Get<List<Dio>>(null);

                DijeloviList.Clear();

                for (int i = 0; i < 3; i++)
                {
                    Kategorija y = await _kategorijeService.GetById<Kategorija>(lista[i].KategorijaId);
                    DioKategorija novi = new DioKategorija
                    {
                        DioId = lista[i].DioId,
                        Naziv = lista[i].Naziv,
                        Cijena = lista[i].Cijena,
                        Sifra = lista[i].Sifra,
                        KategorijaId = lista[i].KategorijaId,
                        ModelId = lista[i].ModelId,
                        Model = lista[i].Model,
                        Slika = y.Slika
                    };
                    DijeloviList.Add(novi);
                }
            }
        }
    }
}