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
   public class KatalogVozilaVM :BaseViewModel
    {
        private readonly ApiService _vozila = new ApiService("Vozila");
        private readonly ApiService _marke = new ApiService("Marka");
        private readonly ApiService _tipVozila = new ApiService("TipVozila");
        private readonly ApiService _transmisija = new ApiService("Transmisija");

        Marke markaSearch = null;
        Transmisija transSearch = null;
        TipoviVozila tipSearch = null;


        public KatalogVozilaVM()
        {
            Title = "Katalog vozila";
            InitCommand = new Command(async () => await PopuniVozila());
        }

        public ObservableCollection<VozilaM> VozilaList { get; set; } = new ObservableCollection<VozilaM>();
        public ObservableCollection<Marke> Marke { get; set; } = new ObservableCollection<Marke>();
        public ObservableCollection<TipoviVozila> Tipovi { get; set; } = new ObservableCollection<TipoviVozila>();
        public ObservableCollection<Transmisija> Transmisija { get; set; } = new ObservableCollection<Transmisija>();

        public Marke MarkaSearch
        {
            get { return markaSearch; }
            set { SetProperty(ref markaSearch, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public Transmisija TransSearch
        {
            get { return transSearch; }
            set { SetProperty(ref transSearch, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public TipoviVozila TipSearch
        {
            get { return tipSearch; }
            set { SetProperty(ref tipSearch, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task PopuniVozila()
        {
            if (Marke.Count == 0){
                var marke = await _marke.Get<IEnumerable<Marke>>(null);

                foreach (var item in marke)
                {
                    Marke.Add(item);
                }
            }
            if (Tipovi.Count == 0)
            {
                var tipovi = await _tipVozila.Get<IEnumerable<TipoviVozila>>(null);

                foreach (var item in tipovi)
                {
                    Tipovi.Add(item);
                }
            }
            if (Transmisija.Count == 0)
            {
                var transmisija = await _transmisija.Get<IEnumerable<Transmisija>>(null);


                foreach (var item in transmisija)
                {
                    Transmisija.Add(item);
                }
            }


            if (MarkaSearch != null || TipSearch != null || TransSearch != null)
            {
                VozilaSearchRequest search = new VozilaSearchRequest();
                if (MarkaSearch != null)
                {
                    search.MarkaId = MarkaSearch.MarkaId;
                    MarkaSearch = null;
                }
                if (TransSearch != null)
                {
                    search.TransmisijaId = TransSearch.TransmisijaId;
                    TransSearch = null;   
                }
                if (TipSearch != null)
                {
                    search.TipVozilaId = TipSearch.TipVozilaId;
                    TipSearch = null;
                }
                var listM = await _vozila.Get<IEnumerable<VozilaM>>(search);

                VozilaList.Clear();
                foreach (var item in listM)
                {
                    VozilaList.Add(item);
                }
                return;
            }


            if (MarkaSearch == null && TipSearch == null && TransSearch == null)
            { 
                var list = await _vozila.Get<IEnumerable<VozilaM>>(null);

            VozilaList.Clear();
            foreach (var item in list)
            {
                VozilaList.Add(item);
            }
            }
        }
    }
}
