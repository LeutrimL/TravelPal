using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();

            List<string> countries = new List<string>
        {
            "Albania",
            "Sweden",
            "Kosovo",
            "France",
            "Austraila",
            "Croatia",
            "Norway",
            "Danmark"
            // ifall det behövs fler länder, så lägger ni till dom här!
        };

            
            cbBoxLand.ItemsSource = countries;


        }

        private void cbBoxLand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtbxAn.Text == "Username" && txtbxLo.Password == "Password")
            {
                this.DialogResult = true;
            }
            else
            {
                MessageBox.Show("Incorrect Username or password", "Error", MessageBoxButton.OK);
            }; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtbxAn.Text.Length == 0)
            {
                MessageBox.Show("You need to write a valid Username");
            }
            else if (!Regex.IsMatch(txtbxAn.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                
                txtbxAn.Select(0, txtbxAn.Text.Length);
                txtbxAn.Focus();
            }
            else
            {
                string Username = txtbxAn.Text;
                string Password = txtbxLo.Password;
                if (Password.Length == 0)
                {
                    MessageBox.Show("Incorrect Username or password", "Error", MessageBoxButton.OK);

                }
            }


        }
    }
};


