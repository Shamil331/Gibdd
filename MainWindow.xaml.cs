using Gibdd.Windows;
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

namespace Gibdd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddDriverWindow window = new AddDriverWindow();
            window.Show();
        }

        private void LicensesBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.LicensesWindow licensesWindow = new Windows.LicensesWindow();
            licensesWindow.Show();
            this.Close();
        }

        private void DriversBtn_Click(object sender, RoutedEventArgs e)
        {
            DriversWindow window = new DriversWindow();
            window.Show();
        }

        private void PenaltiesBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
