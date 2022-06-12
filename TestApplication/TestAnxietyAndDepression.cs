using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace TestApplication
{

    public partial class TestAnxietyAndDepression : ContentPage
    {
        Client clientAnxiety;
        Client clientDepression;
        public TestAnxietyAndDepression()
        {
            InitializeComponent();
            Title = "Тест тревожности и депрессии";
            clientAnxiety = new Client(7);
            clientDepression = new Client(7);
        }
        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                var result = CalculateResult();
                DisplayAlert("Результат", $"{result.Item1} \n {result.Item2}", "Принять");
                //SaveJson(client);
                clientAnxiety.Score = 0;
                clientDepression.Score = 0;
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
            clientAnxiety.arrayAnswer[0] = firstQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[1] = secondQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[2] = thirdQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[3] = fourthQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[4] = fifthQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[5] = sixthQuestionAnxiety.SelectedIndex;
            clientAnxiety.arrayAnswer[6] = seventhQuestionAnxiety.SelectedIndex;

            clientDepression.arrayAnswer[0] = firstQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[1] = secondQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[2] = thirdQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[3] = fourthQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[4] = fifthQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[5] = sixthQuestionDepression.SelectedIndex;
            clientDepression.arrayAnswer[6] = seventhQuestionDepression.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 7; i++)
            {
                if (clientAnxiety.arrayAnswer[i] == -1 || clientDepression.arrayAnswer[i] == -1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Определение количества баллов за тест
        /// </summary>
        private (string, string) CalculateResult()
        {
            string resultAnxiety;
            string resultDepression;

            for (int i = 0; i < 7; i++)
            {
                clientAnxiety.Score += clientAnxiety.arrayAnswer[i];
                clientDepression.Score += clientDepression.arrayAnswer[i];
            }

            resultAnxiety = GetOneResult(clientAnxiety.Score) + "тревога";
            resultDepression = GetOneResult(clientDepression.Score) + "депрессия";

            return (resultAnxiety, resultDepression);

        }

        private string GetOneResult(int score)
        {
            if (score <= 7) return $"Ваш результат {score} - в норме по тесту ";
            else if (score > 7 && score <= 10) return $"Ваш результат {score} - субклинически выраженная ";
            else return $"Ваш результат {score} - клинически выраженная ";
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