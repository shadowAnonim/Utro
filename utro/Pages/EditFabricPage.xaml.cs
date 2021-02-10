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
    /// Interaction logic for EditFabricPage.xaml
    /// </summary>
    public partial class EditFabricPage : Page
    {
        private int errorCnt;
        private fabric _obj;
        private bool edit = true;
        public EditFabricPage(fabric obj)
        {
            InitializeComponent();
            if (obj == null)
            {
                articleTextBox.IsReadOnly = false;
                _obj = new fabric();
                edit = false;
            }
            else
            {
                articleTextBox.IsReadOnly = true;
                _obj = obj;
                edit = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MsHelp.db.fabric.Load();
            grid1.DataContext = _obj;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            if (errorCnt > 0)
            {
                MessageBox.Show("Ошибка");
                return;
            }
            if (!edit) MsHelp.db.fabric.Add(_obj);
            MsHelp.db.SaveChanges();
            NavigationService.GoBack();
        }

        private void grid1_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errorCnt++;
            else
                errorCnt--;
        }
    }
}
