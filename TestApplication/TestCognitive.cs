using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TestApplication
{
    public partial class TestCognitive : ContentPage
    {
        Task task;

        int resultTest = 0;
        int resultVisualConstructiveSkills = 0;
        int resultNaming = 0;
        int resultAttention = 0;
        int resultSpeech = 0;
        int resultAbstraction = 0;
        int resultDelayedPlayback = 0;
        int resultOrientation = 0;
        int serialSubstractionResult = 0;

        public TestCognitive()
        {
            InitializeComponent();
            Title = "Оценка когнитивной сферы";
        }

        private async void button_CalculateResult(object sender, System.EventArgs e)
        {
            if(serialSubstractionResult == 5 || serialSubstractionResult == 4)
            {
                resultAttention += 3;
                resultTest += 3;
            }

            if (serialSubstractionResult == 3 || serialSubstractionResult == 2)
            {
                resultAttention += 2;
                resultTest += 2;
            }

            if (serialSubstractionResult == 1)
            {
                resultAttention += 1;
                resultTest += 1;
            }

            App.patient.resultMOSA.resultMOSATest = resultTest;
            App.patient.resultMOSA.resultVisualConstructiveSkillsMOSA = resultVisualConstructiveSkills;
            App.patient.resultMOSA.resultNamingMOSA = resultNaming;
            App.patient.resultMOSA.resultAttentionMOSA = resultAttention;
            App.patient.resultMOSA.resultSpeechMOSA = resultSpeech;
            App.patient.resultMOSA.resultAbstractionMOSA = resultAbstraction;
            App.patient.resultMOSA.resultDelayedPlaybackMOSA = resultDelayedPlayback;
            App.patient.resultMOSA.resultOrientationMOSA = resultOrientation;

            task = DisplayAlert("Результат", $"Общий результат = {resultTest}\n" +
                                       $"Баллы за зрительно-конструктивные навыки = {resultVisualConstructiveSkills}\n" +
                                       $"Баллы за называние = {resultNaming}\n" +
                                       $"Баллы за память = {resultAttention}\n" +
                                       $"Баллы за речь = {resultSpeech}\n" +
                                       $"Баллы за абстракцию = {resultAbstraction}\n" +
                                       $"Баллы за отсроченное воспроизведение = {resultDelayedPlayback}\n" +
                                       $"Баллы за ориентацию = {resultOrientation}\n",
                                       "Принять");

            await task;

            visualConstructiveSkillsFirst.IsChecked = false;
            visualConstructiveSkillsSecond.IsChecked = false;
            visualConstructiveSkillsThird.IsChecked = false;
            visualConstructiveSkillsFourth.IsChecked = false;
            visualConstructiveSkillsFifth.IsChecked = false;

            namingFirst.IsChecked = false;
            namingSecond.IsChecked = false;
            namingThird.IsChecked = false;

            firstWord1.IsChecked = false;
            firstWord2.IsChecked = false;
            secondtWord1.IsChecked = false;
            secondWord2.IsChecked = false;
            thirdWord1.IsChecked = false;
            thirdWord2.IsChecked = false;
            fourthWord1.IsChecked = false;
            fourthWord2.IsChecked = false;
            fifthWord1.IsChecked = false;
            fifthWord2.IsChecked = false;

            attentionFirst.IsChecked = false;
            attentionSecond.IsChecked = false;
            attentionThird.IsChecked = false;
            serialSubtractionFirst.IsChecked = false;
            serialSubtractionSecond.IsChecked = false;
            serialSubtractionThird.IsChecked = false;
            serialSubtractionFourth.IsChecked = false;
            serialSubtractionFifth.IsChecked = false;

            speechFirst.IsChecked = false;
            speechSecond.IsChecked = false;
            speechThird.IsChecked = false;

            abstractionFirst.IsChecked = false;
            abstractionSecond.IsChecked = false;

            delayedPlaybackFirst.IsChecked = false;
            delayedPlaybackSecond.IsChecked = false;
            delayedPlaybackThird.IsChecked = false;
            delayedPlaybackFourth.IsChecked = false;
            delayedPlaybackFifth.IsChecked = false;

            orientationFirst.IsChecked = false;
            orientationSecond.IsChecked = false;
            orientationThird.IsChecked = false;
            orientationFourth.IsChecked = false;
            orientationFifth.IsChecked = false;
            orientationSixth.IsChecked = false;

            promptSecond.IsEnabled = false;

            resultTest = 0;
            resultVisualConstructiveSkills = 0;
            resultNaming = 0;
            resultAttention = 0;
            resultSpeech = 0;
            resultAbstraction = 0;
            resultDelayedPlayback = 0;
            resultOrientation = 0;
            serialSubstractionResult = 0;

            await Navigation.PopAsync();
        }

        private void OnCheckBoxCheckedVisualConstructiveSkills(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultVisualConstructiveSkills += 1;
            }

            else
            {
                resultTest -= 1;
                resultVisualConstructiveSkills -= 1;
            }
        }

        private void OnCheckBoxCheckedNaming(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultNaming += 1;
            }

            else
            {
                resultTest -= 1;
                resultNaming -= 1;
            }
        }

        private void OnCheckBoxCheckedAttention(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultAttention += 1;
            }

            else
            {
                resultTest -= 1;
                resultAttention -= 1;
            }
        }

        private void OnCheckBoxCheckedSerialSubtraction(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                serialSubstractionResult += 1;
            }

            else
            {
                serialSubstractionResult -= 1;
            }

        }

        private void OnCheckBoxCheckedSpeech(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultSpeech += 1;
            }

            else
            {
                resultTest -= 1;
                resultSpeech -= 1;
            }

        }

        private void OnCheckBoxCheckedAbstraction(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultAbstraction += 1;
            }

            else
            {
                resultTest -= 1;
                resultAbstraction -= 1;
            }

        }
        private void OnCheckBoxCheckedDelayedPlayback(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultDelayedPlayback += 1;
            }

            else
            {
                resultTest -= 1;
                resultDelayedPlayback -= 1;
            }

        }

        private void OnCheckBoxCheckedOrientation(object sender, CheckedChangedEventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            if (chBox.IsChecked)
            {
                resultTest += 1;
                resultOrientation += 1;
            }

            else
            {
                resultTest -= 1;
                resultOrientation -= 1;
            }

        }

        private void button_PromptFirst(object sender, System.EventArgs e)
        {
            DisplayAlert("Подсказка категория",
                         "Лицо - часть тела\n" +
                         "Вельвет - вид материала\n" +
                         "Церковь - строение\n" +
                         "маргаритка - цветок\n" +
                         "Красный - цвет\n",
                         "Ok");

            promptSecond.IsEnabled = true;
        }

        private void button_PromptSecond(object sender, System.EventArgs e)
        {
            DisplayAlert("Подсказка выбор",
                         "нос, лицо, рука\n" +
                         "бархат, хлопок, вельвет\n" +
                         "церковь, школа, больница\n" +
                         "роза, маргаритка, тюльпан\n" +
                         "красный, синий, зеленый\n",
                         "Ok");
        }

    }
}