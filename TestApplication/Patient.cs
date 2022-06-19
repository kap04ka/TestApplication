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

        public Patient()
        {
            scoreMFI20 = new ScoreMFI20();
            scoreBourdon = new TestCorrectionBourdon();
        }
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
