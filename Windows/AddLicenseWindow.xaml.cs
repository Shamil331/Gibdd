using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using db = Gibdd.Models;
namespace Gibdd.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddLicenseWindow.xaml
    /// </summary>
    public partial class AddLicenseWindow : Window
    {
        List<db.Driver> _drivers;
        db.GibddEntities _context = new db.GibddEntities();
        public AddLicenseWindow(List<db.Driver> drivers)
        {
            InitializeComponent();
            _drivers = drivers;
            DriversList.ItemsSource = _drivers.ToList();
            DriversList.DisplayMemberPath = "FullName";
            CategoriesList.ItemsSource = _context.Categories.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            _context.License.Add(new db.License()
            {
                License_Date = DateTime.Now,
                Expire_Date = DateTime.Now.AddYears(Convert.ToInt32(ExpireYearsTb.Text)),
                License_Series = Convert.ToInt32(SerialTb.Text),
                License_Number = Convert.ToInt32(NumberTb.Text),
                Driver_Id = (DriversList.SelectedItem as db.Driver).Id
            });
            _context.SaveChanges();
            foreach(var i in _categories)
            {
                _context.License_Categories.Add(new db.License_Categories()
                {
                    License_Id = _context.License.Max(x => x.Id),
                    Categorie_Id = i.Id
                });
            }
            _context.SaveChanges();
            LicensesWindow LW = new LicensesWindow();
            LW.Show();
            this.Close();
        }
        List<db.Categories> _categories= new List<db.Categories>();
        private void CategoriesCbx_Checked(object sender, RoutedEventArgs e)
        {
            string SelectedCategoryName = (sender as CheckBox).Content.ToString();
            _categories.Add(_context.Categories.Where(x => x.Name == SelectedCategoryName).FirstOrDefault());

        }
    }
}
