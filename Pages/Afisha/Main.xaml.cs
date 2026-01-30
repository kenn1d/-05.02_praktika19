using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Classes;

namespace WpfApp1.Pages.Afisha
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        List<AfishaContext> AllAfishas = AfishaContext.Select();
        public Main()
        {
            InitializeComponent();

            foreach (AfishaContext item in AllAfishas)
            {
                parent.Children.Add(new Items.Item(item, this));
            }
        }

        private void AddRecord(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Afisha.Add());
        }
    }
}
