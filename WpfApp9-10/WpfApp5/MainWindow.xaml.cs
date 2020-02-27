using System.Linq;
using System.Windows;
using System.Data.Entity;
using WpfApp5.NewFolder1;



namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        MobileContext db;
        //UnitToWork db;
        public MainWindow()
        {
            InitializeComponent();

            db = new MobileContext();
            //db = new UnitToWork();
            db.Phones.Load();
            phonesGrid.ItemsSource = db.Phones.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (phonesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < phonesGrid.SelectedItems.Count; i++)
                {
                    Phone phone = phonesGrid.SelectedItems[i] as Phone;
                    if (phone != null)
                    {
                        db.Phones.Remove(phone);
                    }
                }
            }
            db.SaveChanges();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            phonesGrid.ItemsSource = db.Phones.OrderBy(p => p.Price).ToList();
            phonesGrid.UpdateLayout();
            db.SaveChanges();
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            WindowInput input = new WindowInput();

            if (input.ShowDialog() == true)
            {
                phonesGrid.ItemsSource = db.Phones.Where(p => p.Title == input.wordBox.Text).ToList();
                phonesGrid.UpdateLayout();
            }
        }
    }
}
