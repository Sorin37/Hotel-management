using Hotel_management.Viewmodels;
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

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for BrowseRooms.xaml
    /// </summary>
    public partial class BrowseRooms : Window
    {
        public BrowseRooms(User currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            (DataContext as BrowseRoomsVM).CurrentUser = new User()
            {
                id = currentUser.id,
                name = currentUser.name,
                password = currentUser.password,
                type = currentUser.type,
                deleted = currentUser.deleted,
            };
        }
    }
}
