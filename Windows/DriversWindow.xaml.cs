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
using db = Gibdd.Models;

namespace Gibdd.Windows
{
    /// <summary>
    /// Логика взаимодействия для DriversWindow.xaml
    /// </summary>
    public partial class DriversWindow : Window
    {
        public DriversWindow()
        {
            InitializeComponent();
            using (db.GibddEntities ent = new db.GibddEntities())
            {
                List<db.Driver> drivers = ent.Driver.ToList();
                DriversList.ItemsSource = drivers.Select(x => x.FullName).ToList();
            }
        }

        private void imgDriverBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
