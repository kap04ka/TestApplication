using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class Patient
    {
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
        /// Количество баллов за тест локус-контроля
        /// </summary>
        public ResultPraxisAndGnosis resultPraxisAndGnosis;

        public Patient()
        {
            scoreMFI20 = new ScoreMFI20();
            scoreBourdon = new TestCorrectionBourdon();
            resultLifeQuality = new ResultLifeQuality();
            resultAnxietyAndDepression = new ResultAnxietyAndDepression();
            resultVasserman = new ResultVasserman();
            resultLocus = new ResultLocus();
            resultPraxisAndGnosis = new ResultPraxisAndGnosis();
        }

    }

    public class ResultPraxisAndGnosis
    {
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int resultMotorPraxis = 0;
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int resultDynamicPraxis = 0;
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int resultConstructivePraxis = 0;
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int resultSubjectGnosis = 0;
        /// <summary>
        /// Массив ответов теста локус-контроля
        /// </summary>
        public int resultClock = 0;
        /// <summary>
        /// Массив ответов теста локус-контроля
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
}
