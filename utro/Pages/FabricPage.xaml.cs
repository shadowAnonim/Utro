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

namespace utro.Pages
{
    /// <summary>
    /// Interaction logic for FabricPage.xaml
    /// </summary>
    public partial class FabricPage : Page
    {
        public FabricPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MsHelp.db.fabric.Load();
            fabricDataGrid.ItemsSource = MsHelp.db.fabric.ToList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var select = fabricDataGrid.SelectedItem as fabric;
            if (select == null)
                MessageBox.Show("Выберите запись");
            MsHelp.db.fabric.Remove(select);
            MsHelp.db.SaveChanges();
            Page_Loaded(null, null);
        }
    }
}