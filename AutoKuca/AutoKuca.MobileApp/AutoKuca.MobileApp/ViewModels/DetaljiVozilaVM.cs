using AutoKuca.MobileApp.Views;
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
    public class DetaljiVozilaVM : BaseViewModel
    {

        private ApiService _slike = new ApiService("Slike");
        private readonly ApiService _vozila = new ApiService("Vozila");

        public VozilaM Vozilo { get; set; }

        Slike slika = new Slike();
        DetaljiVozilaPage _page = new DetaljiVozilaPage(null);

        public ObservableCollection<Slike> Galerija { get; set; } = new ObservableCollection<Slike>();
        public ObservableCollection<VozilaM> VozilaList { get; set; } = new ObservableCollection<VozilaM>();
        public ObservableCollection<VozilaM> VozilaTip { get; set; } = new ObservableCollection<VozilaM>();



        public DetaljiVozilaVM(ObservableCollection<Slike> slike, VozilaM auto = null)
        {
            Title = "Detalji vozila";
            Vozilo = auto;
            Galerija = slike;
          
       
        }

        public Slike OdabranaSlika
        {
            get { return slika; }
            set { SetProperty(ref slika, value); }
        }

        public async Task PopuniVozila()
        {
            VozilaSearchRequest search = new VozilaSearchRequest {
                preporuka = true,
                voziloId = Vozilo.VoziloId
            };

            var listM = await _vozila.Get<IEnumerable<VozilaM>>(search);
            
            VozilaList.Clear();

            foreach (var item in listM)
            {
                VozilaList.Add(item);
            }

            VozilaSearchRequest search1 = new VozilaSearchRequest
            {
                preporukaTip = true,
                voziloId = Vozilo.VoziloId
            };

            var listM1 = await _vozila.Get<IEnumerable<VozilaM>>(search1);

            VozilaTip.Clear();

            foreach (var item in listM1)
            {
                VozilaTip.Add(item);
            }

        }







    }
}
