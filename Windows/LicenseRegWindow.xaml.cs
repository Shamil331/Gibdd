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
using db=Gibdd.Models;

namespace Gibdd.Windows
{
    /// <summary>
    /// Логика взаимодействия для LicenseRegWindow.xaml
    /// </summary>
    public partial class LicenseRegWindow : Window
    {
        List<db.Driver> _drivers;
        public LicenseRegWindow(List<db.Driver> drivers)
        {
            InitializeComponent();
            _drivers = drivers;
        }
    }
}
