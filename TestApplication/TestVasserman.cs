using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class TestVasserman : ContentPage
    {
        Client client;
        public TestVasserman()
        {
            InitializeComponent();
            Title = "Шкала Вассермана";
            client = new Client(21);
        }
        private void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                DisplayAlert("Результат", $"{TakeDiagnose(client.Score)}", "Принять");
                client.Score = 0;
            }
            //пациент ответил не на все вопросы
            else
            {
                DisplayAlert("Предупреждение", "Пожалуйста ответьте на все вопросы", "Хорошо");
            }
        }
        private string TakeDiagnose(int score)
        {
            if (score == 0) return $"Ваше количество баллов = {score}, нарушений не выявлено";
            else if (score <= 20) return $"Ваше количество баллов = {score}, легая степень нарушений";
            else if (score > 20 && score <= 40) return $"Ваше количество баллов = {score}, средняя степень нарушений";
            else return $"Ваше количество баллов = {score}, грубая степень нарушений";
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
            client.arrayAnswer[6] = seventhQuestion.SelectedIndex;
            client.arrayAnswer[7] = eighthQuestion.SelectedIndex;
            client.arrayAnswer[8] = ninthQuestion.SelectedIndex;
            client.arrayAnswer[9] = tenthQuestion.SelectedIndex;
            client.arrayAnswer[10] = eleventhQuestion.SelectedIndex;
            client.arrayAnswer[11] = twelfthQuestion.SelectedIndex;
            client.arrayAnswer[12] = thirteenthQuestion.SelectedIndex;
            client.arrayAnswer[13] = fourteenthQuestion.SelectedIndex;
            client.arrayAnswer[14] = fifteenthQuestion.SelectedIndex;
            client.arrayAnswer[15] = sixteenthQuestion.SelectedIndex;
            client.arrayAnswer[16] = seventhQuestion.SelectedIndex;
            client.arrayAnswer[17] = eighteenthQuestion.SelectedIndex;
            client.arrayAnswer[18] = nineteenthQuestion.SelectedIndex;
            client.arrayAnswer[19] = twentiethQuestion.SelectedIndex;
            client.arrayAnswer[20] = twentyFirstQuestion.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 21; i++)
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
            if (client.arrayAnswer[0] == 2 || client.arrayAnswer[0] == 3) client.Score += 2;
            else if (client.arrayAnswer[0] == 4 || client.arrayAnswer[0] == 5) client.Score += 3;
            else client.Score += client.arrayAnswer[0];

            for (int i = 1; i < 3; i++)
            {
                client.Score += client.arrayAnswer[i];
            }

            if (client.arrayAnswer[3] == 2 || client.arrayAnswer[3] == 3) client.Score += 2;
            else if (client.arrayAnswer[3] == 4 || client.arrayAnswer[3] == 5) client.Score += 3;
            else client.Score += client.arrayAnswer[3];

            for (int i = 4; i < 21; i++)
            {
                client.Score += client.arrayAnswer[i];
            }

        }

    }
}