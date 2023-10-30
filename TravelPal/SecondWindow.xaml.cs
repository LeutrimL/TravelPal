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

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void cbBoxLand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string newUsername = txtbxAn.Text;
            string newPassword = txtbxLo.Password; 

            if (UserManager.UsernameExists(newUsername))
            {
                MessageBox.Show("Username is taken, please choose another");
            }
            else 
            {
                User newUser = new User { Username = newUsername, Password = newPassword };
                UserManager.AddUser(newUser);

                MessageBox.Show("Account succecfully Created");

                this.Close();

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show(); 
            
            }
        }
    }
}
