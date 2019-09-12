using AutoKuca.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutoKuca.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.KatalogVozila, Title="Katalog vozila" },
                new HomeMenuItem {Id = MenuItemType.KatalogDijelova, Title="Katalog dijelova" },
                new HomeMenuItem {Id = MenuItemType.Korpa,Title="Korpa"},
                new HomeMenuItem {Id = MenuItemType.About, Title="O nama" },
                new HomeMenuItem {Id = MenuItemType.Kontakt, Title="Kontakt" },
                new HomeMenuItem {Id = MenuItemType.Profil, Title="Profil" }

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}