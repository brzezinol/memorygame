﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MemoryGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            MainPage.BindingContext = new MainPageViewModel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
