using App5.Mobile.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new testpage());
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
