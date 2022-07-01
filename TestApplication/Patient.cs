using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestApplication
{
    [Table ("Patients")]
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        /// <summary>
        /// Фамилия пациента
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя пациента
        /// </summary>
        public string Forename { get; set; }
        /// <summary>
        /// Отчество пациента
        /// </summary>
        public string Patronymic { get; set; }


        /// <summary>
        /// Дата рождения пациента
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Возраст пациента
        /// </summary>
        public int Age { get; set; }


        /// <summary>
        /// Место работы пациента
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// Электронная почта пациента
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Номер телефона пациента
        /// </summary>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// ФИО лечащего врача
        /// </summary>
        public string DoctorFIO { get; set; }


        /// <summary>
        /// Количество баллов за субъективную шкалу оценки астении 
        /// </summary>
        public ScoreMFI20 scoreMFI20;

        /// <summary>
        /// Количество баллов за корректурный тест Бурдона
        /// </summary>
        public TestCorrectionBourdon scoreBourdon;

        /// <summary>
        /// Количество баллов за тест качества жизни 
        /// </summary>
        public ResultLifeQuality resultLifeQuality;

        /// <summary>
        /// Количество баллов за тест на тревожность и депрессию 
        /// </summary>
        public ResultAnxietyAndDepression resultAnxietyAndDepression;

        /// <summary>
        /// Количество баллов за тест Вассермана
        /// </summary>
        public ResultVasserman resultVasserman;

        /// <summary>
        /// Количество баллов за тест локус-контроля
        /// </summary>
        public ResultLocus resultLocus;

        /// <summary>
        /// Количество баллов за тест Праксиса и Гнозиса
        /// </summary>
        public ResultPraxisAndGnosis resultPraxisAndGnosis;


        public CovidTest resultCovidTest;

        /// <summary>
        /// Количество баллов за когнитивный тест МОСА
        /// </summary>
        public ResultMOSA resultMOSA;

        public Patient()
        {
            scoreMFI20 = new ScoreMFI20();
            scoreBourdon = new TestCorrectionBourdon();
            resultLifeQuality = new ResultLifeQuality();
            resultAnxietyAndDepression = new ResultAnxietyAndDepression();
            resultVasserman = new ResultVasserman();
            resultLocus = new ResultLocus();
            resultPraxisAndGnosis = new ResultPraxisAndGnosis();
            resultCovidTest = new CovidTest();
            resultMOSA = new ResultMOSA();
        }

    }

    public class ResultMOSA
    {
        /// <summary>
        /// Результат за тест МОСА
        /// </summary>
        public int resultMOSATest = 0;
        /// <summary>
        /// Результат за Зрительно-конструктивные/исполнительные навыки
        /// </summary>
        public int resultVisualConstructiveSkillsMOSA = 0;
        /// <summary>
        /// Результат Называние
        /// </summary>
        public int resultNamingMOSA = 0;
        /// <summary>
        /// Результат Внимание
        /// </summary>
        public int resultAttentionMOSA = 0;
        /// <summary>
        /// Результат Речь
        /// </summary>
        public int resultSpeechMOSA = 0;
        /// <summary>
        /// Результат Абстракция
        /// </summary>
        public int resultAbstractionMOSA = 0;
        /// <summary>
        /// Результат Отсроченное воспроизведение 
        /// </summary>
        public int resultDelayedPlaybackMOSA = 0;
        /// <summary>
        /// Результат Ориентация
        /// </summary>
        public int resultOrientationMOSA = 0;
    }

    public class ResultPraxisAndGnosis
    {
        /// <summary>
        /// Ответы моторного праксиса 
        /// </summary>
        public int resultMotorPraxis = 0;
        /// <summary>
        /// Ответы динамического праксиса
        /// </summary>
        public int resultDynamicPraxis = 0;
        /// <summary>
        /// Ответы конструктивного праксиса
        /// </summary>
        public int resultConstructivePraxis = 0;
        /// <summary>
        /// Ответы объектного гнозиса
        /// </summary>
        public int resultSubjectGnosis = 0;
        /// <summary>
        /// Ответы перерисовывания часов
        /// </summary>
        public int resultClock = 0;
        /// <summary>
        /// Ответ на тест Праксиса и Гнозиса
        /// </summary>
        public int TotalResultPraxisAndGnosis = 0;

    }

    public class ResultLocus
    {
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int[] arrayAnswerLocus = new int[9];

        /// <summary>
        /// Итоговый результат теста локус-контроля
        /// </summary>
        public int TotalResultLocus = 0;
    }

    public class ResultVasserman
    {
        /// <summary>
        /// Массив ответов теста Вассермана
        /// </summary>
        public int[] arrayAnswerVasserman = new int[21];

        /// <summary>
        /// Итоговый результат теста Вассермана
        /// </summary>
        public int TotalResultVasserman = 0;
    }

    public class ResultAnxietyAndDepression
    {
        /// <summary>
        /// Массив ответов теста тревожности
        /// </summary>
        public int[] arrayAnswerAnxiety = new int[7];
        /// <summary>
        /// Итоговый результат тревожности
        /// </summary>
        public int TotalResultAnxiety = 0;

        /// <summary>
        /// Массив ответов теста деперессии
        /// </summary>
        public int[] arrayAnswerDepression = new int[7];
        /// <summary>
        /// Итоговый результат депрессии
        /// </summary>
        public int TotalResultDepression = 0;
    }

    public class ResultLifeQuality
    {
        /// <summary>
        /// Массив ответов теста качества жизни
        /// </summary>
        public int[] arrayAnswerLifeQuality = new int[6];
        /// <summary>
        /// Итоговый результат
        /// </summary>
        public int TotalResultLifeQuality = 0;
    }


    /// <summary>
    /// Тест на астению
    /// </summary>
    public class ScoreMFI20
    {
        /// <summary>
        /// Количество баллов за общая астения в MFI-20
        /// </summary>
        public int ScoreAnswerGeneralAsthenia { get; set; }
        /// <summary>
        /// Количество баллов за пониженная активность в MFI-20
        /// </summary>
        public int ScoreAnswerReducedActivity { get; set; }
        /// <summary>
        /// Количество баллов за снижение мотивации в MFI-20
        /// </summary>
        public int ScoreAnswerDecreasedMotivation { get; set; }
        /// <summary>
        /// Количество баллов за физическую астению в MFI-20
        /// </summary>
        public int ScoreAnswerPhysicalAsthenia { get; set; }
        /// <summary>
        /// Количество баллов за психическую астению в MFI-20
        /// </summary>
        public int ScoreAnswerMentalAsthenia { get; set; }


        /// <summary>
        /// Количество баллов тест MFI-20
        /// </summary>
        public int TotalTestScore { get; set; }


        public ScoreMFI20()
        {

        }
    }


    /// <summary>
    /// Ответы на тест корректурная проба Бурдона 
    /// </summary>
    public class TestCorrectionBourdon
    {
        /// <summary>
        /// Концентрация внимания
        /// </summary>
        public int ConcentrationOfAtention { get; set; }
        /// <summary>
        /// Темп выполнения за определенное количество минут
        /// </summary>
        public int[] PaceArray { get; set; }
        /// <summary>
        /// Устойчивость внимания
        /// </summary>
        public int AttentionSpan { get; set; }

        public TestCorrectionBourdon()
        {
            PaceArray = new int[5];
        }
    }


    /// <summary>
    /// Результаты теста на ковид
    /// </summary>
    public class CovidTest
    {
        /// <summary>
        /// Пол пациента
        /// </summary>
        public string GenderPatient { get; set; }
        /// <summary>
        /// Образование пациента
        /// </summary>
        public string EducationPatient { get; set; }
        /// <summary>
        /// Деятельность пациента
        /// </summary>
        public string ActivityPatient { get; set; }
        /// <summary>
        /// Заболевания пациента
        /// </summary>
        public string DiseasesPatient { get; set; }
        /// <summary>
        /// Трудоспособность пациента
        /// </summary>
        public string AbilityToWorkPatient { get; set; }
        /// <summary>
        /// Оцентка трудоспособности
        /// </summary>
        public int WorkCapacityAssessment { get; set; }
        /// <summary>
        /// Работоспособность по дому пациента
        /// </summary>
        public string WorkAtHomePatient { get; set; }
        /// <summary>
        /// Оценка работоспособности по дому
        /// </summary>
        public int PerformanceEvaluation { get; set; }
        /// <summary>
        /// Досуговая активность пациента
        /// </summary>
        public string LeisureActivitiesPatient { get; set; }
        /// <summary>
        /// Оценка досуговой активности
        /// </summary>
        public int LeisureEvaluation { get; set; }


        /// <summary>
        /// Кратковременная потеря памяти (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesShortTermMemoryLoss { get; set; }
        /// <summary>
        /// Снижение памяти (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDecreasedMemory { get; set; }
        /// <summary>
        /// Снижение концентрации внимания, "туман в мозгу" (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDecreasedConcentration { get; set; }
        /// <summary>
        /// Повышенная утомляемость (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesFatigue { get; set; }
        /// <summary>
        /// Спутанность сознания (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesConfusion { get; set; }
        /// <summary>
        /// Нарушение сна (патологическое бодрствование, бессонница) (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesSleepDisturbance { get; set; }
        /// <summary>
        /// Проблемы с речью (подбор слов или произношение) (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesSpeechProblems { get; set; }
        /// <summary>
        /// Изменение характера (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesChangeOfCharacter { get; set; }
        /// <summary>
        /// Изменение частоты (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesFrequencyChange { get; set; }
        /// <summary>
        /// Изменение интенсивности (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesIntensityChange { get; set; }
        /// <summary>
        /// Перепады настроения (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesMoodSwings { get; set; }
        /// <summary>
        /// Тревога (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesAnxiety { get; set; }
        /// <summary>
        /// Депрессия (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDepression { get; set; }
        /// <summary>
        /// Навязчивые состояния (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesObsessiveStates { get; set; }
        /// <summary>
        /// Лихорадка (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesFever { get; set; }
        /// <summary>
        /// Повышенное потоотделение (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesIncreasedSweating { get; set; }
        /// <summary>
        /// Ночная потливость (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesNightSweats { get; set; }
        /// <summary>
        /// Непереносимость тепла (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesHeatIntolerance { get; set; }
        /// <summary>
        /// Брадикардия (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesBradycardia { get; set; }
        /// <summary>
        /// Тахикардия (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesTachycardia { get; set; }
        /// <summary>
        /// Сердцебиение (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesHeartbeat { get; set; }
        /// <summary>
        /// Подъемы АД (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesBPRises { get; set; }
        /// <summary>
        /// Понижение АД (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesLoweringBloodPressure { get; set; }
        /// <summary>
        /// Обморок (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesFainting { get; set; }
        /// <summary>
        /// Боль в мышцах  (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesMusclePain { get; set; }
        /// <summary>
        /// Боль в суставах (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesJointPain { get; set; }
        /// <summary>
        /// Головокружение (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDizziness { get; set; }
        /// <summary>
        /// Нарушение равновесия (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesImbalance { get; set; }
        /// <summary>
        /// Нарушение зрения (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesVisualImpairment { get; set; }
        /// <summary>
        /// Кожная гиперестезия (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesSkinHyperesthesia { get; set; }
        /// <summary>
        /// Боль в конечностях (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesPainInTheLimbs { get; set; }
        /// <summary>
        /// Онемение в конечностях (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesNumbnessInTheLimbs { get; set; }
        /// <summary>
        /// Парестезии (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesParesthesia { get; set; }
        /// <summary>
        /// Нарушения вкуса (агевзия, снижение вкуса, искажение вкуса) (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesTasteDisorders { get; set; }
        /// <summary>
        /// Нарушения обоняния (аносмия, фантомия, паросмия) (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesOlfactoryDisorders { get; set; }
        /// <summary>
        /// кашель (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesCough { get; set; }
        /// <summary>
        /// Одышка (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDyspnea { get; set; }
        /// <summary>
        /// Стеснение в груди, боль в груди (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesChestPain { get; set; }
        /// <summary>
        /// Учащенное сердцебиение (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesCardiopalmus { get; set; }
        /// <summary>
        /// Анорексия, снижение аппетита (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesAnorexia { get; set; }
        /// <summary>
        /// Судороги (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesConvulsions { get; set; }
        /// <summary>
        /// боль в горле (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesSoreThroat { get; set; }
        /// <summary>
        /// Шум в ушах (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesNoiseInEars { get; set; }
        /// <summary>
        /// Ушная боль (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesEarAche { get; set; }
        /// <summary>
        /// заложенность носа (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesNasalCongestion { get; set; }
        /// <summary>
        /// Боль и сухость носа (Синдром сухого носа) (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesPainAndDrynessOfTheNose { get; set; }
        /// <summary>
        /// Боль в животе (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesAbdominalPain { get; set; }
        /// <summary>
        /// Диарея (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesDiarrhea { get; set; }
        /// <summary>
        /// тошнота и рвота (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesNauseaAndVomiting { get; set; }
        /// <summary>
        /// выпадение волос (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesHairLoss { get; set; }
        /// <summary>
        /// Кожные высыпания (При поступлении, При выписке, Через 3 месяца после выписки)
        /// </summary>
        public string[] TableEntriesSkinRashes { get; set; }


        public CovidTest()
        {
            TableEntriesShortTermMemoryLoss = new string[3];
            TableEntriesDecreasedMemory = new string[3];
            TableEntriesDecreasedConcentration = new string[3];
            TableEntriesFatigue = new string[3];
            TableEntriesConfusion = new string[3];
            TableEntriesSleepDisturbance = new string[3];
            TableEntriesSpeechProblems = new string[3];
            TableEntriesChangeOfCharacter = new string[3];
            TableEntriesFrequencyChange = new string[3];
            TableEntriesIntensityChange = new string[3];
            TableEntriesMoodSwings = new string[3];
            TableEntriesAnxiety = new string[3];
            TableEntriesDepression = new string[3];
            TableEntriesObsessiveStates = new string[3];
            TableEntriesFever = new string[3];
            TableEntriesIncreasedSweating = new string[3];
            TableEntriesNightSweats = new string[3];
            TableEntriesHeatIntolerance = new string[3];
            TableEntriesBradycardia = new string[3];
            TableEntriesTachycardia = new string[3];
            TableEntriesHeartbeat = new string[3];
            TableEntriesBPRises = new string[3];
            TableEntriesLoweringBloodPressure = new string[3];
            TableEntriesFainting = new string[3];
            TableEntriesMusclePain = new string[3];
            TableEntriesJointPain = new string[3];
            TableEntriesDizziness = new string[3];
            TableEntriesImbalance = new string[3];
            TableEntriesVisualImpairment = new string[3];
            TableEntriesSkinHyperesthesia = new string[3];
            TableEntriesPainInTheLimbs = new string[3];
            TableEntriesNumbnessInTheLimbs = new string[3];
            TableEntriesParesthesia = new string[3];
            TableEntriesTasteDisorders = new string[3];
            TableEntriesOlfactoryDisorders = new string[3];
            TableEntriesCough = new string[3];
            TableEntriesDyspnea = new string[3];
            TableEntriesChestPain = new string[3];
            TableEntriesCardiopalmus = new string[3];
            TableEntriesAnorexia = new string[3];
            TableEntriesConvulsions = new string[3];
            TableEntriesSoreThroat = new string[3];
            TableEntriesNoiseInEars = new string[3];
            TableEntriesEarAche = new string[3];
            TableEntriesNasalCongestion = new string[3];
            TableEntriesPainAndDrynessOfTheNose = new string[3];
            TableEntriesAbdominalPain = new string[3];
            TableEntriesDiarrhea = new string[3];
            TableEntriesNauseaAndVomiting = new string[3];
            TableEntriesHairLoss = new string[3];
            TableEntriesSkinRashes = new string[3];
        }
    }
}
