using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class TestPraxisAndGnosis : ContentPage
    {
        Client client;
        Client clientMotorPraxis;
        Client clientDynamicPraxis;
        Client clientConstructivePraxis;
        Client clientSubjectGnosis;

        public TestPraxisAndGnosis()
        {
            InitializeComponent();
            Title = "Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса";
            client = new Client();
            clientMotorPraxis = new Client();
            clientDynamicPraxis = new Client();
            clientConstructivePraxis = new Client();
            clientSubjectGnosis = new Client();

        }

        private void button_CalculateResult(object sender, System.EventArgs e)
        {
          
            client.Score += Int32.Parse(entryPoints.Text);
            DisplayAlert("Результат", $"Общий результат = {client.Score}\n" +
                                      $"Моторный праксис = {clientMotorPraxis.Score}\n" +
                                      $"Динамический праксис = {clientDynamicPraxis.Score}\n" +
                                      $"Конструктивный праксис = {clientConstructivePraxis.Score}\n" +
                                      $"Объектный гнозис = {clientSubjectGnosis.Score}\n" +
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

            client.Score = 0;
            clientMotorPraxis.Score = 0;
            clientDynamicPraxis.Score = 0;
            clientConstructivePraxis.Score = 0;
            clientSubjectGnosis.Score = 0;

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
                client.Score += 1;
                clientMotorPraxis.Score += 1;
            }

            else
            {
                client.Score -= 1;
                clientMotorPraxis.Score -= 1;
            }
        }
        private void OnCheckBoxCheckedChangedDynamicPraxis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                client.Score += 1;
                clientDynamicPraxis.Score += 1;
            }

            else
            {
                client.Score -= 1;
                clientDynamicPraxis.Score -= 1;
            }
        }

        private void OnCheckBoxCheckedChangedConstructivePraxis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                client.Score += 1;
                clientConstructivePraxis.Score += 1;
            }

            else
            {
                client.Score -= 1;
                clientConstructivePraxis.Score -= 1;
            }
        }

        private void OnCheckBoxCheckedChangedSubjectGnosis(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                client.Score += 1;
                clientSubjectGnosis.Score += 1;
            }

            else
            {
                client.Score -= 1;
                clientSubjectGnosis.Score -= 1;
            }
        }

    }
}