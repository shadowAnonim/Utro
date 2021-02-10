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
using utro.Images;
using utro.Pages;

namespace utro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is AutorisationPage)
            {
                backBtn.Visibility = Visibility.Hidden;
                exitBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                backBtn.Visibility = Visibility.Visible;
                exitBtn.Visibility = Visibility.Visible;
            }
            if (e.Content is RegistrationPage) 
                exitBtn.Visibility = Visibility.Hidden;
            formName.Content = (e.Content as Page).Title;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            frame.GoBack();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AutorisationPage());
        }
    }
}
