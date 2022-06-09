using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestApplication
{
    public class TestLocus_control : ContentPage
    {
        public TestLocus_control()
        {
            Title = "Шкала локуса-контроля";
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