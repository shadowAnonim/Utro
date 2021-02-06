using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using utro.Pages;

namespace utro.Images
{
    /// <summary>
    /// Interaction logic for AutorisationPage.xaml
    /// </summary>
    public partial class AutorisationPage : Page
    {
        public AutorisationPage()
        {
            InitializeComponent();
        }

        private void autorisationBtn_Click(object sender, RoutedEventArgs e)
        {
            MsHelp.db.user.Load();
            var user = MsHelp.db.user.FirstOrDefault(el => el.login == loginTb.Text && el.password == passwordTb.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден в базе данных");
                return;
            }
            loginTb.Text = "";
            passwordTb.Text = "";
            switch(user.role)
            {
                case 1:
                    NavigationService.Navigate(new CustomerPage());
                    break;
                case 2:
                    NavigationService.Navigate(new ManagerPage());
                    break;
                case 3:
                    NavigationService.Navigate(new StorekeeperPage());
                    break;
                case 4:
                    NavigationService.Navigate(new DirectorPage());
                    break;
            }
        }

        private void registrationBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
