using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace lab8
{
    public partial class MainWindow : Window
    {
        private readonly Model1 _db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            var outter = from dict in _db.MyEntities select dict;
            Data.DataContext = outter.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           _db.Database.ExecuteSqlCommand(@"UPDATE dbo.MyEntities SET Course = Course+1");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {    
            var outter = from dict in _db.MyEntities select dict;
            Data.DataContext = outter.ToList();
        }
    }
}