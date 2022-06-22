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
            Title = "Страница с тестами";

 
            List<string> nameTests = new List<string>() { "Тест COVID-19", "Оценка когнитивной сферы", "Шкала Вассермана", "Корректурная проба Бурдона",
                                                          "Тесты на оценку конструктивного, моторного и динамического праксиса, предметного гнозиса",
                                                          "Шкала тревоги и депрессии", "Субъективная шкала оценки астении", "Европейский опросник качества жизни",
                                                          "Шкала локуса-контроля"};

            List<ContentPage> pages = new List<ContentPage>() { new TestCOVID(), new TestCognitive(), new TestVasserman(), new TestBurdon(),
                                                                new TestPraxisAndGnosis(), new TestAnxietyAndDepression(), new TestAsthenia(),
                                                                new TestLifeQuality(), new TestLocus_control()};

            Button button = null;

            for (int i = 0; i < pages.Count; i++)
            {
                button = new Button
                {
                    TextColor = Color.Black,
                    BorderColor = Color.Gray,
                    Text = nameTests[i],
                    BackgroundColor = Color.FromRgb(255, 229, 180)
                };

                ContentPage page = pages[i];
                button.Clicked += async (sender, args) => await Navigation.PushAsync(page);

                stackLayout.Children.Add(button);
            }

        }

    }
}
