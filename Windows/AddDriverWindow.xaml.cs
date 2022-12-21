using Gibdd.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для AddDriverWindow.xaml
    /// </summary>
    public partial class AddDriverWindow : Window
    {
        GibddEntities _context = new GibddEntities();
        public AddDriverWindow()
        {
            InitializeComponent();

            idTb.Text = (_context.Driver.FirstOrDefault(x => x.Id == _context.Driver.Max(m => m.Id)).Id + 1).ToString();
        }

        private bool checkdata()
        {
            if (surNameTb.Text == "" || surNameTb.Text.Contains(" ")
                || nameTb.Text == "" || nameTb.Text.Contains(" ")
                || middleNameTb.Text == "" || middleNameTb.Text.Contains(" ")
                || serPassportTb.Text == ""
                || nomPassportTb.Text == ""
                || townRegAddressTb.Text == "" || townRegAddressTb.Text.Contains(" ")
                || fullRegAddressTb.Text == "" || fullRegAddressTb.Text.Contains(" ")
                || townLiveAddressTb.Text == "" || townLiveAddressTb.Text.Contains(" ")
                || fullLiveAddressTb.Text == "" || fullLiveAddressTb.Text.Contains(" ")
                || phoneNumberTb.Text == "" || eMailTb.Text == "")
                return false;
            else
                return true;
        }

        private void addDriverBtn_Click(object sender, RoutedEventArgs e)
        {
            if (checkdata())
            {
                int n;
                if (int.TryParse(serPassportTb.Text, out n) && int.TryParse(nomPassportTb.Text, out n) && int.TryParse(phoneNumberTb.Text, out n))
                {
                    if (!(new EmailAddressAttribute().IsValid(eMailTb.Text)))
                    {
                        MessageBox.Show("Введите электронный адрес в формате xxx@domain.xx");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Некорректные числовые данные.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля");
                return;
            }

            Driver driver = new Driver();

            driver.Surname = surNameTb.Text;
            driver.Name = nameTb.Text;
            driver.Middle_Name = middleNameTb.Text;
            driver.Passport_Serial = Convert.ToInt32(serPassportTb.Text);
            driver.Passport_Number = Convert.ToInt32(nomPassportTb.Text);
            driver.Address = townRegAddressTb.Text + ", " + fullRegAddressTb.Text;
            driver.Address_Life = townLiveAddressTb.Text + ", " + fullLiveAddressTb.Text;
            driver.Phone = phoneNumberTb.Text;
            driver.Email = eMailTb.Text;

            if (companyNameTb.Text != null)
                driver.Company = companyNameTb.Text;
            if (jobNameTb.Text != null)
                driver.Job_Name = jobNameTb.Text;
            if (descriptionTb.Text != null)
                driver.Description = descriptionTb.Text;

            addDriverBtn.IsEnabled = false;

            _context.Driver.Add(driver);
            //_context.SaveChanges();
        }

        private void surNameTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            addDriverBtn.IsEnabled = checkdata();
        }
    }
}