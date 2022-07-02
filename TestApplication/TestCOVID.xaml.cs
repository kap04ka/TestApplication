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
    public partial class TestCOVID : ContentPage
    {
        /// <summary>
        /// Ответы пациента на пол
        /// </summary>
        private bool[] answerGender;
        /// <summary>
        /// Ответы пациента на образование
        /// </summary>
        private bool[] answerEducation;
        /// <summary>
        /// Ответы пациента на деятельность
        /// </summary>
        private bool[] answerActivity;
        /// <summary>
        /// Ответы пациента на заболевания
        /// </summary>
        private bool[] answerDiseases;
        /// <summary>
        /// Ответы пациента на трудоспособность
        /// </summary>
        private bool[] answerAbilityToWork;
        /// <summary>
        /// Ответы пациента на работоспособность по дому
        /// </summary>
        private bool[] answerWorkAtHome;
        /// <summary>
        /// Ответы пациента на работоспособность по досуговой активности
        /// </summary>
        private bool[] answerLeisureActivities;

        /// <summary>
        /// Список вариатов для ответа на пол
        /// </summary>
        private List<string> answerTestGender;
        /// <summary>
        /// Список вариатов для ответа на образование
        /// </summary>
        private List<string> answerTestEducation;
        /// <summary>
        /// Список вариатов для ответа на деятельность
        /// </summary>
        private List<string> answerTestActivity;
        /// <summary>
        /// Список вариатов для ответа на заболевания
        /// </summary>
        private List<string> answerTestDiseases;
        /// <summary>
        /// Список вариатов для ответа на трудоспособность
        /// </summary>
        private List<string> answerTestAbilityToWork;
        /// <summary>
        /// Список вариатов для ответа на работоспособность по дому
        /// </summary>
        private List<string> answerTestWorkAtHome;
        /// <summary>
        /// Список вариатов для ответа на досуговая активность
        /// </summary>
        private List<string> answerTestLeisureActivities;

        public TestCOVID()
        {
            InitializeComponent();

            answerGender = new bool[2];
            answerEducation = new bool[5];
            answerActivity = new bool[6];
            answerDiseases = new bool[10];
            answerAbilityToWork = new bool[3];
            answerWorkAtHome = new bool[3];
            answerLeisureActivities = new bool[3];

            answerTestGender = new List<string>() { "Мужской", "Женский" };
            answerTestEducation = new List<string>()
            {
                "Начальная школа", "Неполное среднее общее образование",
                "Полное среднее общее образование", "Среднее профессиональное образование",
                "Высшее образование"
            };
            answerTestActivity = new List<string>()
            {
                "Нетрудоспособен/нетрудоспособна (инвалидность)", "Домохозяин/домохозяйка",
                "На пенсии", "Студент/ студентка",
                "Не работаю/ ищу работу", "Работаю"
            };
            answerTestDiseases = new List<string>()
            {
                "Заболевания легких (например, астма, эмфизема или бронхит)", "Заболевания сердца",
                "Хронические заболевания почек", "Заболевания печени (например, гепатит)",
                "Диабет", "Высокое артериальное давление",
                "Нарушение ритма сердца (мерцательная аритмия)",
                "Проблемы с селезенкой (например, серповидно-клеточная болезнь или если вам удалили селезенку)",
                "Ослабленная иммунная система в результате заболевания, такого как ВИЧ или СПИД, или лекарств, таких как стероидные таблетки или химиотерапия",
                "Ни одно из вышеперечисленных"
            };
            answerTestAbilityToWork = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };
            answerTestWorkAtHome = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };
            answerTestLeisureActivities = new List<string>()
            {
                "Cнизилась", "Не изменилась", "Повысилась"
            };

            FillingOutTheTest();

            
        }
        private async void buttonMainMenu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        /// <summary>
        /// Заполнение вариентов для выбора в тесте
        /// </summary>
        private void FillingOutTheTest()
        {
            labelGender1.Text = answerTestGender[0];
            labelGender2.Text = answerTestGender[1];

            labelEducation1.Text = answerTestEducation[0];
            labelEducation2.Text = answerTestEducation[1];
            labelEducation3.Text = answerTestEducation[2];
            labelEducation4.Text = answerTestEducation[3];
            labelEducation5.Text = answerTestEducation[4];

            labelActivity1.Text = answerTestActivity[0];
            labelActivity2.Text = answerTestActivity[1];
            labelActivity3.Text = answerTestActivity[2];
            labelActivity4.Text = answerTestActivity[3];
            labelActivity5.Text = answerTestActivity[4];
            labelActivity6.Text = answerTestActivity[5];

            labelDiseases1.Text = answerTestDiseases[0];
            labelDiseases2.Text = answerTestDiseases[1];
            labelDiseases3.Text = answerTestDiseases[2];
            labelDiseases4.Text = answerTestDiseases[3];
            labelDiseases5.Text = answerTestDiseases[4];
            labelDiseases6.Text = answerTestDiseases[5];
            labelDiseases7.Text = answerTestDiseases[6];
            labelDiseases8.Text = answerTestDiseases[7];
            labelDiseases9.Text = answerTestDiseases[8];
            labelDiseases10.Text = answerTestDiseases[9];

            labelAbilityToWork1.Text = answerTestAbilityToWork[0];
            labelAbilityToWork2.Text = answerTestAbilityToWork[1];
            labelAbilityToWork3.Text = answerTestAbilityToWork[2];

            labelPerformance1.Text = answerTestWorkAtHome[0];
            labelPerformance2.Text = answerTestWorkAtHome[1];
            labelPerformance3.Text = answerTestWorkAtHome[2];

            labelLeisure1.Text = answerTestLeisureActivities[0];
            labelLeisure2.Text = answerTestLeisureActivities[1];
            labelLeisure3.Text = answerTestLeisureActivities[2];
        }


        /// <summary>
        /// Обработка изменения ползунка
        /// </summary>
        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == sliderAbilityToWork)
            {
                labelAbilityToWork.Text = String.Format("На {0:F0}", e.NewValue);
                App.patient.resultCovidTest.WorkCapacityAssessment = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderPerformance)
            {
                labelPerformance.Text = String.Format("На {0:F0}", e.NewValue);
                App.patient.resultCovidTest.PerformanceEvaluation = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
            if (sender == sliderLeisure)
            {
                labelLeisure.Text = String.Format("На {0:F0}", e.NewValue);
                App.patient.resultCovidTest.LeisureEvaluation = int.Parse(String.Format("{0:F0}", e.NewValue));
            }
        }


        /// <summary>
        /// Обработчик сохранения результатов
        /// </summary>
        private async void buttonSaveData_Clicked(object sender, EventArgs e)
        {
            //пациент пропустил пункт
            if (CheckEmptyValue())
            {
                await DisplayAlert("Ошибка", "Введите все требуемые данные", "ОК");
            }
            //пациент ввел все данные
            else
            {
                SaveData();
                WriteAnswersForDatabase();
                await DisplayAlert("Сохранение", "Данные теста сохранились", "ОК");
                await Navigation.PopAsync();
            }
        }


        private void WriteAnswersForDatabase()
        {
            App.patient.resultCovidTest.EntriesShortTermMemoryLoss = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss.Length; i++) 
            {
                App.patient.resultCovidTest.EntriesShortTermMemoryLoss += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDecreasedMemory = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDecreasedMemory.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDecreasedMemory += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDecreasedMemory[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDecreasedConcentration = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDecreasedConcentration.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDecreasedConcentration += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDecreasedConcentration[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesFatigue = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesFatigue.Length; i++)
            {
                App.patient.resultCovidTest.EntriesFatigue += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesFatigue[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesConfusion = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesConfusion.Length; i++)
            {
                App.patient.resultCovidTest.EntriesConfusion += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesConfusion[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesSleepDisturbance = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesSleepDisturbance.Length; i++)
            {
                App.patient.resultCovidTest.EntriesSleepDisturbance += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesSleepDisturbance[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesSpeechProblems = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesSpeechProblems.Length; i++)
            {
                App.patient.resultCovidTest.EntriesSpeechProblems += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesSpeechProblems[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesChangeOfCharacter = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesChangeOfCharacter.Length; i++)
            {
                App.patient.resultCovidTest.EntriesChangeOfCharacter += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesChangeOfCharacter[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesFrequencyChange = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesFrequencyChange.Length; i++)
            {
                App.patient.resultCovidTest.EntriesFrequencyChange += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesFrequencyChange[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesIntensityChange = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesIntensityChange.Length; i++)
            {
                App.patient.resultCovidTest.EntriesIntensityChange += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesIntensityChange[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesMoodSwings = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesMoodSwings.Length; i++)
            {
                App.patient.resultCovidTest.EntriesMoodSwings += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesMoodSwings[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesAnxiety = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesAnxiety.Length; i++)
            {
                App.patient.resultCovidTest.EntriesAnxiety += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesAnxiety[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDepression = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDepression.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDepression += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDepression[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesObsessiveStates = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesObsessiveStates.Length; i++)
            {
                App.patient.resultCovidTest.EntriesObsessiveStates += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesObsessiveStates[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesFever = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesFever.Length; i++)
            {
                App.patient.resultCovidTest.EntriesFever += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesFever[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesIncreasedSweating = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesIncreasedSweating.Length; i++)
            {
                App.patient.resultCovidTest.EntriesIncreasedSweating += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesIncreasedSweating[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesNightSweats = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesNightSweats.Length; i++)
            {
                App.patient.resultCovidTest.EntriesNightSweats += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesNightSweats[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesHeatIntolerance = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesHeatIntolerance.Length; i++)
            {
                App.patient.resultCovidTest.EntriesHeatIntolerance += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesHeatIntolerance[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesBradycardia = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesBradycardia.Length; i++)
            {
                App.patient.resultCovidTest.EntriesBradycardia += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesBradycardia[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesTachycardia = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesTachycardia.Length; i++)
            {
                App.patient.resultCovidTest.EntriesTachycardia += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesTachycardia[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesHeartbeat = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesHeartbeat.Length; i++)
            {
                App.patient.resultCovidTest.EntriesHeartbeat += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesHeartbeat[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesBPRises = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesBPRises.Length; i++)
            {
                App.patient.resultCovidTest.EntriesBPRises += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesBPRises[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesLoweringBloodPressure = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesLoweringBloodPressure.Length; i++)
            {
                App.patient.resultCovidTest.EntriesLoweringBloodPressure += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesFainting = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesFainting.Length; i++)
            {
                App.patient.resultCovidTest.EntriesFainting += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesFainting[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesMusclePain = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesMusclePain.Length; i++)
            {
                App.patient.resultCovidTest.EntriesMusclePain += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesMusclePain[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesJointPain = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesJointPain.Length; i++)
            {
                App.patient.resultCovidTest.EntriesJointPain += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesJointPain[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDizziness = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDizziness.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDizziness += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDizziness[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesImbalance = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesImbalance.Length; i++)
            {
                App.patient.resultCovidTest.EntriesImbalance += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesImbalance[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesVisualImpairment = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesVisualImpairment.Length; i++)
            {
                App.patient.resultCovidTest.EntriesVisualImpairment += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesVisualImpairment[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesSkinHyperesthesia = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesSkinHyperesthesia.Length; i++)
            {
                App.patient.resultCovidTest.EntriesSkinHyperesthesia += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesPainInTheLimbs = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesPainInTheLimbs.Length; i++)
            {
                App.patient.resultCovidTest.EntriesPainInTheLimbs += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesPainInTheLimbs[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesNumbnessInTheLimbs = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs.Length; i++)
            {
                App.patient.resultCovidTest.EntriesNumbnessInTheLimbs += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesParesthesia = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesParesthesia.Length; i++)
            {
                App.patient.resultCovidTest.EntriesParesthesia += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesParesthesia[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesTasteDisorders = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesTasteDisorders.Length; i++)
            {
                App.patient.resultCovidTest.EntriesTasteDisorders += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesTasteDisorders[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesOlfactoryDisorders = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesOlfactoryDisorders.Length; i++)
            {
                App.patient.resultCovidTest.EntriesOlfactoryDisorders += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesCough = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesCough.Length; i++)
            {
                App.patient.resultCovidTest.EntriesCough += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesCough[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDyspnea = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDyspnea.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDyspnea += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDyspnea[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesChestPain = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesChestPain.Length; i++)
            {
                App.patient.resultCovidTest.EntriesChestPain += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesChestPain[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesCardiopalmus = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesCardiopalmus.Length; i++)
            {
                App.patient.resultCovidTest.EntriesCardiopalmus += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesCardiopalmus[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesAnorexia = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesAnorexia.Length; i++)
            {
                App.patient.resultCovidTest.EntriesAnorexia += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesAnorexia[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesConvulsions = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesConvulsions.Length; i++)
            {
                App.patient.resultCovidTest.EntriesConvulsions += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesConvulsions[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesSoreThroat = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesSoreThroat.Length; i++)
            {
                App.patient.resultCovidTest.EntriesSoreThroat += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesSoreThroat[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesNoiseInEars = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesNoiseInEars.Length; i++)
            {
                App.patient.resultCovidTest.EntriesNoiseInEars += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesNoiseInEars[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesEarAche = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesEarAche.Length; i++)
            {
                App.patient.resultCovidTest.EntriesEarAche += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesEarAche[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesNasalCongestion = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesNasalCongestion.Length; i++)
            {
                App.patient.resultCovidTest.EntriesNasalCongestion += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesNasalCongestion[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesPainAndDrynessOfTheNose = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose.Length; i++)
            {
                App.patient.resultCovidTest.EntriesPainAndDrynessOfTheNose += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesAbdominalPain = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesAbdominalPain.Length; i++)
            {
                App.patient.resultCovidTest.EntriesAbdominalPain += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesAbdominalPain[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesDiarrhea = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesDiarrhea.Length; i++)
            {
                App.patient.resultCovidTest.EntriesDiarrhea += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesDiarrhea[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesNauseaAndVomiting = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesNauseaAndVomiting.Length; i++)
            {
                App.patient.resultCovidTest.EntriesNauseaAndVomiting += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesHairLoss = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesHairLoss.Length; i++)
            {
                App.patient.resultCovidTest.EntriesHairLoss += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesHairLoss[i]) + "\n";
            }

            App.patient.resultCovidTest.EntriesSkinRashes = "";
            for (int i = 0; i < App.patient.resultCovidTest.TableEntriesSkinRashes.Length; i++)
            {
                App.patient.resultCovidTest.EntriesSkinRashes += ((i + 1).ToString() + ") " + App.patient.resultCovidTest.TableEntriesSkinRashes[i]) + "\n";
            }
        }


        /// <summary>
        /// Проверка на отсутствие ответов на вопросы
        /// </summary>
        /// <returns>True если ответа нет</returns>
        private bool CheckEmptyValue()
        {
            if (answerGender[0] == false && answerGender[1] == false ||
                answerEducation[0] == false && answerEducation[1] == false && answerEducation[2] == false &&
                answerEducation[3] == false && answerEducation[4] == false ||
                answerActivity[0] == false && answerActivity[1] == false && answerActivity[2] == false &&
                answerActivity[3] == false && answerActivity[4] == false && answerActivity[5] == false ||
                answerDiseases[0] == false && answerDiseases[1] == false && answerDiseases[2] == false &&
                answerDiseases[3] == false && answerDiseases[4] == false && answerDiseases[5] == false &&
                answerDiseases[6] == false && answerDiseases[7] == false &&
                answerDiseases[8] == false && answerDiseases[9] == false ||
                answerAbilityToWork[0] == false && answerAbilityToWork[1] == false && answerAbilityToWork[2] == false ||
                answerWorkAtHome[0] == false && answerWorkAtHome[1] == false && answerWorkAtHome[2] == false ||
                answerLeisureActivities[0] == false && answerLeisureActivities[1] == false && answerLeisureActivities[2] == false ||
                App.patient.resultCovidTest.WorkCapacityAssessment == 0 || 
                App.patient.resultCovidTest.PerformanceEvaluation == 0 ||
                App.patient.resultCovidTest.LeisureEvaluation == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Сброс check box в исходное состояние
        /// </summary>
        /// <param name="arrayCheckBoxAnswers">Массив ответов на вопрос</param>
        /// <param name="index">Индекс ответа, который необходимо пропустить</param>
        private void ResetOthersCheckBoxAnswers(bool[] arrayCheckBoxAnswers, int index)
        {
            for (int i = 0; i < arrayCheckBoxAnswers.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                arrayCheckBoxAnswers[i] = false;
            }
        }


        /// <summary>
        /// Сохранение вводимых данных
        /// </summary>
        private void SaveData()
        {
            App.patient.resultCovidTest.GenderPatient = SaveAnswer(answerGender, answerTestGender);
            App.patient.resultCovidTest.EducationPatient = SaveAnswer(answerEducation, answerTestEducation);
            App.patient.resultCovidTest.ActivityPatient = SaveAnswers(answerActivity, answerTestActivity);
            App.patient.resultCovidTest.DiseasesPatient = SaveAnswers(answerDiseases, answerTestDiseases);
            App.patient.resultCovidTest.AbilityToWorkPatient = SaveAnswer(answerAbilityToWork, answerTestAbilityToWork);
            App.patient.resultCovidTest.WorkAtHomePatient = SaveAnswer(answerWorkAtHome, answerTestWorkAtHome);
            App.patient.resultCovidTest.LeisureActivitiesPatient = SaveAnswer(answerLeisureActivities, answerTestLeisureActivities);
        }


        /// <summary>
        /// Сохранение ответа на вопрос в переменную
        /// </summary>
        /// <param name="arrayAnswers">Массив ответов на определенный вопрос</param>
        /// <param name="listChoiceAnswers">Список ответов на выбор</param>
        /// <returns>Строковое представление результата</returns>
        private string SaveAnswer(bool[] arrayAnswers, List<string> listChoiceAnswers)
        {
            string resultAnswer = "";

            for (int i = 0; i < arrayAnswers.Length; i++)
            {
                if (arrayAnswers[i] == true)
                {
                    resultAnswer = listChoiceAnswers[i];
                    break;
                }
            }

            return resultAnswer;
        }


        /// <summary>
        /// Сохранение ответов на вопрос в переменную
        /// </summary>
        /// <param name="arrayAnswers">Массив ответов на определенный вопрос</param>
        /// <param name="listChoiceAnswers">Список ответов на выбор</param>
        /// <returns>Строковое представление результата</returns>
        private string SaveAnswers(bool[] arrayAnswers, List<string> listChoiceAnswers)
        {
            int[] resultArray = arrayAnswers.
                Select((value, index) => new { Item = value, Index = index }).
                Where(n => n.Item == true).
                Select(n => n.Index).ToArray();

            string resultAnswers = "";

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i == resultArray.Length - 1)
                {
                    resultAnswers += listChoiceAnswers[resultArray[i]];
                }
                else
                {
                    resultAnswers += listChoiceAnswers[resultArray[i]];
                    resultAnswers += ", ";
                }
            }

            return resultAnswers;
        }



        /// <summary>
        /// Обработчик ответов на вопросы гендера
        /// </summary>
        private void checkBoxGender_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxGender1)
            {
                answerGender[0] = checkBoxGender1.IsChecked;

                if (answerGender[0] == true)
                {
                    ResetOthersCheckBoxAnswers(answerGender, 0);
                    checkBoxGender2.IsChecked = false;
                }
            }
            if (sender == checkBoxGender2)
            {
                answerGender[1] = checkBoxGender2.IsChecked;

                if (answerGender[1] == true)
                {
                    ResetOthersCheckBoxAnswers(answerGender, 1);
                    checkBoxGender1.IsChecked = false;
                }
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы образования
        /// </summary>
        private void checkBoxEducation_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxEducation1)
            {
                answerEducation[0] = checkBoxEducation1.IsChecked;

                if (answerEducation[0] == true)
                {
                    ResetOthersCheckBoxAnswers(answerEducation, 0);
                    checkBoxEducation2.IsChecked = false;
                    checkBoxEducation3.IsChecked = false;
                    checkBoxEducation4.IsChecked = false;
                    checkBoxEducation5.IsChecked = false;
                }
            }
            if (sender == checkBoxEducation2)
            {
                answerEducation[1] = checkBoxEducation2.IsChecked;

                if (answerEducation[1] == true)
                {
                    ResetOthersCheckBoxAnswers(answerEducation, 1);
                    checkBoxEducation1.IsChecked = false;
                    checkBoxEducation3.IsChecked = false;
                    checkBoxEducation4.IsChecked = false;
                    checkBoxEducation5.IsChecked = false;
                }
            }
            if (sender == checkBoxEducation3)
            {
                answerEducation[2] = checkBoxEducation3.IsChecked;

                if (answerEducation[2] == true)
                {
                    ResetOthersCheckBoxAnswers(answerEducation, 2);
                    checkBoxEducation2.IsChecked = false;
                    checkBoxEducation1.IsChecked = false;
                    checkBoxEducation4.IsChecked = false;
                    checkBoxEducation5.IsChecked = false;
                }
            }
            if (sender == checkBoxEducation4)
            {
                answerEducation[3] = checkBoxEducation4.IsChecked;

                if (answerEducation[3] == true)
                {
                    ResetOthersCheckBoxAnswers(answerEducation, 3);
                    checkBoxEducation2.IsChecked = false;
                    checkBoxEducation3.IsChecked = false;
                    checkBoxEducation1.IsChecked = false;
                    checkBoxEducation5.IsChecked = false;
                }
            }
            if (sender == checkBoxEducation5)
            {
                answerEducation[4] = checkBoxEducation5.IsChecked;

                if (answerEducation[4] == true)
                {
                    ResetOthersCheckBoxAnswers(answerEducation, 4);
                    checkBoxEducation2.IsChecked = false;
                    checkBoxEducation3.IsChecked = false;
                    checkBoxEducation4.IsChecked = false;
                    checkBoxEducation1.IsChecked = false;
                }
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кратковременная потеря памяти
        /// </summary>
        private void editorShortTermMemoryLoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorShortTermMemoryLoss1)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[0] = editorShortTermMemoryLoss1.Text;
            }
            if (sender == editorShortTermMemoryLoss2)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[1] = editorShortTermMemoryLoss2.Text;
            }
            if (sender == editorShortTermMemoryLoss3)
            {
                App.patient.resultCovidTest.TableEntriesShortTermMemoryLoss[2] = editorShortTermMemoryLoss3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Снижение памяти
        /// </summary>
        private void editorDecreasedMemory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDecreasedMemory1)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[0] = editorDecreasedMemory1.Text;
            }
            if (sender == editorDecreasedMemory2)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[1] = editorDecreasedMemory2.Text;
            }
            if (sender == editorDecreasedMemory3)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedMemory[2] = editorDecreasedMemory3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Снижение концентрации внимания, "туман в мозгу"
        /// </summary>
        private void editorDecreasedConcentration_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDecreasedConcentration1)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[0] = editorDecreasedConcentration1.Text;
            }
            if (sender == editorDecreasedConcentration2)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[1] = editorDecreasedConcentration2.Text;
            }
            if (sender == editorDecreasedConcentration3)
            {
                App.patient.resultCovidTest.TableEntriesDecreasedConcentration[2] = editorDecreasedConcentration3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Повышенная утомляемость
        /// </summary>
        private void editorFatigue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFatigue1)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[0] = editorFatigue1.Text;
            }
            if (sender == editorFatigue2)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[1] = editorFatigue2.Text;
            }
            if (sender == editorFatigue3)
            {
                App.patient.resultCovidTest.TableEntriesFatigue[2] = editorFatigue3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Спутанность сознания
        /// </summary>
        private void editorConfusion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorConfusion1)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[0] = editorConfusion1.Text;
            }
            if (sender == editorConfusion2)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[1] = editorConfusion2.Text;
            }
            if (sender == editorConfusion3)
            {
                App.patient.resultCovidTest.TableEntriesConfusion[2] = editorConfusion3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение сна (патологическое бодрствование, бессонница)
        /// </summary>
        private void editorSleepDisturbance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSleepDisturbance1)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[0] = editorSleepDisturbance1.Text;
            }
            if (sender == editorSleepDisturbance2)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[1] = editorSleepDisturbance2.Text;
            }
            if (sender == editorSleepDisturbance3)
            {
                App.patient.resultCovidTest.TableEntriesSleepDisturbance[2] = editorSleepDisturbance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Проблемы с речью (подбор слов или произношение) 
        /// </summary>
        private void editorSpeechProblems_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSpeechProblems1)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[0] = editorSpeechProblems1.Text;
            }
            if (sender == editorSpeechProblems2)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[1] = editorSpeechProblems2.Text;
            }
            if (sender == editorSpeechProblems3)
            {
                App.patient.resultCovidTest.TableEntriesSpeechProblems[2] = editorSpeechProblems3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение характера
        /// </summary>
        private void editorChangeOfCharacter_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorChangeOfCharacter1)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[0] = editorChangeOfCharacter1.Text;
            }
            if (sender == editorChangeOfCharacter2)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[1] = editorChangeOfCharacter2.Text;
            }
            if (sender == editorChangeOfCharacter3)
            {
                App.patient.resultCovidTest.TableEntriesChangeOfCharacter[2] = editorChangeOfCharacter3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение частоты
        /// </summary>
        private void editorFrequencyChange_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFrequencyChange1)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[0] = editorFrequencyChange1.Text;
            }
            if (sender == editorFrequencyChange2)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[1] = editorFrequencyChange2.Text;
            }
            if (sender == editorFrequencyChange3)
            {
                App.patient.resultCovidTest.TableEntriesFrequencyChange[2] = editorFrequencyChange3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Изменение интенсивности
        /// </summary>
        private void editorIntensityChange_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorIntensityChange1)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[0] = editorIntensityChange1.Text;
            }
            if (sender == editorIntensityChange2)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[1] = editorIntensityChange2.Text;
            }
            if (sender == editorIntensityChange3)
            {
                App.patient.resultCovidTest.TableEntriesIntensityChange[2] = editorIntensityChange3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Перепады настроения
        /// </summary>
        private void editorMoodSwings_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorMoodSwings1)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[0] = editorMoodSwings1.Text;
            }
            if (sender == editorMoodSwings2)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[1] = editorMoodSwings2.Text;
            }
            if (sender == editorMoodSwings3)
            {
                App.patient.resultCovidTest.TableEntriesMoodSwings[2] = editorMoodSwings3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Тревога
        /// </summary>
        private void editorAnxiety_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAnxiety1)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[0] = editorAnxiety1.Text;
            }
            if (sender == editorAnxiety2)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[1] = editorAnxiety2.Text;
            }
            if (sender == editorAnxiety3)
            {
                App.patient.resultCovidTest.TableEntriesAnxiety[2] = editorAnxiety3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Депрессия
        /// </summary>
        private void editorDepression_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDepression1)
            {
                App.patient.resultCovidTest.TableEntriesDepression[0] = editorDepression1.Text;
            }
            if (sender == editorDepression2)
            {
                App.patient.resultCovidTest.TableEntriesDepression[1] = editorDepression2.Text;
            }
            if (sender == editorDepression3)
            {
                App.patient.resultCovidTest.TableEntriesDepression[2] = editorDepression3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Навязчивые состояния
        /// </summary>
        private void editorObsessiveStates_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorObsessiveStates1)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[0] = editorObsessiveStates1.Text;
            }
            if (sender == editorObsessiveStates2)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[1] = editorObsessiveStates2.Text;
            }
            if (sender == editorObsessiveStates3)
            {
                App.patient.resultCovidTest.TableEntriesObsessiveStates[2] = editorObsessiveStates3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Лихорадка
        /// </summary>
        private void editorFever_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFever1)
            {
                App.patient.resultCovidTest.TableEntriesFever[0] = editorFever1.Text;
            }
            if (sender == editorFever2)
            {
                App.patient.resultCovidTest.TableEntriesFever[1] = editorFever2.Text;
            }
            if (sender == editorFever3)
            {
                App.patient.resultCovidTest.TableEntriesFever[2] = editorFever3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Повышенное потоотделение
        /// </summary>
        private void editorIncreasedSweating_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorIncreasedSweating1)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[0] = editorIncreasedSweating1.Text;
            }
            if (sender == editorIncreasedSweating2)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[1] = editorIncreasedSweating2.Text;
            }
            if (sender == editorIncreasedSweating3)
            {
                App.patient.resultCovidTest.TableEntriesIncreasedSweating[2] = editorIncreasedSweating3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Ночная потливость
        /// </summary>
        private void editorNightSweats_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNightSweats1)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[0] = editorNightSweats1.Text;
            }
            if (sender == editorNightSweats2)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[1] = editorNightSweats2.Text;
            }
            if (sender == editorNightSweats3)
            {
                App.patient.resultCovidTest.TableEntriesNightSweats[2] = editorNightSweats3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Непереносимость тепла
        /// </summary>
        private void editorHeatIntolerance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHeatIntolerance1)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[0] = editorHeatIntolerance1.Text;
            }
            if (sender == editorHeatIntolerance2)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[1] = editorHeatIntolerance2.Text;
            }
            if (sender == editorHeatIntolerance3)
            {
                App.patient.resultCovidTest.TableEntriesHeatIntolerance[2] = editorHeatIntolerance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Брадикардия
        /// </summary>
        private void editorBradycardia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorBradycardia1)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[0] = editorBradycardia1.Text;
            }
            if (sender == editorBradycardia2)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[1] = editorBradycardia2.Text;
            }
            if (sender == editorBradycardia3)
            {
                App.patient.resultCovidTest.TableEntriesBradycardia[2] = editorBradycardia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Тахикардия
        /// </summary>
        private void editorTachycardia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorTachycardia1)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[0] = editorTachycardia1.Text;
            }
            if (sender == editorTachycardia2)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[1] = editorTachycardia2.Text;
            }
            if (sender == editorTachycardia3)
            {
                App.patient.resultCovidTest.TableEntriesTachycardia[2] = editorTachycardia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Сердцебиение
        /// </summary>
        private void editorHeartbeat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHeartbeat1)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[0] = editorHeartbeat1.Text;
            }
            if (sender == editorHeartbeat2)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[1] = editorHeartbeat2.Text;
            }
            if (sender == editorHeartbeat3)
            {
                App.patient.resultCovidTest.TableEntriesHeartbeat[2] = editorHeartbeat3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Подъемы АД
        /// </summary>
        private void editorBPRises_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorBPRises1)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[0] = editorBPRises1.Text;
            }
            if (sender == editorBPRises2)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[1] = editorBPRises2.Text;
            }
            if (sender == editorBPRises3)
            {
                App.patient.resultCovidTest.TableEntriesBPRises[2] = editorBPRises3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Понижение АД
        /// </summary>
        private void editorLoweringBloodPressure_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorLoweringBloodPressure1)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[0] = editorLoweringBloodPressure1.Text;
            }
            if (sender == editorLoweringBloodPressure2)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[1] = editorLoweringBloodPressure2.Text;
            }
            if (sender == editorLoweringBloodPressure3)
            {
                App.patient.resultCovidTest.TableEntriesLoweringBloodPressure[2] = editorLoweringBloodPressure3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Обморок
        /// </summary>
        private void editorFainting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorFainting1)
            {
                App.patient.resultCovidTest.TableEntriesFainting[0] = editorFainting1.Text;
            }
            if (sender == editorFainting2)
            {
                App.patient.resultCovidTest.TableEntriesFainting[1] = editorFainting2.Text;
            }
            if (sender == editorFainting3)
            {
                App.patient.resultCovidTest.TableEntriesFainting[2] = editorFainting3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в мышцах 
        /// </summary>
        private void editorMusclePain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorMusclePain1)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[0] = editorMusclePain1.Text;
            }
            if (sender == editorMusclePain2)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[1] = editorMusclePain2.Text;
            }
            if (sender == editorMusclePain3)
            {
                App.patient.resultCovidTest.TableEntriesMusclePain[2] = editorMusclePain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в суставах
        /// </summary>
        private void editorJointPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorJointPain1)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[0] = editorJointPain1.Text;
            }
            if (sender == editorJointPain2)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[1] = editorJointPain2.Text;
            }
            if (sender == editorJointPain3)
            {
                App.patient.resultCovidTest.TableEntriesJointPain[2] = editorJointPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Головокружение
        /// </summary>
        private void editorDizziness_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDizziness1)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[0] = editorDizziness1.Text;
            }
            if (sender == editorDizziness2)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[1] = editorDizziness2.Text;
            }
            if (sender == editorDizziness3)
            {
                App.patient.resultCovidTest.TableEntriesDizziness[2] = editorDizziness3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение равновесия
        /// </summary>
        private void editorImbalance_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorImbalance1)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[0] = editorImbalance1.Text;
            }
            if (sender == editorImbalance2)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[1] = editorImbalance2.Text;
            }
            if (sender == editorImbalance3)
            {
                App.patient.resultCovidTest.TableEntriesImbalance[2] = editorImbalance3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушение зрения
        /// </summary>
        private void editorVisualImpairment_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorVisualImpairment1)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[0] = editorVisualImpairment1.Text;
            }
            if (sender == editorVisualImpairment2)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[1] = editorVisualImpairment2.Text;
            }
            if (sender == editorVisualImpairment3)
            {
                App.patient.resultCovidTest.TableEntriesVisualImpairment[2] = editorVisualImpairment3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кожная гиперестезия
        /// </summary>
        private void editorSkinHyperesthesia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSkinHyperesthesia1)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[0] = editorSkinHyperesthesia1.Text;
            }
            if (sender == editorSkinHyperesthesia2)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[1] = editorSkinHyperesthesia2.Text;
            }
            if (sender == editorSkinHyperesthesia3)
            {
                App.patient.resultCovidTest.TableEntriesSkinHyperesthesia[2] = editorSkinHyperesthesia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в конечностях
        /// </summary>
        private void editorPainInTheLimbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorPainInTheLimbs1)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[0] = editorPainInTheLimbs1.Text;
            }
            if (sender == editorPainInTheLimbs2)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[1] = editorPainInTheLimbs2.Text;
            }
            if (sender == editorPainInTheLimbs3)
            {
                App.patient.resultCovidTest.TableEntriesPainInTheLimbs[2] = editorPainInTheLimbs3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Онемение в конечностях
        /// </summary>
        private void editorNumbnessInTheLimbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNumbnessInTheLimbs1)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[0] = editorNumbnessInTheLimbs1.Text;
            }
            if (sender == editorNumbnessInTheLimbs2)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[1] = editorNumbnessInTheLimbs2.Text;
            }
            if (sender == editorNumbnessInTheLimbs3)
            {
                App.patient.resultCovidTest.TableEntriesNumbnessInTheLimbs[2] = editorNumbnessInTheLimbs3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Парестезии
        /// </summary>
        private void editorParesthesia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorParesthesia1)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[0] = editorParesthesia1.Text;
            }
            if (sender == editorParesthesia2)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[1] = editorParesthesia2.Text;
            }
            if (sender == editorParesthesia3)
            {
                App.patient.resultCovidTest.TableEntriesParesthesia[2] = editorParesthesia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушения вкуса (агевзия, снижение вкуса, искажение вкуса)
        /// </summary>
        private void editorTasteDisorders_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorTasteDisorders1)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[0] = editorTasteDisorders1.Text;
            }
            if (sender == editorTasteDisorders2)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[1] = editorTasteDisorders2.Text;
            }
            if (sender == editorTasteDisorders3)
            {
                App.patient.resultCovidTest.TableEntriesTasteDisorders[2] = editorTasteDisorders3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Нарушения обоняния (аносмия, фантомия, паросмия)
        /// </summary>
        private void editorOlfactoryDisorders_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorOlfactoryDisorders1)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[0] = editorOlfactoryDisorders1.Text;
            }
            if (sender == editorOlfactoryDisorders2)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[1] = editorOlfactoryDisorders2.Text;
            }
            if (sender == editorOlfactoryDisorders3)
            {
                App.patient.resultCovidTest.TableEntriesOlfactoryDisorders[2] = editorOlfactoryDisorders3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - кашель
        /// </summary>
        private void editorCough_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorCough1)
            {
                App.patient.resultCovidTest.TableEntriesCough[0] = editorCough1.Text;
            }
            if (sender == editorCough2)
            {
                App.patient.resultCovidTest.TableEntriesCough[1] = editorCough2.Text;
            }
            if (sender == editorCough3)
            {
                App.patient.resultCovidTest.TableEntriesCough[2] = editorCough3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Одышка
        /// </summary>
        private void editorDyspnea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDyspnea1)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[0] = editorDyspnea1.Text;
            }
            if (sender == editorDyspnea2)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[1] = editorDyspnea2.Text;
            }
            if (sender == editorDyspnea3)
            {
                App.patient.resultCovidTest.TableEntriesDyspnea[2] = editorDyspnea3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Стеснение в груди, боль в груди
        /// </summary>
        private void editorChestPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorChestPain1)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[0] = editorChestPain1.Text;
            }
            if (sender == editorChestPain2)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[1] = editorChestPain2.Text;
            }
            if (sender == editorChestPain3)
            {
                App.patient.resultCovidTest.TableEntriesChestPain[2] = editorChestPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Учащенное сердцебиение
        /// </summary>
        private void editorCardiopalmus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorCardiopalmus1)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[0] = editorCardiopalmus1.Text;
            }
            if (sender == editorCardiopalmus2)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[1] = editorCardiopalmus2.Text;
            }
            if (sender == editorCardiopalmus3)
            {
                App.patient.resultCovidTest.TableEntriesCardiopalmus[2] = editorCardiopalmus3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Анорексия, снижение аппетита
        /// </summary>
        private void editorAnorexia_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAnorexia1)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[0] = editorAnorexia1.Text;
            }
            if (sender == editorAnorexia2)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[1] = editorAnorexia2.Text;
            }
            if (sender == editorAnorexia3)
            {
                App.patient.resultCovidTest.TableEntriesAnorexia[2] = editorAnorexia3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Судороги
        /// </summary>
        private void editorConvulsions_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorConvulsions1)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[0] = editorConvulsions1.Text;
            }
            if (sender == editorConvulsions2)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[1] = editorConvulsions2.Text;
            }
            if (sender == editorConvulsions3)
            {
                App.patient.resultCovidTest.TableEntriesConvulsions[2] = editorConvulsions3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - боль в горле
        /// </summary>
        private void editorSoreThroat_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSoreThroat1)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[0] = editorSoreThroat1.Text;
            }
            if (sender == editorSoreThroat2)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[1] = editorSoreThroat2.Text;
            }
            if (sender == editorSoreThroat3)
            {
                App.patient.resultCovidTest.TableEntriesSoreThroat[2] = editorSoreThroat3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Шум в ушах
        /// </summary>
        private void editorNoiseInEars_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNoiseInEars1)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[0] = editorNoiseInEars1.Text;
            }
            if (sender == editorNoiseInEars2)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[1] = editorNoiseInEars2.Text;
            }
            if (sender == editorNoiseInEars3)
            {
                App.patient.resultCovidTest.TableEntriesNoiseInEars[2] = editorNoiseInEars3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Ушная боль
        /// </summary>
        private void editorEarAche_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorEarAche1)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[0] = editorEarAche1.Text;
            }
            if (sender == editorEarAche2)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[1] = editorEarAche2.Text;
            }
            if (sender == editorEarAche3)
            {
                App.patient.resultCovidTest.TableEntriesEarAche[2] = editorEarAche3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - заложенность носа
        /// </summary>
        private void editorNasalCongestion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNasalCongestion1)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[0] = editorNasalCongestion1.Text;
            }
            if (sender == editorNasalCongestion2)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[1] = editorNasalCongestion2.Text;
            }
            if (sender == editorNasalCongestion3)
            {
                App.patient.resultCovidTest.TableEntriesNasalCongestion[2] = editorNasalCongestion3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль и сухость носа (Синдром сухого носа)
        /// </summary>
        private void editorPainAndDrynessOfTheNose_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorPainAndDrynessOfTheNose1)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[0] = editorPainAndDrynessOfTheNose1.Text;
            }
            if (sender == editorPainAndDrynessOfTheNose2)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[1] = editorPainAndDrynessOfTheNose2.Text;
            }
            if (sender == editorPainAndDrynessOfTheNose3)
            {
                App.patient.resultCovidTest.TableEntriesPainAndDrynessOfTheNose[2] = editorPainAndDrynessOfTheNose3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Боль в животе
        /// </summary>
        private void editorAbdominalPain_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorAbdominalPain1)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[0] = editorAbdominalPain1.Text;
            }
            if (sender == editorAbdominalPain2)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[1] = editorAbdominalPain2.Text;
            }
            if (sender == editorAbdominalPain3)
            {
                App.patient.resultCovidTest.TableEntriesAbdominalPain[2] = editorAbdominalPain3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Диарея
        /// </summary>
        private void editorDiarrhea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorDiarrhea1)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[0] = editorDiarrhea1.Text;
            }
            if (sender == editorDiarrhea2)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[1] = editorDiarrhea2.Text;
            }
            if (sender == editorDiarrhea3)
            {
                App.patient.resultCovidTest.TableEntriesDiarrhea[2] = editorDiarrhea3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - тошнота и рвота
        /// </summary>
        private void editorNauseaAndVomiting_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorNauseaAndVomiting1)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[0] = editorNauseaAndVomiting1.Text;
            }
            if (sender == editorNauseaAndVomiting2)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[1] = editorNauseaAndVomiting2.Text;
            }
            if (sender == editorNauseaAndVomiting3)
            {
                App.patient.resultCovidTest.TableEntriesNauseaAndVomiting[2] = editorNauseaAndVomiting3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - выпадение волос
        /// </summary>
        private void editorHairLoss_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorHairLoss1)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[0] = editorHairLoss1.Text;
            }
            if (sender == editorHairLoss2)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[1] = editorHairLoss2.Text;
            }
            if (sender == editorHairLoss3)
            {
                App.patient.resultCovidTest.TableEntriesHairLoss[2] = editorHairLoss3.Text;
            }
        }


        /// <summary>
        /// Обработчик ввода в текстовое поле - Кожные высыпания
        /// </summary>
        private void editorSkinRashes_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == editorSkinRashes1)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[0] = editorSkinRashes1.Text;
            }
            if (sender == editorSkinRashes2)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[1] = editorSkinRashes2.Text;
            }
            if (sender == editorSkinRashes3)
            {
                App.patient.resultCovidTest.TableEntriesSkinRashes[2] = editorSkinRashes3.Text;
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы деятельности
        /// </summary>
        private void checkBoxActivity_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxActivity1)
            {
                answerActivity[0] = checkBoxActivity1.IsChecked;
            }
            if (sender == checkBoxActivity2)
            {
                answerActivity[1] = checkBoxActivity2.IsChecked;
            }
            if (sender == checkBoxActivity3)
            {
                answerActivity[2] = checkBoxActivity3.IsChecked;
            }
            if (sender == checkBoxActivity4)
            {
                answerActivity[3] = checkBoxActivity4.IsChecked;
            }
            if (sender == checkBoxActivity5)
            {
                answerActivity[4] = checkBoxActivity5.IsChecked;
            }
            if (sender == checkBoxActivity6)
            {
                answerActivity[5] = checkBoxActivity6.IsChecked;
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы заболеваний
        /// </summary>
        private void checkBoxDiseases_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxDiseases1)
            {
                answerDiseases[0] = checkBoxDiseases1.IsChecked;

                if (answerDiseases[0] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases2)
            {
                answerDiseases[1] = checkBoxDiseases2.IsChecked;

                if (answerDiseases[1] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases3)
            {
                answerDiseases[2] = checkBoxDiseases3.IsChecked;

                if (answerDiseases[2] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases4)
            {
                answerDiseases[3] = checkBoxDiseases4.IsChecked;

                if (answerDiseases[3] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases5)
            {
                answerDiseases[4] = checkBoxDiseases5.IsChecked;

                if (answerDiseases[4] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases6)
            {
                answerDiseases[5] = checkBoxDiseases6.IsChecked;

                if (answerDiseases[5] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases7)
            {
                answerDiseases[6] = checkBoxDiseases7.IsChecked;

                if (answerDiseases[6] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases8)
            {
                answerDiseases[7] = checkBoxDiseases8.IsChecked;

                if (answerDiseases[7] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases9)
            {
                answerDiseases[8] = checkBoxDiseases9.IsChecked;

                if (answerDiseases[8] == true)
                {
                    answerDiseases[9] = false;
                    checkBoxDiseases10.IsChecked = false;
                }
            }
            if (sender == checkBoxDiseases10)
            {
                answerDiseases[9] = checkBoxDiseases10.IsChecked;

                if (answerDiseases[9] == true)
                {
                    ResetOthersCheckBoxAnswers(answerDiseases, 9);
                    checkBoxDiseases1.IsChecked = false;
                    checkBoxDiseases2.IsChecked = false;
                    checkBoxDiseases3.IsChecked = false;
                    checkBoxDiseases4.IsChecked = false;
                    checkBoxDiseases5.IsChecked = false;
                    checkBoxDiseases6.IsChecked = false;
                    checkBoxDiseases7.IsChecked = false;
                    checkBoxDiseases8.IsChecked = false;
                    checkBoxDiseases9.IsChecked = false;
                }
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы трудоспособности
        /// </summary>
        private void checkBoxAbilityToWork_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxAbilityToWork1)
            {
                answerAbilityToWork[0] = checkBoxAbilityToWork1.IsChecked;

                if (answerAbilityToWork[0] == true)
                {
                    ResetOthersCheckBoxAnswers(answerAbilityToWork, 0);
                    checkBoxAbilityToWork2.IsChecked = false;
                    checkBoxAbilityToWork3.IsChecked = false;
                }
            }
            if (sender == checkBoxAbilityToWork2)
            {
                answerAbilityToWork[1] = checkBoxAbilityToWork2.IsChecked;

                if (answerAbilityToWork[1] == true)
                {
                    ResetOthersCheckBoxAnswers(answerAbilityToWork, 1);
                    checkBoxAbilityToWork1.IsChecked = false;
                    checkBoxAbilityToWork3.IsChecked = false;
                }
            }
            if (sender == checkBoxAbilityToWork3)
            {
                answerAbilityToWork[2] = checkBoxAbilityToWork3.IsChecked;

                if (answerAbilityToWork[2] == true)
                {
                    ResetOthersCheckBoxAnswers(answerAbilityToWork, 2);
                    checkBoxAbilityToWork2.IsChecked = false;
                    checkBoxAbilityToWork1.IsChecked = false;
                }
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы работоспособности дома
        /// </summary>
        private void checkBoxPerformance_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxPerformance1)
            {
                answerWorkAtHome[0] = checkBoxPerformance1.IsChecked;

                if (answerWorkAtHome[0] == true)
                {
                    ResetOthersCheckBoxAnswers(answerWorkAtHome, 0);
                    checkBoxPerformance2.IsChecked = false;
                    checkBoxPerformance3.IsChecked = false;
                }
            }
            if (sender == checkBoxPerformance2)
            {
                answerWorkAtHome[1] = checkBoxPerformance2.IsChecked;

                if (answerWorkAtHome[1] == true)
                {
                    ResetOthersCheckBoxAnswers(answerWorkAtHome, 1);
                    checkBoxPerformance1.IsChecked = false;
                    checkBoxPerformance3.IsChecked = false;
                }
            }
            if (sender == checkBoxPerformance3)
            {
                answerWorkAtHome[2] = checkBoxPerformance3.IsChecked;

                if (answerWorkAtHome[2] == true)
                {
                    ResetOthersCheckBoxAnswers(answerWorkAtHome, 2);
                    checkBoxPerformance2.IsChecked = false;
                    checkBoxPerformance1.IsChecked = false;
                }
            }
        }


        /// <summary>
        /// Обработчик ответов на вопросы досуговой активности
        /// </summary>
        private void checkBoxLeisure_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (sender == checkBoxLeisure1)
            {
                answerLeisureActivities[0] = checkBoxLeisure1.IsChecked;

                if (answerLeisureActivities[0] == true)
                {
                    ResetOthersCheckBoxAnswers(answerLeisureActivities, 0);
                    checkBoxLeisure2.IsChecked = false;
                    checkBoxLeisure3.IsChecked = false;
                }
            }
            if (sender == checkBoxLeisure2)
            {
                answerLeisureActivities[1] = checkBoxLeisure2.IsChecked;

                if (answerLeisureActivities[1] == true)
                {
                    ResetOthersCheckBoxAnswers(answerLeisureActivities, 1);
                    checkBoxLeisure1.IsChecked = false;
                    checkBoxLeisure3.IsChecked = false;
                }
            }
            if (sender == checkBoxLeisure3)
            {
                answerLeisureActivities[2] = checkBoxLeisure3.IsChecked;

                if (answerLeisureActivities[2] == true)
                {
                    ResetOthersCheckBoxAnswers(answerLeisureActivities, 2);
                    checkBoxLeisure2.IsChecked = false;
                    checkBoxLeisure1.IsChecked = false;
                }
            }
        }
    }
}