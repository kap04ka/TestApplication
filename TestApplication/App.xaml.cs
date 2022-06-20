 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApplication
{
    public partial class App : Application
    {
        /// <summary>
        /// Пациент
        /// </summary>
        public static Patient patient;
        /// <summary>
        /// Объект меню выбора тестов
        /// </summary>
        public MainPage mainPage;
        /// <summary>
        /// Навигационная страницы
        /// </summary>
        public static NavigationPage navigationPage;
        /// <summary>
        /// Форма регистрации пациента
        /// </summary>
        public FormPatients formPatients;
        

        public App()
        {
            InitializeComponent();

            patient = new Patient();
            mainPage = new MainPage();
            formPatients = new FormPatients();

            navigationPage = new NavigationPage(mainPage);
            navigationPage.BarBackgroundColor = Color.Orange;
            navigationPage.BarTextColor = Color.Black;
            

            MainPage = formPatients;
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
