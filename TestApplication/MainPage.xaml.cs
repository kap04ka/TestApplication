using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            List<string> nameTests = new List<string>() { "Тест COVID-19", "Оценка когнитивной сферы", "Шкала Вассермана", "Корректурная проба Бурдона",
                                                          "Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса",
                                                          "Шкала тревоги и депрессии", "Субъективная шкала оценки астении", "Европейский опросник качества жизни",
                                                          "Шкала локуса-контроля"};

            Button button = null;

            for (int i = 1; i <= 9; i++)
            {
                button = new Button();
                button.Text = nameTests[i - 1];
                button.BackgroundColor = Color.FromRgb(255, 229, 180);

                button.Clicked += Button_Clicked;

                stackLayout.Children.Add(button);
            }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert($"{(sender as Button).Text}", $"{(sender as Button).Text}", "OK");
        }
    }
}
