using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApplication
{
    public class TestCognitive : ContentPage
    {
        public TestCognitive()
        {
            Title = "Оценка когнитивной сферы";
            Button backButton = new Button
            {
                Text = "На главную",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            backButton.Clicked += BackButton_Click;
            Content = backButton;
        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}