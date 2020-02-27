using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace _7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding myBind = new CommandBinding(RCommands.myCommand);
            myBind.Executed += CommandBinding_Executed;//вызвано
            CommandBindings.Add(myBind);//добавление в список команд
        }

        private void Click_to_Check(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["iPhone6s"]; // получаем ресурс по ключу
            MessageBox.Show(phone.Price.ToString() + "\nTouch Escape or Alt + Q");
        }

        private void bubbling_events(object sender, MouseButtonEventArgs e)
        {
            bubbling_events_text.Text = bubbling_events_text.Text + "sender: " + sender.ToString() + "\n";
            bubbling_events_text.Text = bubbling_events_text.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void tunneling_events(object sender, MouseButtonEventArgs e)
        {
            tunneling_events_text.Text = tunneling_events_text.Text + "sender: " + sender.ToString() + "\n";
            tunneling_events_text.Text = tunneling_events_text.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void Attached_events(object sender, RoutedEventArgs e)
        {
            RadioButton selectedButton = (RadioButton)e.Source;
            Attached_events_text.Text = "You choose: " + selectedButton.Content.ToString(); 
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Demonstration of a command based on RoutedUICommand");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
