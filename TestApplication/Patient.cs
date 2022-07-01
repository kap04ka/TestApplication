using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TestApplication
{
    [Table ("Пациенты")]
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("Фамилия пациента")]
        /// <summary>
        /// Фамилия пациента
        /// </summary>
        public string Surname { get; set; }
        [Column("Имя пациента")]
        /// <summary>
        /// Имя пациента
        /// </summary>
        public string Forename { get; set; }
        [Column("Отчество пациента")]
        /// <summary>
        /// Отчество пациента
        /// </summary>
        public string Patronymic { get; set; }

        [Column("Дата рождения")]
        public string BirthDateString { get; set; }
        [Ignore]
        /// <summary>
        /// Дата рождения пациента
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        [Column("Возраст пациента")]
        /// <summary>
        /// Возраст пациента
        /// </summary>
        public int Age { get; set; }


        [Column("Место работы")]
        /// <summary>
        /// Место работы пациента
        /// </summary>
        public string Company { get; set; }
        [Column("Электронная почта")]
        /// <summary>
        /// Электронная почта пациента
        /// </summary>
        public string Email { get; set; }
        [Column("Номер телефона")]
        /// <summary>
        /// Номер телефона пациента
        /// </summary>
        public string PhoneNumber { get; set; }


        [Column("ФИО лечащего врача")]
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


    [Table ("Тест МОСА")]
    public class ResultMOSA
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        [Column("Итоговый результат")]
        /// <summary>
        /// Результат за тест МОСА
        /// </summary>
        public int resultMOSATest { get; set; }
        [Column("Зрительно-конструктивный/исполнительные навыки")]
        /// <summary>
        /// Результат за Зрительно-конструктивные/исполнительные навыки
        /// </summary>
        public int resultVisualConstructiveSkillsMOSA { get; set; }
        [Column("Называние")]
        /// <summary>
        /// Результат Называние
        /// </summary>
        public int resultNamingMOSA { get; set; }
        [Column("Внимание")]
        /// <summary>
        /// Результат Внимание
        /// </summary>
        public int resultAttentionMOSA { get; set; }
        [Column("Речь")]
        /// <summary>
        /// Результат Речь
        /// </summary>
        public int resultSpeechMOSA { get; set; }
        [Column("Абстракция")]
        /// <summary>
        /// Результат Абстракция
        /// </summary>
        public int resultAbstractionMOSA { get; set; }
        [Column("Отсроченное воспроизведение")]
        /// <summary>
        /// Результат Отсроченное воспроизведение 
        /// </summary>
        public int resultDelayedPlaybackMOSA { get; set; }
        [Column("Ориентация")]
        /// <summary>
        /// Результат Ориентация
        /// </summary>
        public int resultOrientationMOSA { get; set; }

        public ResultMOSA()
        {

        }
    }


    [Table ("Тест праксиса и гнозиса")]
    public class ResultPraxisAndGnosis
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        [Column("Моторный праксис")]
        /// <summary>
        /// Ответы моторного праксиса 
        /// </summary>
        public int resultMotorPraxis { get; set; }
        [Column("Динамический праксис")]
        /// <summary>
        /// Ответы динамического праксиса
        /// </summary>
        public int resultDynamicPraxis { get; set; }
        [Column("Конструктивный праксис")]
        /// <summary>
        /// Ответы конструктивного праксиса
        /// </summary>
        public int resultConstructivePraxis { get; set; }
        [Column("Объектный гнозис")]
        /// <summary>
        /// Ответы объектного гнозиса
        /// </summary>
        public int resultSubjectGnosis { get; set; }
        [Column("Перерисовывание часов")]
        /// <summary>
        /// Ответы перерисовывания часов
        /// </summary>
        public int resultClock { get; set; }
        [Column("Общий балл")]
        /// <summary>
        /// Ответ на тест Праксиса и Гнозиса
        /// </summary>
        public int TotalResultPraxisAndGnosis { get; set; }

        public ResultPraxisAndGnosis()
        {

        }
    }


    [Table ("Тест локус-контроля")]
    public class ResultLocus
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }


        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int[] arrayAnswerLocus = new int[9];

        [Column("Итоговый балл")]
        /// <summary>
        /// Итоговый результат теста локус-контроля
        /// </summary>
        public int TotalResultLocus { get; set; }
    }


    [Table ("Тест Вассермана")]
    public class ResultVasserman
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        /// <summary>
        /// Массив ответов теста Вассермана
        /// </summary>
        public int[] arrayAnswerVasserman = new int[21];
        [Column("Баллы за ответы")]
        public string AnswersVasserman { get; set; }
        [Column("Общее количество баллов")]
        /// <summary>
        /// Итоговый результат теста Вассермана
        /// </summary>
        public int TotalResultVasserman { get; set; }
    }


    [Table ("Тест на тревожность и депрессию")]
    public class ResultAnxietyAndDepression
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        /// <summary>
        /// Массив ответов теста тревожности
        /// </summary>
        public int[] arrayAnswerAnxiety = new int[7];
        [Column("Балл тревожности")]
        /// <summary>
        /// Итоговый результат тревожности
        /// </summary>
        public int TotalResultAnxiety { get; set; }

        /// <summary>
        /// Массив ответов теста деперессии
        /// </summary>
        public int[] arrayAnswerDepression = new int[7];
        [Column("Балл депрессии")]
        /// <summary>
        /// Итоговый результат депрессии
        /// </summary>
        public int TotalResultDepression { get; set; }
    }


    [Table ("Тест качества жизни")]
    public class ResultLifeQuality
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        /// <summary>
        /// Массив ответов теста качества жизни
        /// </summary>
        public int[] arrayAnswerLifeQuality = new int[6];
        [Column("Итоговый балл")]
        /// <summary>
        /// Итоговый результат
        /// </summary>
        public int TotalResultLifeQuality { get; set; }
    }


    [Table ("Тест на астению")]
    /// <summary>
    /// Тест на астению
    /// </summary>
    public class ScoreMFI20
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column ("Имя пациента")]
        public string Name { get; set; }
        

        [Column("Общая астения")]
        /// <summary>
        /// Количество баллов за общая астения в MFI-20
        /// </summary>
        public int ScoreAnswerGeneralAsthenia { get; set; }
        [Column("Пониженная активность")]
        /// <summary>
        /// Количество баллов за пониженная активность в MFI-20
        /// </summary>
        public int ScoreAnswerReducedActivity { get; set; }
        [Column("Снижение мотивации")]
        /// <summary>
        /// Количество баллов за снижение мотивации в MFI-20
        /// </summary>
        public int ScoreAnswerDecreasedMotivation { get; set; }
        [Column("Физическая астения")]
        /// <summary>
        /// Количество баллов за физическую астению в MFI-20
        /// </summary>
        public int ScoreAnswerPhysicalAsthenia { get; set; }
        [Column("Психическая астения")]
        /// <summary>
        /// Количество баллов за психическую астению в MFI-20
        /// </summary>
        public int ScoreAnswerMentalAsthenia { get; set; }

        [Column("Всего баллов")]
        /// <summary>
        /// Количество баллов тест MFI-20
        /// </summary>
        public int TotalTestScore { get; set; }


        public ScoreMFI20()
        {

        }
    }


    [Table ("Тест Бурдона")]
    /// <summary>
    /// Ответы на тест корректурная проба Бурдона 
    /// </summary>
    public class TestCorrectionBourdon
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Column("ID пациента")]
        public int IdPatient { get; set; }
        [Column("Фамилия пациента")]
        public string Surname { get; set; }
        [Column("Имя пациента")]
        public string Name { get; set; }

        [Column("Концетрация внимания")]
        /// <summary>
        /// Концентрация внимания
        /// </summary>
        public int ConcentrationOfAtention { get; set; }
        [Ignore]
        /// <summary>
        /// Темп выполнения за определенное количество минут
        /// </summary>
        public int[] PaceArray { get; set; }
        [Column("Устойчивость внимания")]
        /// <summary>
        /// Устойчивость внимания
        /// </summary>
        public int AttentionSpan { get; set; }
        [Column("Темп выполнения")]
        public string PaceString { get; set; }

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