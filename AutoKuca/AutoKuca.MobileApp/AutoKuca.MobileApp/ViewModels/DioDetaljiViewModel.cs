using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AutoKuca.MobileApp.Models;
using AutoKuca.MobileApp.Services;
using AutoKuca.MobileApp.ViewModels;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class DioDetaljiViewModel : BaseViewModel
    {
        public DioDetaljiViewModel()
        {
            KolicinaIncrementCommand = new Command(() => Kolicina += 1);
        }
        public DioKategorija Dio { get; set; }

        decimal _kolicina = 1;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand KolicinaIncrementCommand { get; set; }

    }
}
