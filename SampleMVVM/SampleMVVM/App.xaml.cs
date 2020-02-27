using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.ViewModels;
using SampleMVVM.Views;
namespace SampleMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        BookContext bookContext = new BookContext();
        private void OnStartup(object sender, StartupEventArgs e)
        {
            
            //List<Book> books = new List<Book>()
            //{
            //    new Book("Паттерны проетирования", "John Gossman", 3),
            //    new Book("CLR via C#", "Джеффри Рихтер", 2),
            //    new Book("Исскуство программирования", "Кнут", 2)
            //};
            bookContext.Books.Load();
            List<Book> books = bookContext.Books.Local.ToList();
            MainView view = new MainView(); // создали View
            MainViewModel viewModel = new MainViewModel(books); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
