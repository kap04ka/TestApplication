using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace TestApplication
{
    internal class Client
    {
        /// <summary>
        /// Количество баллов заработанных пациентом за тест
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// Массив ответов
        /// </summary>
        public int[] arrayAnswer;
        public Client()
        {

        }
        public Client(int countQuestion)
        {
            arrayAnswer = new int[countQuestion];
        }
    }

    public partial class TestLifeQuality : ContentPage
    {
        //Client client;

        int testResult = 0;

        public TestLifeQuality()
        {
            InitializeComponent();
            Title = "Европейский опросник качества жизнии";
            //client = new Client(6);
        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                DisplayAlert("Результат", $"Ваше количетво баллов = {App.patient.resultLifeQuality.TotalResultLifeQuality}", "Принять");
                //SaveJson(client);
                testResult = 0;
                Console.WriteLine($"{App.patient.resultLifeQuality.TotalResultLifeQuality} у пациента");
                Console.WriteLine($"{testResult} после окончания теста");
            }
            //пациент ответил не на все вопросы
            else
            {
                DisplayAlert("Предупреждение", "Пожалуйста ответьте на все вопросы", "Хорошо");
            }
        }

        /// <summary>
        /// Считывание ответов из выпадающих списков
        /// </summary>
        private void ReadDataPicker()
        {
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[0] = firstQuestion.SelectedIndex;
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[1] = secondQuestion.SelectedIndex;
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[2] = thirdQuestion.SelectedIndex;
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[3] = fourthQuestion.SelectedIndex;
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[4] = fifthQuestion.SelectedIndex;
            App.patient.resultLifeQuality.arrayAnswerLifeQuality[5] = sixthQuestion.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {

            for (int i = 0; i < 6; i++)
            {
                if (App.patient.resultLifeQuality.arrayAnswerLifeQuality[i] == -1)
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
            for (int i = 0; i < 6; i++)
            {
                testResult += App.patient.resultLifeQuality.arrayAnswerLifeQuality[i];
            }
            App.patient.resultLifeQuality.TotalResultLifeQuality = testResult;
        }

       /* private void SaveJson(Client _client)
        {
            var jsonString = JsonConvert.SerializeObject(_client);

            var fileName = "result.json";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, fileName);

            Console.WriteLine(path);
            Console.WriteLine(jsonString);

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(jsonString);
            sw.Close();
        }*/

    }

}