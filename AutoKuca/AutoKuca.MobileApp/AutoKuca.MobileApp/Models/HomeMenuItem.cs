using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKuca.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        KatalogVozila,
        KatalogDijelova,
        Korpa,
        Kontakt,
        Profil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
