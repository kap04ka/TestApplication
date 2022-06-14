using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApplication
{
    public partial class App : Application
    {
        public static Patient patient;
        public App()
        {
            InitializeComponent();
            patient = new Patient();


            MainPage = new NavigationPage(new MainPage());
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
