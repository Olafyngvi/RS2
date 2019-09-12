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
    public partial class KontaktPage : ContentPage
    {
        KontaktVM model;
        public KontaktPage()
        {
            InitializeComponent();
            BindingContext = model = new KontaktVM();
          
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
             await model.PopuniPoslovnice();
        }

    }
}