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

            switch (Device.RuntimePlatform) {

                case Device.WPF:
                    button = new Button
                    {
                        Text = "Получить результаты тестов пациента",
                        TextColor = Color.Black,
                        BorderColor = Color.Gray,
                        BackgroundColor = Color.FromRgb(128, 128, 128),
                    };
                    button.Clicked += (sender, args) => button_TestsPatientWPF();
                    stackLayout.Children.Add(button);

                    button = new Button
                    {
                        Text = "Результаты covid-19 таблицы неврологические жалобы, головная боль, аффективные расстройства, системное проявление",
                        TextColor = Color.Black,
                        BorderColor = Color.Gray,
                        BackgroundColor = Color.FromRgb(128, 128, 128),
                    };
                    button.Clicked += (sender, args) => button_TestsPatientCOVIDPartOne();
                    stackLayout.Children.Add(button);

                    button = new Button
                    {
                        Text = "Результаты covid-19 таблицы сердечно-сосудистая система опорно-двигательная система, органы чувств",
                        TextColor = Color.Black,
                        BorderColor = Color.Gray,
                        BackgroundColor = Color.FromRgb(128, 128, 128),
                    };
                    button.Clicked += (sender, args) => button_TestsPatientCOVIDPartTwo();
                    stackLayout.Children.Add(button);

                    button = new Button
                    {
                        Text = "Результаты covid-19 таблицы дыхательная система, лор, желудочно-кишечный тракт, дерматологические проблемы",
                        TextColor = Color.Black,
                        BorderColor = Color.Gray,
                        BackgroundColor = Color.FromRgb(128, 128, 128),
                    };
                    button.Clicked += (sender, args) => button_TestsPatientCOVIDPartThree();
                    stackLayout.Children.Add(button);
                    break;

                default:
                    button = new Button
                    {
                        Text = "Получить результаты тестов пациента",
                        TextColor = Color.Black,
                        BorderColor = Color.Gray,
                        BackgroundColor = Color.FromRgb(128, 128, 128),
                    };
                    button.Clicked += (sender, args) => button_TestsPatient();
                    stackLayout.Children.Add(button);
                    break;
            }
        }

        private void button_TestsPatientWPF()
        {
            PatientDataWPF(App.patient);
        }

        private void button_TestsPatientCOVIDPartOne()
        {
            PatientDataWPFCOVIDPartOne(App.patient);
        }

        private void button_TestsPatientCOVIDPartTwo()
        {
            PatientDataWPFCOVIDPartTwo(App.patient);

        }

        private void button_TestsPatientCOVIDPartThree()
        {
            PatientDataWPFCOVIDPartThree(App.patient);

        }

        private void button_TestsPatient()
        {
           
            PatientData(App.patient);

        }

        private async void PatientData(Patient patient)
        {
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
                                $"•	Результат теста 'Шкала локуса-контроля':\n      Общий результат {patient.resultLocus.TotalResultLocus}\n\n" +
                                $"•	Таблица результатов теста на covid-19:\n\n" +
                                $"•	Неврологические жалобы:\n" +
                                $"Кратковременная потеря памяти\n1){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[0]}  2){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[1]}  3){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[2]}\n" +
                                $"Снижение памяти\n1){patient.resultCovidTest.TableEntriesDecreasedMemory[0]}  2){patient.resultCovidTest.TableEntriesDecreasedMemory[1]}  3){patient.resultCovidTest.TableEntriesDecreasedMemory[2]}\n" +
                                $"Снижение концентрации внимания, 'туман в мозгу'\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                $"Повышенная утомляемость\n1){patient.resultCovidTest.TableEntriesFatigue[0]}  2){patient.resultCovidTest.TableEntriesFatigue[1]}  3){patient.resultCovidTest.TableEntriesFatigue[2]}\n" +
                                $"Спутанность сознания\n1){patient.resultCovidTest.TableEntriesConfusion[0]}  2){patient.resultCovidTest.TableEntriesConfusion[1]}  3){patient.resultCovidTest.TableEntriesConfusion[2]}\n" +
                                $"Нарушение сна\n1){patient.resultCovidTest.TableEntriesSleepDisturbance[0]}  2){patient.resultCovidTest.TableEntriesSleepDisturbance[1]}  3){patient.resultCovidTest.TableEntriesSleepDisturbance[2]}\n" +
                                $"Проблемы с речью\n1){patient.resultCovidTest.TableEntriesSpeechProblems[0]}  2){patient.resultCovidTest.TableEntriesSpeechProblems[1]}  3){patient.resultCovidTest.TableEntriesSpeechProblems[2]}\n" +
                                $"•	Головная боль :\n" +
                                $"Изменение характера\n1){patient.resultCovidTest.TableEntriesChangeOfCharacter[0]}  2){patient.resultCovidTest.TableEntriesChangeOfCharacter[1]}  3){patient.resultCovidTest.TableEntriesChangeOfCharacter[2]}\n" +
                                $"Изменение частоты\n1){patient.resultCovidTest.TableEntriesFrequencyChange[0]}  2){patient.resultCovidTest.TableEntriesFrequencyChange[1]}  3){patient.resultCovidTest.TableEntriesFrequencyChange[2]}\n" +
                                $"Изменение интенсивности\n1){patient.resultCovidTest.TableEntriesIntensityChange[0]}  2){patient.resultCovidTest.TableEntriesIntensityChange[1]}  3){patient.resultCovidTest.TableEntriesIntensityChange[2]}\n" +
                                $"Перепады настроения\n1){patient.resultCovidTest.TableEntriesMoodSwings[0]}  2){patient.resultCovidTest.TableEntriesMoodSwings[1]}  3){patient.resultCovidTest.TableEntriesMoodSwings[2]}\n" +
                                $"•	Аффективные растройства:\n" +
                                $"Тревога\n1){patient.resultCovidTest.TableEntriesAnxiety[0]}  2){patient.resultCovidTest.TableEntriesAnxiety[1]}  3){patient.resultCovidTest.TableEntriesAnxiety[2]}\n" +
                                $"Депрессия\n1){patient.resultCovidTest.TableEntriesDepression[0]}  2){patient.resultCovidTest.TableEntriesDepression[1]}  3){patient.resultCovidTest.TableEntriesDepression[2]}\n" +
                                $"Навязчивые состояния\n1){patient.resultCovidTest.TableEntriesObsessiveStates[0]}  2){patient.resultCovidTest.TableEntriesObsessiveStates[1]} 3){patient.resultCovidTest.TableEntriesObsessiveStates[2]}\n" +
                                $"•	Системное проявление:\n" +
                                $"Лихорадка\n1){patient.resultCovidTest.TableEntriesFever[0]}  2){patient.resultCovidTest.TableEntriesFever[1]}  3){patient.resultCovidTest.TableEntriesFever[2]}\n" +
                                $"Повышенное потоотделение\n1){patient.resultCovidTest.TableEntriesIncreasedSweating[0]}  2){patient.resultCovidTest.TableEntriesIncreasedSweating[1]}  3){patient.resultCovidTest.TableEntriesIncreasedSweating[2]}\n" +
                                $"Ночная потливость\n1){patient.resultCovidTest.TableEntriesNightSweats[0]}  2){patient.resultCovidTest.TableEntriesNightSweats[1]}  3){patient.resultCovidTest.TableEntriesNightSweats[2]}\n" +
                                $"Непереносимость тепла\n1){patient.resultCovidTest.TableEntriesHeatIntolerance[0]}  2){patient.resultCovidTest.TableEntriesHeatIntolerance[1]}  3){patient.resultCovidTest.TableEntriesHeatIntolerance[2]}\n" +
                                $"•	Сердечно-сосудистая система:\n" +
                                $"Брадикардия\n1){patient.resultCovidTest.TableEntriesBradycardia[0]}  2){patient.resultCovidTest.TableEntriesBradycardia[1]}  3){patient.resultCovidTest.TableEntriesBradycardia[2]}\n" +
                                $"Тахикардия\n1){patient.resultCovidTest.TableEntriesTachycardia[0]}  2){patient.resultCovidTest.TableEntriesTachycardia[1]}  3){patient.resultCovidTest.TableEntriesTachycardia[2]}\n" +
                                $"Сердцебиение\n1){patient.resultCovidTest.TableEntriesHeartbeat[0]}  2){patient.resultCovidTest.TableEntriesHeartbeat[1]}  3){patient.resultCovidTest.TableEntriesHeartbeat[2]}\n" +
                                $"Подъемы АД\n1){patient.resultCovidTest.TableEntriesBPRises[0]}  2){patient.resultCovidTest.TableEntriesBPRises[1]}  3){patient.resultCovidTest.TableEntriesBPRises[2]}\n" +
                                $"Понижение АД\n1){patient.resultCovidTest.TableEntriesLoweringBloodPressure[0]}  2){patient.resultCovidTest.TableEntriesLoweringBloodPressure[1]}  3){patient.resultCovidTest.TableEntriesLoweringBloodPressure[2]}\n" +
                                $"Обморок\n1){patient.resultCovidTest.TableEntriesFainting[0]}  2){patient.resultCovidTest.TableEntriesFainting[1]}  3){patient.resultCovidTest.TableEntriesFainting[2]}\n" +
                                $"•	Опорно-двигательная система:\n" +
                                $"Боль в мышцах\n1){patient.resultCovidTest.TableEntriesMusclePain[0]}  2){patient.resultCovidTest.TableEntriesMusclePain[1]}  3){patient.resultCovidTest.TableEntriesMusclePain[2]}\n" +
                                $"Боль в суставах\n1){patient.resultCovidTest.TableEntriesJointPain[0]}  2){patient.resultCovidTest.TableEntriesJointPain[1]}  3){patient.resultCovidTest.TableEntriesJointPain[2]}\n" +
                                $"•	Органы чувств:\n" +
                                $"Головокружение\n1){patient.resultCovidTest.TableEntriesDizziness[0]}  2){patient.resultCovidTest.TableEntriesDizziness[1]}  3){patient.resultCovidTest.TableEntriesDizziness[2]}\n" +
                                $"Нарушение равновесия\n1){patient.resultCovidTest.TableEntriesImbalance[0]}  2){patient.resultCovidTest.TableEntriesImbalance[1]}  3){patient.resultCovidTest.TableEntriesImbalance[2]}\n" +
                                $"Нарушение зрения\n1){patient.resultCovidTest.TableEntriesVisualImpairment[0]}  2){patient.resultCovidTest.TableEntriesVisualImpairment[1]}  3){patient.resultCovidTest.TableEntriesVisualImpairment[2]}\n" +
                                $"Кожная гиперестезия\n1){patient.resultCovidTest.TableEntriesSkinHyperesthesia[0]}  2){patient.resultCovidTest.TableEntriesSkinHyperesthesia[1]}  3){patient.resultCovidTest.TableEntriesSkinHyperesthesia[2]}\n" +
                                $"Боль в конечностях\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                $"Онемение в конечностях\n1){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[0]}  2){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[1]}  3){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[2]}\n" +
                                $"Парестезии\n1){patient.resultCovidTest.TableEntriesParesthesia[0]}  2){patient.resultCovidTest.TableEntriesParesthesia[1]}  3){patient.resultCovidTest.TableEntriesParesthesia[2]}\n" +
                                $"Нарушения вкуса\n1){patient.resultCovidTest.TableEntriesTasteDisorders[0]}  2){patient.resultCovidTest.TableEntriesTasteDisorders[1]}  3){patient.resultCovidTest.TableEntriesTasteDisorders[2]}\n" +
                                $"Нарушения обоняния\n1){patient.resultCovidTest.TableEntriesOlfactoryDisorders[0]}  2){patient.resultCovidTest.TableEntriesOlfactoryDisorders[1]}  3){patient.resultCovidTest.TableEntriesOlfactoryDisorders[2]}\n" +
                                $"•	Дыхательная система:\n" +
                                $"Кашель\n1){patient.resultCovidTest.TableEntriesCough[0]}  2){patient.resultCovidTest.TableEntriesCough[1]}  3){patient.resultCovidTest.TableEntriesCough[2]}\n" +
                                $"Одышка\n1){patient.resultCovidTest.TableEntriesDyspnea[0]}  2){patient.resultCovidTest.TableEntriesDyspnea[1]}  3){patient.resultCovidTest.TableEntriesDyspnea[2]}\n" +
                                $"Стеснение в груди, боль в груди\n1){patient.resultCovidTest.TableEntriesChestPain[0]}  2){patient.resultCovidTest.TableEntriesChestPain[1]}  3){patient.resultCovidTest.TableEntriesChestPain[2]}\n" +
                                $"Учащенное сердцебиение\n1){patient.resultCovidTest.TableEntriesCardiopalmus[0]}  2){patient.resultCovidTest.TableEntriesCardiopalmus[1]}  3){patient.resultCovidTest.TableEntriesCardiopalmus[2]}\n" +
                                $"Анорексия, снижение аппетита\n1){patient.resultCovidTest.TableEntriesAnorexia[0]}  2){patient.resultCovidTest.TableEntriesAnorexia[1]}  3){patient.resultCovidTest.TableEntriesAnorexia[2]}\n" +
                                $"Судороги\n1){patient.resultCovidTest.TableEntriesConvulsions[0]}  2){patient.resultCovidTest.TableEntriesConvulsions[1]}  3){patient.resultCovidTest.TableEntriesConvulsions[2]}\n" +
                                $"•	Лор:\n" +
                                $"Боль в горле\n1){patient.resultCovidTest.TableEntriesSoreThroat[0]}  2){patient.resultCovidTest.TableEntriesSoreThroat[1]}  3){patient.resultCovidTest.TableEntriesSoreThroat[2]}\n" +
                                $"Шум в ушах\n1){patient.resultCovidTest.TableEntriesNoiseInEars[0]}  2){patient.resultCovidTest.TableEntriesNoiseInEars[1]}  3){patient.resultCovidTest.TableEntriesNoiseInEars[2]}\n" +
                                $"Ушная боль\n1){patient.resultCovidTest.TableEntriesEarAche[0]}  2){patient.resultCovidTest.TableEntriesEarAche[1]}  3){patient.resultCovidTest.TableEntriesEarAche[2]}\n" +
                                $"Заложенность носа\n1){patient.resultCovidTest.TableEntriesNasalCongestion[0]}  2){patient.resultCovidTest.TableEntriesNasalCongestion[1]}  3){patient.resultCovidTest.TableEntriesNasalCongestion[2]}\n" +
                                $"Боль и сухость носа\n1){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[0]}  2){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[1]}  3){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[2]}\n" +
                                $"•	Желудочно-кишечный тракт:\n" +
                                $"Боль в животе\n1){patient.resultCovidTest.TableEntriesAbdominalPain[0]}  2){patient.resultCovidTest.TableEntriesAbdominalPain[1]}  3){patient.resultCovidTest.TableEntriesAbdominalPain[2]}\n" +
                                $"Диарея\n1){patient.resultCovidTest.TableEntriesDiarrhea[0]}  2){patient.resultCovidTest.TableEntriesDiarrhea[1]}  3){patient.resultCovidTest.TableEntriesDiarrhea[2]}\n" +
                                $"Тошнота и рвота\n1){patient.resultCovidTest.TableEntriesNauseaAndVomiting[0]}  2){patient.resultCovidTest.TableEntriesNauseaAndVomiting[1]}  3){patient.resultCovidTest.TableEntriesNauseaAndVomiting[2]}\n" +
                                $"•	Дерматологические проблемы:\n" +
                                $"Выпадение волос\n1){patient.resultCovidTest.TableEntriesHairLoss[0]}  2){patient.resultCovidTest.TableEntriesHairLoss[1]}  3){patient.resultCovidTest.TableEntriesHairLoss[2]}\n" +
                                $"Кожные высыпания\n1){patient.resultCovidTest.TableEntriesSkinRashes[0]}  2){patient.resultCovidTest.TableEntriesSkinRashes[1]}  3){patient.resultCovidTest.TableEntriesSkinRashes[2]}\n",
                                "Ок");
            await task;
        }
        private async void PatientDataWPF(Patient patient)
        {
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
                               "Ok");
            await task;

        }

        private async void PatientDataWPFCOVIDPartOne(Patient patient)
        {
            task = DisplayAlert("Данные covid-19", $" Пациент {patient.Forename} {patient.Surname} {patient.Patronymic}\n\n" +
                                    $"•	Неврологические жалобы:\n" +
                                    $"Кратковременная потеря памяти\n1){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[0]}  2){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[1]}  3){patient.resultCovidTest.TableEntriesShortTermMemoryLoss[2]}\n" +
                                    $"Снижение памяти\n1){patient.resultCovidTest.TableEntriesDecreasedMemory[0]}  2){patient.resultCovidTest.TableEntriesDecreasedMemory[1]}  3){patient.resultCovidTest.TableEntriesDecreasedMemory[2]}\n" +
                                    $"Снижение концентрации внимания, 'туман в мозгу'\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                    $"Повышенная утомляемость\n1){patient.resultCovidTest.TableEntriesFatigue[0]}  2){patient.resultCovidTest.TableEntriesFatigue[1]}  3){patient.resultCovidTest.TableEntriesFatigue[2]}\n" +
                                    $"Спутанность сознания\n1){patient.resultCovidTest.TableEntriesConfusion[0]}  2){patient.resultCovidTest.TableEntriesConfusion[1]}  3){patient.resultCovidTest.TableEntriesConfusion[2]}\n" +
                                    $"Нарушение сна\n1){patient.resultCovidTest.TableEntriesSleepDisturbance[0]}  2){patient.resultCovidTest.TableEntriesSleepDisturbance[1]}  3){patient.resultCovidTest.TableEntriesSleepDisturbance[2]}\n" +
                                    $"Проблемы с речью\n1){patient.resultCovidTest.TableEntriesSpeechProblems[0]}  2){patient.resultCovidTest.TableEntriesSpeechProblems[1]}  3){patient.resultCovidTest.TableEntriesSpeechProblems[2]}\n"+
                                    $"•	Головная боль :\n" +
                                    $"Изменение характера\n1){patient.resultCovidTest.TableEntriesChangeOfCharacter[0]}  2){patient.resultCovidTest.TableEntriesChangeOfCharacter[1]}  3){patient.resultCovidTest.TableEntriesChangeOfCharacter[2]}\n" +
                                    $"Изменение частоты\n1){patient.resultCovidTest.TableEntriesFrequencyChange[0]}  2){patient.resultCovidTest.TableEntriesFrequencyChange[1]}  3){patient.resultCovidTest.TableEntriesFrequencyChange[2]}\n" +
                                    $"Изменение интенсивности\n1){patient.resultCovidTest.TableEntriesIntensityChange[0]}  2){patient.resultCovidTest.TableEntriesIntensityChange[1]}  3){patient.resultCovidTest.TableEntriesIntensityChange[2]}\n" +
                                    $"•	Аффективные растройства:\n" +
                                    $"Перепады настроения\n1){patient.resultCovidTest.TableEntriesMoodSwings[0]}  2){patient.resultCovidTest.TableEntriesMoodSwings[1]}  3){patient.resultCovidTest.TableEntriesMoodSwings[2]}\n" +
                                    $"Тревога\n1){patient.resultCovidTest.TableEntriesAnxiety[0]}  2){patient.resultCovidTest.TableEntriesAnxiety[1]}  3){patient.resultCovidTest.TableEntriesAnxiety[2]}\n" +
                                    $"Депрессия\n1){patient.resultCovidTest.TableEntriesDepression[0]}  2){patient.resultCovidTest.TableEntriesDepression[1]}  3){patient.resultCovidTest.TableEntriesDepression[2]}\n" +
                                    $"Навязчивые состояния\n1){patient.resultCovidTest.TableEntriesObsessiveStates[0]}  2){patient.resultCovidTest.TableEntriesObsessiveStates[1]} 3){patient.resultCovidTest.TableEntriesObsessiveStates[2]}\n" +
                                    $"•	Системное проявление:\n" +
                                    $"Лихорадка\n1){patient.resultCovidTest.TableEntriesFever[0]}  2){patient.resultCovidTest.TableEntriesFever[1]}  3){patient.resultCovidTest.TableEntriesFever[2]}\n" +
                                    $"Повышенное потоотделение\n1){patient.resultCovidTest.TableEntriesIncreasedSweating[0]}  2){patient.resultCovidTest.TableEntriesIncreasedSweating[1]}  3){patient.resultCovidTest.TableEntriesIncreasedSweating[2]}\n" +
                                    $"Ночная потливость\n1){patient.resultCovidTest.TableEntriesNightSweats[0]}  2){patient.resultCovidTest.TableEntriesNightSweats[1]}  3){patient.resultCovidTest.TableEntriesNightSweats[2]}\n" +
                                    $"Непереносимость тепла\n1){patient.resultCovidTest.TableEntriesHeatIntolerance[0]}  2){patient.resultCovidTest.TableEntriesHeatIntolerance[1]}  3){patient.resultCovidTest.TableEntriesHeatIntolerance[2]}\n",
                                    "Ok");
            await task;
        }

        private async void PatientDataWPFCOVIDPartTwo(Patient patient)
        {
            task = DisplayAlert("Данные covid-19", $" Пациент {patient.Forename} {patient.Surname} {patient.Patronymic}\n\n" +
                                    $"•	Сердечно-сосудистая система:\n" +
                                    $"Брадикардия\n1){patient.resultCovidTest.TableEntriesBradycardia[0]}  2){patient.resultCovidTest.TableEntriesBradycardia[1]}  3){patient.resultCovidTest.TableEntriesBradycardia[2]}\n" +
                                    $"Тахикардия\n1){patient.resultCovidTest.TableEntriesTachycardia[0]}  2){patient.resultCovidTest.TableEntriesTachycardia[1]}  3){patient.resultCovidTest.TableEntriesTachycardia[2]}\n" +
                                    $"Сердцебиение\n1){patient.resultCovidTest.TableEntriesHeartbeat[0]}  2){patient.resultCovidTest.TableEntriesHeartbeat[1]}  3){patient.resultCovidTest.TableEntriesHeartbeat[2]}\n" +
                                    $"Подъемы АД\n1){patient.resultCovidTest.TableEntriesBPRises[0]}  2){patient.resultCovidTest.TableEntriesBPRises[1]}  3){patient.resultCovidTest.TableEntriesBPRises[2]}\n" +
                                    $"Понижение АД\n1){patient.resultCovidTest.TableEntriesLoweringBloodPressure[0]}  2){patient.resultCovidTest.TableEntriesLoweringBloodPressure[1]}  3){patient.resultCovidTest.TableEntriesLoweringBloodPressure[2]}\n" +
                                    $"Обморок\n1){patient.resultCovidTest.TableEntriesFainting[0]}  2){patient.resultCovidTest.TableEntriesFainting[1]}  3){patient.resultCovidTest.TableEntriesFainting[2]}\n" +
                                    $"•	Опорно-двигательная система:\n" +
                                    $"Боль в мышцах\n1){patient.resultCovidTest.TableEntriesMusclePain[0]}  2){patient.resultCovidTest.TableEntriesMusclePain[1]}  3){patient.resultCovidTest.TableEntriesMusclePain[2]}\n" +
                                    $"Боль в суставах\n1){patient.resultCovidTest.TableEntriesJointPain[0]}  2){patient.resultCovidTest.TableEntriesJointPain[1]}  3){patient.resultCovidTest.TableEntriesJointPain[2]}\n" +
                                    $"•	Органы чувств:\n" + 
                                    $"Головокружение\n1){patient.resultCovidTest.TableEntriesDizziness[0]}  2){patient.resultCovidTest.TableEntriesDizziness[1]}  3){patient.resultCovidTest.TableEntriesDizziness[2]}\n" +
                                    $"Нарушение равновесия\n1){patient.resultCovidTest.TableEntriesImbalance[0]}  2){patient.resultCovidTest.TableEntriesImbalance[1]}  3){patient.resultCovidTest.TableEntriesImbalance[2]}\n" +
                                    $"Нарушение зрения\n1){patient.resultCovidTest.TableEntriesVisualImpairment[0]}  2){patient.resultCovidTest.TableEntriesVisualImpairment[1]}  3){patient.resultCovidTest.TableEntriesVisualImpairment[2]}\n" +
                                    $"Кожная гиперестезия\n1){patient.resultCovidTest.TableEntriesSkinHyperesthesia[0]}  2){patient.resultCovidTest.TableEntriesSkinHyperesthesia[1]}  3){patient.resultCovidTest.TableEntriesSkinHyperesthesia[2]}\n" +
                                    $"Боль в конечностях\n1){patient.resultCovidTest.TableEntriesDecreasedConcentration[0]}  2){patient.resultCovidTest.TableEntriesDecreasedConcentration[1]}  3){patient.resultCovidTest.TableEntriesDecreasedConcentration[2]}\n" +
                                    $"Онемение в конечностях\n1){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[0]}  2){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[1]}  3){patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[2]}\n" +
                                    $"Парестезии\n1){patient.resultCovidTest.TableEntriesParesthesia[0]}  2){patient.resultCovidTest.TableEntriesParesthesia[1]}  3){patient.resultCovidTest.TableEntriesParesthesia[2]}\n" +
                                    $"Нарушения вкуса\n1){patient.resultCovidTest.TableEntriesTasteDisorders[0]}  2){patient.resultCovidTest.TableEntriesTasteDisorders[1]}  3){patient.resultCovidTest.TableEntriesTasteDisorders[2]}\n" +
                                    $"Нарушения обоняния\n1){patient.resultCovidTest.TableEntriesOlfactoryDisorders[0]}  2){patient.resultCovidTest.TableEntriesOlfactoryDisorders[1]}  3){patient.resultCovidTest.TableEntriesOlfactoryDisorders[2]}\n",
                                    "Ok");
            await task;
        }
        private async void PatientDataWPFCOVIDPartThree(Patient patient)
        {
            task = DisplayAlert("Данные covid-19", $" Пациент {patient.Forename} {patient.Surname} {patient.Patronymic}\n\n" +
                                    $"•	Дыхательная система:\n" +
                                    $"Кашель\n1){patient.resultCovidTest.TableEntriesCough[0]}  2){patient.resultCovidTest.TableEntriesCough[1]}  3){patient.resultCovidTest.TableEntriesCough[2]}\n" +
                                    $"Одышка\n1){patient.resultCovidTest.TableEntriesDyspnea[0]}  2){patient.resultCovidTest.TableEntriesDyspnea[1]}  3){patient.resultCovidTest.TableEntriesDyspnea[2]}\n" +
                                    $"Стеснение в груди, боль в груди\n1){patient.resultCovidTest.TableEntriesChestPain[0]}  2){patient.resultCovidTest.TableEntriesChestPain[1]}  3){patient.resultCovidTest.TableEntriesChestPain[2]}\n" +
                                    $"Учащенное сердцебиение\n1){patient.resultCovidTest.TableEntriesCardiopalmus[0]}  2){patient.resultCovidTest.TableEntriesCardiopalmus[1]}  3){patient.resultCovidTest.TableEntriesCardiopalmus[2]}\n" +
                                    $"Анорексия, снижение аппетита\n1){patient.resultCovidTest.TableEntriesAnorexia[0]}  2){patient.resultCovidTest.TableEntriesAnorexia[1]}  3){patient.resultCovidTest.TableEntriesAnorexia[2]}\n" +
                                    $"Судороги\n1){patient.resultCovidTest.TableEntriesConvulsions[0]}  2){patient.resultCovidTest.TableEntriesConvulsions[1]}  3){patient.resultCovidTest.TableEntriesConvulsions[2]}\n" +
                                    $"•	Лор:\n" +
                                    $"Боль в горле\n1){patient.resultCovidTest.TableEntriesSoreThroat[0]}  2){patient.resultCovidTest.TableEntriesSoreThroat[1]}  3){patient.resultCovidTest.TableEntriesSoreThroat[2]}\n" +
                                    $"Шум в ушах\n1){patient.resultCovidTest.TableEntriesNoiseInEars[0]}  2){patient.resultCovidTest.TableEntriesNoiseInEars[1]}  3){patient.resultCovidTest.TableEntriesNoiseInEars[2]}\n" +
                                    $"Ушная боль\n1){patient.resultCovidTest.TableEntriesEarAche[0]}  2){patient.resultCovidTest.TableEntriesEarAche[1]}  3){patient.resultCovidTest.TableEntriesEarAche[2]}\n" +
                                    $"Заложенность носа\n1){patient.resultCovidTest.TableEntriesNasalCongestion[0]}  2){patient.resultCovidTest.TableEntriesNasalCongestion[1]}  3){patient.resultCovidTest.TableEntriesNasalCongestion[2]}\n" +
                                    $"Боль и сухость носа\n1){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[0]}  2){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[1]}  3){patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[2]}\n" +
                                    $"•	Желудочно-кишечный тракт:\n" +
                                    $"Боль в животе\n1){patient.resultCovidTest.TableEntriesAbdominalPain[0]}  2){patient.resultCovidTest.TableEntriesAbdominalPain[1]}  3){patient.resultCovidTest.TableEntriesAbdominalPain[2]}\n" +
                                    $"Диарея\n1){patient.resultCovidTest.TableEntriesDiarrhea[0]}  2){patient.resultCovidTest.TableEntriesDiarrhea[1]}  3){patient.resultCovidTest.TableEntriesDiarrhea[2]}\n" +
                                    $"Тошнота и рвота\n1){patient.resultCovidTest.TableEntriesNauseaAndVomiting[0]}  2){patient.resultCovidTest.TableEntriesNauseaAndVomiting[1]}  3){patient.resultCovidTest.TableEntriesNauseaAndVomiting[2]}\n" +
                                    $"•	Дерматологические проблемы:\n" +
                                    $"Выпадение волос\n1){patient.resultCovidTest.TableEntriesHairLoss[0]}  2){patient.resultCovidTest.TableEntriesHairLoss[1]}  3){patient.resultCovidTest.TableEntriesHairLoss[2]}\n" +
                                    $"Кожные высыпания\n1){patient.resultCovidTest.TableEntriesSkinRashes[0]}  2){patient.resultCovidTest.TableEntriesSkinRashes[1]}  3){patient.resultCovidTest.TableEntriesSkinRashes[2]}\n",
                                    "Ok");
            await task;
        }
    }
}
