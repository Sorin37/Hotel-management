﻿using Hotel_management.Viewmodels;
using Hotel_management.Views;
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

namespace Hotel_management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var foundUser = (DataContext as LoginVM).Users.FirstOrDefault(
                x => x.name == (DataContext as LoginVM).Username &&
                x.password == (DataContext as LoginVM).Password);
            if (foundUser != null)
            {
                BrowseRooms br = new BrowseRooms(foundUser);
                br.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect authentification credentials!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SignInWindow sw = new SignInWindow();
            sw.Show();
        }
    }
}
