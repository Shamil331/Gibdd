using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using db = Gibdd.Models;

namespace Gibdd.Windows
{
    /// <summary>
    /// Логика взаимодействия для DriversWindow.xaml
    /// </summary>
    public partial class DriversWindow : Window
    {
        db.Driver _driver = new db.Driver();
        db.GibddEntities _context= new db.GibddEntities();
        public DriversWindow()
        {
            InitializeComponent();
            RefreshList();
        }
        private void RefreshList()
        {

            DriversList.ItemsSource = _context.Driver.ToList();
            DriversList.DisplayMemberPath = "FullName";
        }
        private void DriversList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _driver = DriversList.SelectedItem as db.Driver;
            surNameTb.Text = _driver.Surname;
            nameTb.Text = _driver.Name;
            middleNameTb.Text = _driver.Middle_Name;
            serPassportTb.Text = _driver.Passport_Serial.ToString();
            nomPassportTb.Text=_driver.Passport_Number.ToString();
            townRegAddressTb.Text = _driver.Address;
            townLiveAddressTb.Text = _driver.Address_Life;
            fullComnpanyNameTb.Text = _driver.Company;
            jobNameTb.Text = _driver.Job_Name;
            phoneNumberTb.Text = _driver.Phone;
            emailTb.Text = _driver.Email;
        }

        private void editDriverBtn_Click(object sender, RoutedEventArgs e)
        {
            _context.Driver.Attach(_driver);
            _driver.Surname = surNameTb.Text;
            _driver.Name = nameTb.Text;
            _driver.Middle_Name = middleNameTb.Text;
            _driver.Passport_Serial = Convert.ToInt32(serPassportTb.Text);
            _driver.Passport_Number = Convert.ToInt32(nomPassportTb.Text);
            _driver.Address = townRegAddressTb.Text;
            _driver.Address_Life=townLiveAddressTb.Text;
            _driver.Company = fullComnpanyNameTb.Text;
            _driver.Job_Name=jobNameTb.Text;
            _driver.Phone=phoneNumberTb.Text;
            _driver.Email=emailTb.Text;
            _context.SaveChanges();
            RefreshList();
        }
    }
}
