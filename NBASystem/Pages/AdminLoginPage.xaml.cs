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

namespace NBASystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminLoginPage.xaml
    /// </summary>
    public partial class AdminLoginPage : Page
    {
        public AdminLoginPage()
        {
            InitializeComponent();
            if(Properties.Settings.Default.Login != null && Properties.Settings.Default.Password != null)
            {
                LoginTb.Text = Properties.Settings.Default.Login;
                PasswrodPB.Password = Properties.Settings.Default.Password;
                CbSave.IsChecked = true;
            }
        }
        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            if( App.DB.Admin.FirstOrDefault(x=>x.Email == LoginTb.Text) == null)
            {
                return;
            }
            if (App.DB.Admin.FirstOrDefault(x => x.Passwords == PasswrodPB.Password) == null)
            {
                return;
            }
            if(CbSave.IsChecked == true)
            {
                Properties.Settings.Default.Login = LoginTb.Text;
                Properties.Settings.Default.Password = PasswrodPB.Password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Login = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.Save();
            }
            SelectAdminWindow selectAdmin = new SelectAdminWindow();
            selectAdmin.ShowDialog();
        }
        private void BTCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
