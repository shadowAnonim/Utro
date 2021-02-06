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

namespace utro.Pages
{
    /// <summary>
    /// Interaction logic for StorekeeperPage.xaml
    /// </summary>
    public partial class StorekeeperPage : Page
    {
        public StorekeeperPage()
        {
            InitializeComponent();
        }

        private void fabricBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FabricPage());
        }
    }
}
