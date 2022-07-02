using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swag_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var page = new NavigationPage(new SwaggPage());
            page.BarTextColor = Color.Aquamarine;
            page.BarBackgroundColor = Color.Transparent;
            //(Color)App.Current.Resources["primaryGreen"];
            MainPage = page;
        }


//        MainPage = new MainPage();

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
