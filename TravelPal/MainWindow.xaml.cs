﻿using System;
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
using TravelPal.Interface;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            InitializeUserManager();
        }

        private void InitializeUserManager()
        {

            User newUser = new User { Username = "Username", Password = "Password" };
            UserManager.AddUser(newUser);

        }

        private void SignIn_Clic(object sender, RoutedEventArgs e)
        {
            string username = txtBox1.Text;
            string password = txtPassword.Password;

            bool signInSuccess = UserManager.SignInUser(username, password);

            if (signInSuccess)
            {

                this.Close();
                TravelsWindow travelsWindow = new TravelsWindow();
                travelsWindow.Show();

            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }


            private void OpenWindow(object sender, RoutedEventArgs e)
            {
                SecondWindow objSecondWindow = new SecondWindow();
                this.Visibility = Visibility.Hidden;
                objSecondWindow.Show();

            }

        
    }
}

