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
    /// Interaction logic for ChooseEditView.xaml
    /// </summary>
    public partial class ChooseEditView : Window
    {
        public ChooseEditView()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditUserView editUserView = new EditUserView();
            editUserView.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditRoomView editRoomView = new EditRoomView();
            editRoomView.Show();
            Close();
        }
    }
}
