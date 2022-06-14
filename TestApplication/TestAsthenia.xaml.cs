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
    public partial class TestAsthenia : ContentPage
    {
        /// <summary>
        /// Массив баллов за каждый вопрос
        /// </summary>
        private int[] arrayAnswerMFI;
        private Task task;

        public TestAsthenia()
        {
            InitializeComponent();

            arrayAnswerMFI = new int[20];
            ResetArray();
        }


        /// <summary>
        /// Обработчик передвижения ползунка
        /// </summary>
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == sliderFirstAnswer)
            {
                labelFirstAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[0] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSecondAnswer)
            {
                labelSecondAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[1] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderThirdAnswer)
            {
                labelThirdAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[2] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFourthAnswer)
            {
                labelFourthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[3] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFifthAnswer)
            {
                labelFifthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[4] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSixthAnswer)
            {
                labelSixthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[5] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSeventhAnswer)
            {
                labelSeventhAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[6] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEighthAnswer)
            {
                labelEighthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[7] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderNinthAnswer)
            {
                labelNinthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[8] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTenthAnswer)
            {
                labelTenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[9] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEleventhAnswer)
            {
                labelEleventhAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[10] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTwelfthAnswer)
            {
                labelTwelfthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[11] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderThirteenAnswer)
            {
                labelThirteenAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[12] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFourteenthAnswer)
            {
                labelFourteenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[13] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderFifteenthAnswer)
            {
                labelFifteenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[14] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSixteenthAnswer)
            {
                labelSixteenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[15] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderSeventeenthAnswer)
            {
                labelSeventeenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[16] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderEighteenthAnswer)
            {
                labelEighteenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[17] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderNineteenthAnswer)
            {
                labelNineteenthAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[18] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderTwentiethAnswer)
            {
                labelTwentiethAnswer.Text = String.Format("Выбрано: {0:F0}", e.NewValue);
                arrayAnswerMFI[19] = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
        }


        /// <summary>
        /// Корректировка баллов в соостветствие с таблицей
        /// </summary>
        private void CorrectionScore()
        {
            arrayAnswerMFI[1] = 6 - arrayAnswerMFI[1];
            arrayAnswerMFI[4] = 6 - arrayAnswerMFI[4];
            arrayAnswerMFI[8] = 6 - arrayAnswerMFI[8];
            arrayAnswerMFI[9] = 6 - arrayAnswerMFI[9];
            arrayAnswerMFI[12] = 6 - arrayAnswerMFI[12];
            arrayAnswerMFI[13] = 6 - arrayAnswerMFI[13];
            for (int i = 15; i < 19; i++)
            {
                arrayAnswerMFI[i] = 6 - arrayAnswerMFI[i];
            }
        }


        /// <summary>
        /// Расчет баллов
        /// </summary>
        private void CalculateScore()
        {
            MainPage.patient.scoreMFI20.ScoreAnswerGeneralAsthenia =
                arrayAnswerMFI[0] + arrayAnswerMFI[4] + arrayAnswerMFI[11] + arrayAnswerMFI[15];
            MainPage.patient.scoreMFI20.ScoreAnswerReducedActivity =
                arrayAnswerMFI[2] + arrayAnswerMFI[5] + arrayAnswerMFI[9] + arrayAnswerMFI[16];
            MainPage.patient.scoreMFI20.ScoreAnswerDecreasedMotivation =
                arrayAnswerMFI[3] + arrayAnswerMFI[8] + arrayAnswerMFI[14] + arrayAnswerMFI[17];
            MainPage.patient.scoreMFI20.ScoreAnswerPhysicalAsthenia =
                arrayAnswerMFI[1] + arrayAnswerMFI[7] + arrayAnswerMFI[13] + arrayAnswerMFI[19];
            MainPage.patient.scoreMFI20.ScoreAnswerMentalAsthenia =
                arrayAnswerMFI[6] + arrayAnswerMFI[10] + arrayAnswerMFI[12] + arrayAnswerMFI[18];

            MainPage.patient.scoreMFI20.TotalTestScore = MainPage.patient.scoreMFI20.ScoreAnswerGeneralAsthenia +
                 MainPage.patient.scoreMFI20.ScoreAnswerReducedActivity + MainPage.patient.scoreMFI20.ScoreAnswerDecreasedMotivation +
                 MainPage.patient.scoreMFI20.ScoreAnswerPhysicalAsthenia + MainPage.patient.scoreMFI20.ScoreAnswerMentalAsthenia;
        }


        /// <summary>
        /// Обработчик нажатия на возвращения в меню
        /// </summary>
        private async void buttonMainMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        /// <summary>
        /// Обработчик нажатия на расчет баллов
        /// </summary>
        private async void buttonCalculateResult_Clicked(object sender, EventArgs e)
        {
            CorrectionScore();
            CalculateScore();

            if (MainPage.patient.scoreMFI20.TotalTestScore <= 30)
            {
                task = DisplayAlert("Результат теста", $"Количество баллов = {MainPage.patient.scoreMFI20.TotalTestScore}\n" +
                    "Балл в норме", "ОК");
            }
            else
            {
                task = DisplayAlert("Результат теста", $"Количество баллов = {MainPage.patient.scoreMFI20.TotalTestScore}\n" +
                    "Балл выше нормы", "ОК");
            }

            CorrectionScore();
            await task;
            buttonMainMenu_Clicked(sender, e);
        }


        /// <summary>
        /// Сброс значений массива
        /// </summary>
        private void ResetArray()
        {
            for (int i = 0; i < arrayAnswerMFI.Length; i++)
            {
                arrayAnswerMFI[i] = 1;
            }
        }

    }
}