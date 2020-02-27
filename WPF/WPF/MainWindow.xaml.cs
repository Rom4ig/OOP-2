using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Regex regex = new Regex(@"^[37525]");
            string valid = validate.Text;
            string pattern = @"^\+375256|^\+375257|^\+375259";
            if (Regex.IsMatch(valid, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Nice");
            }
            else MessageBox.Show("Error. Check Number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
