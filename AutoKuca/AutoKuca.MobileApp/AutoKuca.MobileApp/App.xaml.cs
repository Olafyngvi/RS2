﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AutoKuca.MobileApp.Services;
using AutoKuca.MobileApp.Views;

namespace AutoKuca.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();

            //MainPage = new RegistracijaPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
