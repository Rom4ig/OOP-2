using System.Windows;

namespace WpfApp5
{
    public partial class WindowInput : Window
    {
        public WindowInput()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

    }
}
