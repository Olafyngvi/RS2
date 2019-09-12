using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.ViewModels;
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
    public partial class DijeloviPage : ContentPage
    {
        private DijeloviViewModel model = null;
        public DijeloviPage()
        {
            Title = "Dijelovi";
            InitializeComponent();
            BindingContext = model = new DijeloviViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var dio = e.SelectedItem as DioKategorija;
            Navigation.PushAsync(new DioDetaljiPage(dio));
        }
    }
}