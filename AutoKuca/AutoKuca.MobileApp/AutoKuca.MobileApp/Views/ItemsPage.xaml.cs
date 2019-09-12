using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.Views;
using AutoKuca.MobileApp.ViewModels;
using AutoKuca.Model.Requests;
using AutoKuca.Model;
using System.Collections.ObjectModel;

namespace AutoKuca.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        private ApiService _slike = new ApiService("Slike");
        private readonly ApiService _vozilo = new ApiService("Vozila");

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

    

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await viewModel.PopuniVozila();
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
            ObservableCollection<Slike> slike = await _slike.Get<ObservableCollection<Slike>>(request);
            await Navigation.PushAsync(new DetaljiVozilaPage(new DetaljiVozilaVM(slike, item2)));
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var dio = e.Item as DioKategorija;
            Navigation.PushAsync(new DioDetaljiPage(dio));
        }
    }
}