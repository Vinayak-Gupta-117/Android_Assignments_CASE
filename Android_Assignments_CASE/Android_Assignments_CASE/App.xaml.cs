﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Android_Assignments_CASE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Assignment1();
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
