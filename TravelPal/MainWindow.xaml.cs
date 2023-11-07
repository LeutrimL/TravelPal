using System;
using System.Collections.Generic;
using System.Configuration;
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
    
    public partial class MainWindow : Window
    {
        public event EventHandler<Travel> TravelAdded;

        public static List<Travel> defaultTravelList = new();
        //Denna string tillhör UserDisplayn!!
        string username;

        private UserManager userManager;
        private object deslandinfo;

        public MainWindow()
        {
            InitializeComponent();

            userManager = new UserManager();
            //User adminUser = new User("admin", "password", true);
            //User user = new User("user", "password", true );

            
            InitializeUserManager();

        }



        private void InitializeUserManager()
        {

            //User newUser = new User { Username = "Username", Password = "Password" };
            //UserManager.AddUser(newUser);
        }

        private void SignIn_Clic(object sender, RoutedEventArgs e)
        {
          
           

            string username = txtBox1.Text;
            string password = txtPassword.Password;

            //Ifall man ger rätt Username och Password öppnas TraveslsWindow!!
            bool signInSuccess = UserManager.SignInUser(username, password);
            
            

            if (signInSuccess)
            {

                TravelsWindow travelsWindow = new TravelsWindow();



                //Visar Användaren som har loggat in längst upp till vänster!!
                travelsWindow.LoggedInUser(username);
                travelsWindow.Show();

                this.Close();
            }
            else
            {
                //Vid error eller fel så kommer denna upp!! 
                MessageBox.Show("Wrong Username or password");
            }



        }

            private void OpenWindow(object sender, RoutedEventArgs e)
            {
               
                //Öppnar SecondWindow/RegisterWindow!!
                SecondWindow objSecondWindow = new SecondWindow();
                this.Visibility = Visibility.Hidden;
                objSecondWindow.Show();

            }




        


    }
}

