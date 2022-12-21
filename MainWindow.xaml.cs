using System.Windows;

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
        }

        private void LicensesBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.LicensesWindow licensesWindow = new Windows.LicensesWindow();
            licensesWindow.Show();
            this.Close();
        }

        private void DriversBtn_Click(object sender, RoutedEventArgs e)
        {
            Windows.DriversWindow driversWindow = new Windows.DriversWindow();
            driversWindow.Show();
            this.Close();
        }

        private void PenaltiesBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
