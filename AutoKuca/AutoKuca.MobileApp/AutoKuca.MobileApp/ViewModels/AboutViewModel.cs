using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace AutoKuca.MobileApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "O nama";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://p1704.azurewebsites.net/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}