using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class TestVasserman : ContentPage
    {
        Task task;
        int testResult = 0;
        public TestVasserman()
        {
            InitializeComponent();
            Title = "Шкала Вассермана";
            //client = new Client(21);
        }

        private async void button_CalculateResult(object sender, System.EventArgs e)
        {
            ReadDataPicker();
            if (AnswersAllQuestions())
            {
                CalculateResult();
                task = DisplayAlert("Результат", $"{TakeDiagnose(testResult)}", "Принять");
                await task;
                testResult = 0;
                ResetAnswersInTest();
                Console.WriteLine($"{App.patient.resultVasserman.TotalResultVasserman} у пациента");
                Console.WriteLine($"{testResult} после окончания теста");
                await Navigation.PopAsync();
            }
            //пациент ответил не на все вопросы
            else
            {
                task = DisplayAlert("Предупреждение", "Пожалуйста ответьте на все вопросы", "Хорошо");
            }
        }
        private string TakeDiagnose(int score)
        {
            if (score == 0) return $"Ваше количество баллов = {score}, нарушений не выявлено";
            else if (score <= 20) return $"Ваше количество баллов = {score}, легая степень нарушений";
            else if (score > 20 && score <= 40) return $"Ваше количество баллов = {score}, средняя степень нарушений";
            else return $"Ваше количество баллов = {score}, грубая степень нарушений";
        }

        private void ResetAnswersInTest()
        {
            firstQuestion.SelectedIndex = -1;
            secondQuestion.SelectedIndex = -1;
            thirdQuestion.SelectedIndex = -1;
            fourthQuestion.SelectedIndex = -1;
            fifthQuestion.SelectedIndex = -1;
            sixthQuestion.SelectedIndex = -1;
            seventhQuestion.SelectedIndex = -1;
            eighthQuestion.SelectedIndex = -1;
            ninthQuestion.SelectedIndex = -1;
            tenthQuestion.SelectedIndex = -1;
            eleventhQuestion.SelectedIndex = -1;
            twelfthQuestion.SelectedIndex = -1;
            thirteenthQuestion.SelectedIndex = -1;
            fourteenthQuestion.SelectedIndex = -1;
            fifteenthQuestion.SelectedIndex = -1;
            sixteenthQuestion.SelectedIndex = -1;
            seventeenthQuestion.SelectedIndex = -1;
            eighteenthQuestion.SelectedIndex = -1;
            nineteenthQuestion.SelectedIndex = -1;
            twentiethQuestion.SelectedIndex = -1;
            twentyFirstQuestion.SelectedIndex = -1;
        }
        /// <summary>
        /// Считывание ответов из выпадающих списков
        /// </summary>
        private void ReadDataPicker()
        {
            App.patient.resultVasserman.arrayAnswerVasserman[0] = firstQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[1] = secondQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[2] = thirdQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[3] = fourthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[4] = fifthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[5] = sixthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[6] = seventhQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[7] = eighthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[8] = ninthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[9] = tenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[10] = eleventhQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[11] = twelfthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[12] = thirteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[13] = fourteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[14] = fifteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[15] = sixteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[16] = seventeenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[17] = eighteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[18] = nineteenthQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[19] = twentiethQuestion.SelectedIndex;
            App.patient.resultVasserman.arrayAnswerVasserman[20] = twentyFirstQuestion.SelectedIndex;
        }

        /// <summary>
        /// Проверка на все ли вопросы ответил пациент
        /// </summary>
        /// <returns></returns>
        private bool AnswersAllQuestions()
        {
            for (int i = 0; i < 21; i++)
            {
                if (App.patient.resultVasserman.arrayAnswerVasserman[i] == -1)
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
            if (App.patient.resultVasserman.arrayAnswerVasserman[0] == 2 || App.patient.resultVasserman.arrayAnswerVasserman[0] == 3) testResult += 2;
            else if (App.patient.resultVasserman.arrayAnswerVasserman[0] == 4 || App.patient.resultVasserman.arrayAnswerVasserman[0] == 5) testResult += 3;
            else testResult += App.patient.resultVasserman.arrayAnswerVasserman[0];

            for (int i = 1; i < 3; i++)
            {
                testResult += App.patient.resultVasserman.arrayAnswerVasserman[i];
            }

            if (App.patient.resultVasserman.arrayAnswerVasserman[3] == 2 || App.patient.resultVasserman.arrayAnswerVasserman[3] == 3) testResult += 2;
            else if (App.patient.resultVasserman.arrayAnswerVasserman[3] == 4 || App.patient.resultVasserman.arrayAnswerVasserman[3] == 5) testResult += 3;
            else testResult += App.patient.resultVasserman.arrayAnswerVasserman[3];

            for (int i = 4; i < 21; i++)
            {
                testResult += App.patient.resultVasserman.arrayAnswerVasserman[i];
            }

            App.patient.resultVasserman.TotalResultVasserman = testResult;
        }

    }
}