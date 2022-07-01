using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormPatients : ContentPage
    {
        public FormPatients()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Обработчкик нажатия на кнопку регистрации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_SignIn(object sender, System.EventArgs e)
        {
            ReadDataPatient();

            //ввели данные 
            if (DataEntered())
            {
                //данные введены правильно
                if (DataValidation())
                {
                    //переход на тест
                    await Navigation.PushModalAsync(App.navigationPage);
                }
                //не правильно введены данные
                else
                {
                    Task<bool> resultWarning = DisplayAlert("Предупреждение", "Введите данные корректно", "Я - доктор", "ОК");
                    await resultWarning;

                    //переход на тест
                    if (resultWarning.Result == true)
                    {
                        await Navigation.PushModalAsync(App.navigationPage);
                    }
                }
            }
            //данные не ввели
            else
            {
                Task<bool> resultError = DisplayAlert("Ошибка", "Введите свои данные в каждом пунтке", "Я - доктор", "ОК");
                await resultError;

                //переход на тест
                if (resultError.Result == true)
                {
                    await Navigation.PushModalAsync(App.navigationPage);
                }
            }
        }


        /// <summary>
        /// Считывание введенных данных из формы
        /// </summary>
        private void ReadDataPatient()
        {
            App.patient.Forename = entryForename.Text;
            App.patient.Surname = entrySurname.Text;
            App.patient.Patronymic = entryPatronymic.Text;
            App.patient.PhoneNumber = entryTelephone.Text;
            App.patient.Email = entryEmail.Text;
            App.patient.Company = entryWork.Text;
            App.patient.DoctorFIO = entryAttendingDoctor.Text;
            App.patient.DateOfBirth = dataPickerDateOfBirth.Date;

            App.patient.BirthDateString = App.patient.DateOfBirth.ToShortDateString();

            App.patient.Age = DateTime.Today.Year - App.patient.DateOfBirth.Year;
            if (App.patient.DateOfBirth.DayOfYear > DateTime.Today.DayOfYear)
            {
                App.patient.Age--;
            }

            App.patient.scoreMFI20.Name = App.patient.Forename;
            App.patient.scoreMFI20.Surname = App.patient.Surname;
            App.patient.scoreBourdon.Name = App.patient.Forename;
            App.patient.scoreBourdon.Surname = App.patient.Surname;
            App.patient.resultMOSA.Name = App.patient.Forename;
            App.patient.resultMOSA.Surname = App.patient.Surname;
            App.patient.resultPraxisAndGnosis.Name = App.patient.Forename;
            App.patient.resultPraxisAndGnosis.Surname = App.patient.Surname;
            App.patient.resultVasserman.Name = App.patient.Forename;
            App.patient.resultVasserman.Surname = App.patient.Surname;
        }


        /// <summary>
        /// Ввел ли пациент данные 
        /// </summary>
        /// <returns></returns>
        private bool DataEntered()
        {
            if (App.patient.Forename == null || App.patient.Surname == null || App.patient.Patronymic == null ||
               App.patient.PhoneNumber == null || App.patient.Email == null || App.patient.Company == null ||
               App.patient.DoctorFIO == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Проверка правильности введенных данных
        /// </summary>
        /// <returns></returns>
        private bool DataValidation()
        {
            if (App.patient.Forename == "" || App.patient.Surname == "" || App.patient.Patronymic == "" ||
               App.patient.PhoneNumber == "" || App.patient.Email == "" || App.patient.Company == "" ||
               App.patient.DoctorFIO == "" || App.patient.Forename[0] == ' ' || App.patient.Surname[0] == ' ' ||
               App.patient.Patronymic[0] == ' ' || App.patient.PhoneNumber[0] == ' ' || App.patient.Email[0] == ' ' ||
               App.patient.Company[0] == ' ' || App.patient.DoctorFIO[0] == ' ' || App.patient.Age < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}