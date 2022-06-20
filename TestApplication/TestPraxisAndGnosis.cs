using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class TestPraxisAndGnosis : ContentPage
    {
        //Client client;
        //Client clientMotorPraxis;
        //Client clientDynamicPraxis;
        //Client clientConstructivePraxis;
        //Client clientSubjectGnosis;
        int resultTest = 0;
        int resultMotor = 0;
        int resultDynamic = 0;
        int resultConstructive = 0;
        int resultSubject = 0;


        public TestPraxisAndGnosis()
        {
            InitializeComponent();
            Title = "Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса";
            //client = new Client();
            //clientMotorPraxis = new Client();
            //clientDynamicPraxis = new Client();
            //clientConstructivePraxis = new Client();
            //clientSubjectGnosis = new Client();

        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {

            resultTest += Int32.Parse(entryPoints.Text);
            SetResults();
            DisplayAlert("Результат", $"Общий результат = {resultTest}\n" +
                                      $"Моторный праксис = {resultMotor}\n" +
                                      $"Динамический праксис = {resultDynamic}\n" +
                                      $"Конструктивный праксис = {resultConstructive}\n" +
                                      $"Объектный гнозис = {resultSubject}\n" +
                                      $"Повторение часов = {Int32.Parse(entryPoints.Text)}\n",
                                      "Принять");

            motorPraxisFirst.IsChecked = false;
            motorPraxisSecond.IsChecked = false;
            motorPraxisThird.IsChecked = false;
            motorPraxisFourth.IsChecked = false;
            motorPraxisFifth.IsChecked = false;

            dynamicPraxisFirst.IsChecked = false;
            dynamicPraxisSecond.IsChecked = false;
            dynamicPraxisThird.IsChecked = false;
            dynamicPraxisFourth.IsChecked = false;
            dynamicPraxisFifth.IsChecked = false;
            dynamicPraxisSixth.IsChecked = false;

            constructivePraxisFirst.IsChecked = false;
            constructivePraxisSecond.IsChecked = false;
            constructivePraxisThird.IsChecked = false;

            subjectGnosisFirst.IsChecked = false;
            subjectGnosisSecond.IsChecked = false;
            subjectGnosisThird.IsChecked = false;

            resultTest = 0;
            resultMotor = 0;
            resultDynamic = 0;
            resultConstructive = 0;
            resultSubject = 0;
            entryPoints.Text = "0";


            Console.WriteLine($"{App.patient.resultPraxisAndGnosis.resultMotorPraxis}, {App.patient.resultPraxisAndGnosis.resultDynamicPraxis}, {App.patient.resultPraxisAndGnosis.resultConstructivePraxis}," +
                $" {App.patient.resultPraxisAndGnosis.resultSubjectGnosis}, {App.patient.resultPraxisAndGnosis.resultClock}, {App.patient.resultPraxisAndGnosis.TotalResultPraxisAndGnosis} у пациента");
            Console.WriteLine($"{resultTest}, {resultMotor}, {resultDynamic}, {resultConstructive}, {resultSubject}, {Int32.Parse(entryPoints.Text)} после окончания теста");

        }

        private void SetResults()
        {
            App.patient.resultPraxisAndGnosis.resultMotorPraxis = resultMotor;
            App.patient.resultPraxisAndGnosis.resultDynamicPraxis = resultDynamic;
            App.patient.resultPraxisAndGnosis.resultConstructivePraxis = resultConstructive;
            App.patient.resultPraxisAndGnosis.resultSubjectGnosis = resultSubject;
            App.patient.resultPraxisAndGnosis.resultClock = Int32.Parse(entryPoints.Text);
            App.patient.resultPraxisAndGnosis.TotalResultPraxisAndGnosis = resultTest;
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            Entry entry = sender as Entry;

            int points = 0;

            try
            {
                points = Int32.Parse(entry.Text);
            }
            catch
            {
                points = 0;
            }

            finally
            {
                if (points > 8) points = 8;
                if (points < 0) points = 0;
                entry.Text = points.ToString();
            }


        }

        private void OnCheckBoxCheckedChangedMotorPraxis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultMotor += 1;
            }

            else
            {
                resultTest -= 1;
                resultMotor -= 1;
            }
        }

        private void OnCheckBoxCheckedChangedDynamicPraxis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultDynamic += 1;
            }

            else
            {
                resultTest -= 1;
                resultDynamic -= 1;
            }
        }

        private void OnCheckBoxCheckedChangedConstructivePraxis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultConstructive += 1;
            }

            else
            {
                resultTest -= 1;
                resultConstructive -= 1;
            }
        }

        private void OnCheckBoxCheckedChangedSubjectGnosis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultSubject += 1;
            }

            else
            {
                resultTest -= 1;
                resultSubject -= 1;
            }
        }

    }
}