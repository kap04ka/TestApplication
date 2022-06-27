using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace TestApplication
{
    public partial class MainPage : ContentPage
    {
        Task task;
        public MainPage()
        {

            InitializeComponent();
            Title = "Страница с тестами";

 
            List<string> nameTests = new List<string>() { "Тест COVID-19", "Оценка когнитивной сферы", "Шкала Вассермана", "Корректурная проба Бурдона",
                                                          "Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса",
                                                          "Шкала тревоги и депрессии", "Субъективная шкала оценки астении", "Европейский опросник качества жизни",
                                                          "Шкала локуса-контроля"};

            List<ContentPage> pages = new List<ContentPage>() { new TestCOVID(), new TestCognitive(), new TestVasserman(), new TestBurdon(),
                                                                new TestPraxisAndGnosis(), new TestAnxietyAndDepression(), new TestAsthenia(),
                                                                new TestLifeQuality(), new TestLocus_control()};

            Button button = null;

            for (int i = 0; i < pages.Count; i++)
            {
                button = new Button
                {
                    TextColor = Color.Black,
                    BorderColor = Color.Gray,
                    Text = nameTests[i],
                    BackgroundColor = Color.FromRgb(255, 229, 180)
                };

                ContentPage page = pages[i];
                button.Clicked += async (sender, args) => await Navigation.PushAsync(page);

                stackLayout.Children.Add(button);
            }


            button = new Button
            {
                Text = "Получить результаты тестов пациента",
                TextColor = Color.Black,
                BorderColor = Color.Gray,
                BackgroundColor = Color.FromRgb(128, 128, 128),
            };

            button.Clicked += (sender, args) => button_TestsPatient();

            stackLayout.Children.Add(button);
        }

        private void button_TestsPatient()
        {
            PatientData(App.patient);
        }

        private async void PatientData(Patient patient)
        {
            //var jsonString = JsonConvert.SerializeObject(patient);
            task = DisplayAlert("Данные о тестах", $" Пациент {patient.Forename} {patient.Surname} {patient.Patronymic}\n\n" +
                                $"•	Результат теста 'Оценка когнитивной сферы':\n      Общий результат {patient.resultMOSA.resultMOSATest}\n\n" +
                                $"•	Результат теста 'Шкала Вассермана':\n      Общий результат {patient.resultVasserman.TotalResultVasserman}\n\n" +
                                $"•	Результат теста 'Корректурная проба Бурдона':\n      Концентрация внимания = {patient.scoreBourdon.ConcentrationOfAtention}\n      Устойчивость внимания = {patient.scoreBourdon.AttentionSpan}\n\n" +
                                $"•	Результат теста 'Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса':\n      Общий результат {patient.resultPraxisAndGnosis.TotalResultPraxisAndGnosis}\n" +
                                $"      Результат моторного праксиса {patient.resultPraxisAndGnosis.resultMotorPraxis}\n      Результат динамического праксиса {patient.resultPraxisAndGnosis.resultDynamicPraxis}\n" +
                                $"      Результат конструктивного\n      праксиса {patient.resultPraxisAndGnosis.resultConstructivePraxis}\n      Результат объектного гнозиса {patient.resultPraxisAndGnosis.resultSubjectGnosis}\n" +
                                $"      Результат копирования часов {patient.resultPraxisAndGnosis.resultClock}\n\n" +
                                $"•	Результат теста 'Шкала тревоги и депрессии':\n      Общий результат тревоги {patient.resultAnxietyAndDepression.TotalResultAnxiety}\n      Общий результат депрессии {patient.resultAnxietyAndDepression.TotalResultDepression}\n\n" +
                                $"•	Результат теста 'Субъективная шкала оценки астении':\n      Общий результат {patient.scoreMFI20.TotalTestScore}\n      Балл за общую астению {patient.scoreMFI20.ScoreAnswerGeneralAsthenia}\n" +
                                $"      Балл за пониженную активность {patient.scoreMFI20.ScoreAnswerReducedActivity}\n      Балл за снижение мотивации {patient.scoreMFI20.ScoreAnswerDecreasedMotivation}\n" +
                                $"      Балл за физическую астению {patient.scoreMFI20.ScoreAnswerPhysicalAsthenia}\n      Балл за психическую астению {patient.scoreMFI20.ScoreAnswerMentalAsthenia}\n\n" +
                                $"•	Результат теста 'Европейский опросник качества жизни':\n      Общий результат {patient.resultLifeQuality.TotalResultLifeQuality}\n\n" +
                                $"•	Результат теста 'Шкала локуса-контроля':\n      Общий результат {patient.resultLocus.TotalResultLocus}\n\n",
                                "Ок");
            //Console.WriteLine($"{jsonString}");
            await task;
        }

    }
}
