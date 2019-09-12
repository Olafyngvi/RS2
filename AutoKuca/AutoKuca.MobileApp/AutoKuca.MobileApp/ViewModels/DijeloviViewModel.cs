using AutoKuca.MobileApp.Models;
using AutoKuca.Model;
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
    public class DijeloviViewModel : BaseViewModel
    {
        private readonly ApiService _dijeloviService = new ApiService("Dio");
        private readonly ApiService _kategorijeService = new ApiService("Kategorija");

        public DijeloviViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<DioKategorija> DijeloviList { get; set; } = new ObservableCollection<DioKategorija>();
        public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();

        Kategorija _selectedKategorija = null;
        public Kategorija SelectedKategorija
        {
            get { return _selectedKategorija; }
            set { SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
                }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (KategorijaList.Count == 0)
            {
                var kategorijeList = await _kategorijeService.Get<List<Kategorija>>(null);
                foreach (var x in kategorijeList)
                {
                    KategorijaList.Add(x);
                }
            }
            
            if(SelectedKategorija != null)
            {
                DioSearchRequest req = new DioSearchRequest
                {
                    KategorijaId = SelectedKategorija.KategorijaId
                };
                await Napuni(req);
            }
            else
            {
                await Napuni(null);
            }
           
        }

        private async Task Napuni(DioSearchRequest req = null)
        {
            var list = await _dijeloviService.Get<IEnumerable<Dio>>(req);

            DijeloviList.Clear();

            foreach (var x in list)
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