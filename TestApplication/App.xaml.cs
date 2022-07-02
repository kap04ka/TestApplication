 using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Threading;
using System.Globalization;

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



        public const string DATABASE_NAME = "patients.db";
        public static PatientRepository database;
        public static PatientRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PatientRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public static MainPage startPage;



        public App()
        {
            InitializeComponent();

            patient = new Patient();
            mainPage = new MainPage();
            formPatients = new FormPatients();
            startPage = new MainPage();

            navigationPage = new NavigationPage(mainPage);
            navigationPage.BarBackgroundColor = Color.Orange;
            navigationPage.BarTextColor = Color.Black;


            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ru-RU");


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
