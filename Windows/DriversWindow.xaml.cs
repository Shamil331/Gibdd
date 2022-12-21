using Gibdd.Models;
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
using System.Windows.Shapes;

namespace Gibdd.Windows
{
    /// <summary>
    /// Логика взаимодействия для DriversWindow.xaml
    /// </summary>
    public partial class DriversWindow : Window
    {
        GibddEntities _context = new GibddEntities();
        public DriversWindow()
        {
            InitializeComponent();
            driversLbx.ItemsSource = _context.Driver.ToList();
            driversLbx.DisplayMemberPath = "fullName";
        }

        private void imgDriverBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ASdasd");
        }

        private void driversLbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Driver driver = driversLbx.SelectedItems[0] as Driver;
            surNameTb.Text = driver.Surname;
        }
    }
}
