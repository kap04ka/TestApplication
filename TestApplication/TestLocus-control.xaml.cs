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
    public partial class TestLocus_control : ContentPage
    {
        Task task;
        int testResult = 0;

        public TestLocus_control()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Получение результатов теста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                task = DisplayAlert("Результат", $"Ваше количетво баллов = {testResult}", "Принял");

                testResult = 0;

                await task;
                ResetAnswersInTest();
                //возврат в меню тестов
                await Navigation.PopAsync();
            }
            //пациент ответил не на все вопросы
            else
            {
                task = DisplayAlert("Предупреждение", "Пожалуйста ответьте на все вопросы", "Хорошо");
            }
        }
        private async void buttonMainMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        /// <summary>
        /// Считывание ответов из выпадающих списков
        /// </summary>
        private void ReadDataPicker()
        {
            App.patient.resultLocus.arrayAnswerLocus[0] = pickerFirstQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[1] = pickerSecondQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[2] = pickerThirdQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[3] = pickerFourthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[4] = pickerFifthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[5] = pickerSixthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[6] = pickerSeventhQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[7] = pickerEighthQuestion.SelectedIndex;
            App.patient.resultLocus.arrayAnswerLocus[8] = pickerNinthQuestion.SelectedIndex;
        }


        /// <summary>
        /// Сброс ответов теста
        /// </summary>
        private void ResetAnswersInTest()
        {
            pickerFirstQuestion.SelectedIndex = -1;
            pickerSecondQuestion.SelectedIndex = -1;
            pickerThirdQuestion.SelectedIndex = -1;
            pickerFourthQuestion.SelectedIndex = -1;
            pickerFifthQuestion.SelectedIndex = -1;
            pickerSixthQuestion.SelectedIndex = -1;
            pickerSeventhQuestion.SelectedIndex = -1;
            pickerEighthQuestion.SelectedIndex = -1;
            pickerNinthQuestion.SelectedIndex = -1;
        }


        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 9; i++)
            {
                if (App.patient.resultLocus.arrayAnswerLocus[i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Определение количества баллов за тест
        /// </summary>
        private void CalculateResult()
        {
            for (int i = 0; i < 5; i++)
            {
                testResult += (4 - App.patient.resultLocus.arrayAnswerLocus[i]);
            }
            for (int i = 5; i < 9; i++)
            {
                testResult += App.patient.resultLocus.arrayAnswerLocus[i];
            }

            App.patient.resultLocus.TotalResultLocus = testResult;
        }
    }
}