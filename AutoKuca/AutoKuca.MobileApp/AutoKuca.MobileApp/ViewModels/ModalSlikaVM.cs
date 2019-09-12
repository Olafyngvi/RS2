using AutoKuca.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.MobileApp.ViewModels
{
    public class ModalSlikaVM:BaseViewModel
    {
        public Slike Slika { get; set; }
        public ModalSlikaVM(Slike slika)
        {
            Slika = slika;
        }
    }
}
