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
        Client client;

        public TestLifeQuality()
        {
            InitializeComponent();
            Title = "Европейский опросник качества жизнии";
            client = new Client(6);
        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                DisplayAlert("Результат", $"Ваше количетво баллов = {client.Score}", "Принять");
                //SaveJson(client);
                client.Score = 0;
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
            client.arrayAnswer[0] = firstQuestion.SelectedIndex;
            client.arrayAnswer[1] = secondQuestion.SelectedIndex;
            client.arrayAnswer[2] = thirdQuestion.SelectedIndex;
            client.arrayAnswer[3] = fourthQuestion.SelectedIndex;
            client.arrayAnswer[4] = fifthQuestion.SelectedIndex;
            client.arrayAnswer[5] = sixthQuestion.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 6; i++)
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
            for (int i = 0; i < 6; i++)
            {
                client.Score += client.arrayAnswer[i];
            }
           
        }

        private void SaveJson(Client _client)
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
        }

    }

}