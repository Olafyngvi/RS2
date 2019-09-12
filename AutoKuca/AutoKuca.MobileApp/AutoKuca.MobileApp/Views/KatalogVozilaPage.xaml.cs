using AutoKuca.MobileApp.ViewModels;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKuca.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KatalogVozilaPage : ContentPage
    {
       private KatalogVozilaVM model;
        private readonly ApiService _vozilo = new ApiService("Vozila");
        private ApiService _slike = new ApiService("Slike");

        public KatalogVozilaPage()
        {
            InitializeComponent();
            BindingContext = model = new KatalogVozilaVM();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PopuniVozila();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as VozilaM;
            if (item == null)
                return;
           var item2 = await _vozilo.GetById<VozilaM>(item.VoziloId);
            SlikeSearchRequest request = new SlikeSearchRequest
            {
                VoziloID = item.VoziloId
            };
            ObservableCollection<Slike> slike= await _slike.Get<ObservableCollection<Slike>>(request);
            await Navigation.PushAsync(new DetaljiVozilaPage(new DetaljiVozilaVM(slike,item2)));
        }
    }
}