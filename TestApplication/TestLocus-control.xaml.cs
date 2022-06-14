using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApplication
{
    public class ClientKirill
    {
        /// <summary>
        /// Количество баллов заработанных пациентом за тест
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Массив ответов
        /// </summary>
        public int[] arrayAnswer;

        public ClientKirill()
        {
            arrayAnswer = new int[9];
        }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestLocus_control : ContentPage
    {
        Task task;
        ClientKirill client;

        public TestLocus_control()
        {
            InitializeComponent();
            client = new ClientKirill();
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
                task = DisplayAlert("Результат", $"Ваше количетво баллов = {client.Score}", "Принял");

                client.Score = 0;
                await task;
                //возврат в меню тестов
                await Navigation.PopAsync();
            }
            //пациент ответил не на все вопросы
            else
            {
                task = DisplayAlert("Предупреждение", "Пожалуйста ответьте на все вопросы", "Хорошо");
            }
        }

        /// <summary>
        /// Считывание ответов из выпадающих списков
        /// </summary>
        private void ReadDataPicker()
        {
            client.arrayAnswer[0] = pickerFirstQuestion.SelectedIndex;
            client.arrayAnswer[1] = pickerSecondQuestion.SelectedIndex;
            client.arrayAnswer[2] = pickerThirdQuestion.SelectedIndex;
            client.arrayAnswer[3] = pickerFourthQuestion.SelectedIndex;
            client.arrayAnswer[4] = pickerFifthQuestion.SelectedIndex;
            client.arrayAnswer[5] = pickerSixthQuestion.SelectedIndex;
            client.arrayAnswer[6] = pickerSeventhQuestion.SelectedIndex;
            client.arrayAnswer[7] = pickerEighthQuestion.SelectedIndex;
            client.arrayAnswer[8] = pickerNinthQuestion.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 9; i++)
            {
                if (client.arrayAnswer[i] == -1)
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
                client.Score += (4 - client.arrayAnswer[i]);
            }
            for (int i = 5; i < 9; i++)
            {
                client.Score += client.arrayAnswer[i];
            }
        }
    }
}