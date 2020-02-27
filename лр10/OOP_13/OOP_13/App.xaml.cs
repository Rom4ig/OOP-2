using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_11
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            List<Theatre> companies = new List<Theatre>()
        {
            new Theatre(1, "им. Я.Купалы ", DayOfWeek.Monday , 200),
            new Theatre(2, "   Оперный   ",  DayOfWeek.Monday, 250),
            new Theatre(3, "Музыкальный",  DayOfWeek.Tuesday, 198),
            new Theatre(4, " Молодежный ",  DayOfWeek.Sunday, 198),
            new Theatre(5, "им. Горького ", DayOfWeek.Saturday, 5)
        };
            MainView mainview = new MainView();
            MainViewModel model = new MainViewModel(companies);
            mainview.DataContext = model;
            mainview.Show();
        }
    }
}
