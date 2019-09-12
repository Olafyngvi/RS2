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
    public partial class ModalSlikaPage : ContentPage
    {
        private ModalSlikaVM model;
        public ModalSlikaPage(ModalSlikaVM mod)
        {
            InitializeComponent();
            BindingContext = this.model = mod;
        }
    }
}