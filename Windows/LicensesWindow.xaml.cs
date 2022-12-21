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
    /// Логика взаимодействия для LicensesWindow.xaml
    /// </summary>
    public partial class LicensesWindow : Window
    {
        db.GibddEntities _context = new db.GibddEntities();
        db.License _selectedlicense = new db.License();
        public LicensesWindow()
        {
            InitializeComponent();
            LicensesList.ItemsSource = _context.License.OrderBy(x => x.Id).ToList();
            LicensesList.SelectionChanged += LicensesList_SelectionChanged;
        }

        private void LicensesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedlicense = LicensesList.SelectedItem as db.License;
            if(_selectedlicense != null)
            {
                AboutBtn.Visibility = Visibility.Visible;
            }
        }

        private void RegistrateBtn_Click(object sender, RoutedEventArgs e)
        {
            using (db.GibddEntities ent = new db.GibddEntities())
            {
                List<db.Driver> t = ent.Driver.Select(x => x).Where(x => x.License.Count==0).ToList();
                if (t.Count == 0)
                    MessageBox.Show("У всех водителей в системе есть водительские удостоверения");
                else
                {
                    AddLicenseWindow ALWindow = new AddLicenseWindow(t);
                    ALWindow.Show();
                    this.Close();
                }
            }
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConfiscatedBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
