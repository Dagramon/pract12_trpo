using pract12_trpo.Classes;
using pract12_trpo.Data.Service;

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

namespace pract12_trpo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddForm.xaml
    /// </summary>
    public partial class AddForm : Page
    {
        private UsersService _service = new();
        public User _user = new();
        bool isEdit = false;
        public AddForm(User? _editUser = null)
        {
            InitializeComponent();
            if (_editUser != null)
            {
                _user = _editUser;
                isEdit = true;
            }
            DataContext = _user;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (isEdit)
            {
                _service.Commit();
            }
            else
            {
                _service.Add(_user);
            }
            NavigationService.GoBack();
        }
    }
}
