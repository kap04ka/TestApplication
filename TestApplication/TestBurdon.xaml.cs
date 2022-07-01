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
    public partial class TestBurdon : ContentPage
    {
        /// <summary>
        /// Количество просмотренных строк
        /// </summary>
        private int amountLines;
        /// <summary>
        /// Количество ошибок
        /// </summary>
        private int amountMistakes;
        /// <summary>
        /// Количество букв за минуту
        /// </summary>
        private int amountLettersInOneMinute;
        /// <summary>
        /// Количество букв за 2 минуты
        /// </summary>
        private int amountLettersInTwoMinutes;
        /// <summary>
        /// Количество букв за 3 минуты
        /// </summary>
        private int amountLettersInThreeMinutes;
        /// <summary>
        /// Количество букв за 4 минуты
        /// </summary>
        private int amountLettersInFourMinutes;
        /// <summary>
        /// Количество букв за 5 минут
        /// </summary>
        private int amountLettersInFiveMinutes;
        /// <summary>
        /// Максимальный темп выполнения
        /// </summary>
        private int maxPaceInTime;
        /// <summary>
        /// Минимальный темп выполнения
        /// </summary>
        private int minPaceInTime;

        public TestBurdon()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Обработчик нажатия кнопки результатов расчета
        /// </summary>
        private async void buttonCalculateResult_Clicked(object sender, EventArgs e)
        {
            if (EmptyData())
            {
                await DisplayAlert("Ошибка", "Введите все требуемые данные", "ОК");
            }
            else
            {
                if (UnvalidationData())
                {
                    await DisplayAlert("Предупреждение", "Введите корректные данные", "ОК");
                }
                else
                {
                    ReadData();
                    CalculateResult();
                    await DisplayAlert("Результат", FormatOutputString(), "ОК");
                    ResetValueTest();
                    await Navigation.PopAsync();
                }
            }
        }


        /// <summary>
        /// Проверка на не введенные значения
        /// </summary>
        private bool EmptyData()
        {
            if (entryNumberOfLines.Text == null || entryNumberOfMistakes.Text == null || entryNumberOfLetters1.Text == null ||
                entryNumberOfLetters2.Text == null || entryNumberOfLetters3.Text == null || entryNumberOfLetters4.Text == null ||
                entryNumberOfLetters5.Text == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Проверка на неправильно введенные данные
        /// </summary>
        private bool UnvalidationData()
        {
            if (entryNumberOfLines.TextColor == Color.Red || entryNumberOfMistakes.TextColor == Color.Red ||
                entryNumberOfLetters1.TextColor == Color.Red || entryNumberOfLetters2.TextColor == Color.Red ||
                entryNumberOfLetters3.TextColor == Color.Red || entryNumberOfLetters4.TextColor == Color.Red ||
                entryNumberOfLetters5.TextColor == Color.Red)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Считывание данных из полей ввода
        /// </summary>
        private void ReadData()
        {
            amountLines = Int32.Parse(entryNumberOfLines.Text);
            amountMistakes = Int32.Parse(entryNumberOfMistakes.Text);
            amountLettersInOneMinute = Int32.Parse(entryNumberOfLetters1.Text);
            amountLettersInTwoMinutes = Int32.Parse(entryNumberOfLetters2.Text);
            amountLettersInTwoMinutes = Int32.Parse(entryNumberOfLetters2.Text);
            amountLettersInThreeMinutes = Int32.Parse(entryNumberOfLetters3.Text);
            amountLettersInFourMinutes = Int32.Parse(entryNumberOfLetters4.Text);
            amountLettersInFiveMinutes = Int32.Parse(entryNumberOfLetters5.Text);
        }


        /// <summary>
        /// Подсчет результатов
        /// </summary>
        private void CalculateResult()
        {
            if (amountMistakes == 0)
            {
                App.patient.scoreBourdon.ConcentrationOfAtention = 2 * amountLines;
            }
            else
            {
                App.patient.scoreBourdon.ConcentrationOfAtention = (int)Math.Round(2.0 * amountLines / amountMistakes, 0);
            }

            App.patient.scoreBourdon.PaceArray[0] = (int)Math.Round(amountLettersInOneMinute / 1.0, 0);
            App.patient.scoreBourdon.PaceArray[1] = (int)Math.Round(amountLettersInTwoMinutes / 2.0, 0);
            App.patient.scoreBourdon.PaceArray[2] = (int)Math.Round(amountLettersInThreeMinutes / 3.0, 0);
            App.patient.scoreBourdon.PaceArray[3] = (int)Math.Round(amountLettersInFourMinutes / 4.0, 0);
            App.patient.scoreBourdon.PaceArray[4] = (int)Math.Round(amountLettersInFiveMinutes / 5.0, 0);

            App.patient.scoreBourdon.PaceString = 
                App.patient.scoreBourdon.PaceArray[0].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[1].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[2].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[3].ToString() + ", " +
                App.patient.scoreBourdon.PaceArray[4].ToString();

            maxPaceInTime = App.patient.scoreBourdon.PaceArray.Max();
            minPaceInTime = App.patient.scoreBourdon.PaceArray.Min();
            App.patient.scoreBourdon.AttentionSpan = maxPaceInTime - minPaceInTime;
        }


        /// <summary>
        /// Форматированная строка вывода
        /// </summary>
        private string FormatOutputString()
        {
            string lineOne;
            string lineTwo;
            lineOne = "Концентрация внимания = " + App.patient.scoreBourdon.ConcentrationOfAtention.ToString() + "\n";
            lineTwo = "Устойчивость внимания = " + App.patient.scoreBourdon.AttentionSpan.ToString();
            switch (App.patient.scoreBourdon.AttentionSpan)
            {
                case 0:
                case 1:
                case 2:
                    lineTwo += " - очень высокая";
                    break;
                case 3:
                case 4:
                    lineTwo += " - высокая";
                    break;
                case 5:
                case 6:
                    lineTwo += " - средняя";
                    break;
                case 7:
                case 8:
                    lineTwo += " - низкая";
                    break;
                case 9:
                case 10:
                    lineTwo += " - очень низкая";
                    break;
            }

            return lineOne + lineTwo;
        }

        /// <summary>
        /// Сброс полей для ввода данных
        /// </summary>
        private void ResetValueTest()
        {
            entryNumberOfLines.Text = null;
            entryNumberOfMistakes.Text = null;
            entryNumberOfLetters1.Text = null;
            entryNumberOfLetters2.Text = null;
            entryNumberOfLetters3.Text = null;
            entryNumberOfLetters4.Text = null;
            entryNumberOfLetters5.Text = null;
        }
    }


    /// <summary>
    /// Класс для проверки правильности введенных данных
    /// </summary>
    public class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            uint number;
            if (!UInt32.TryParse(sender.Text, out number))
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Black;
            }
        }
    }
}