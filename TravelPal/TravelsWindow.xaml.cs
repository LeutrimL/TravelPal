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
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        
        public string SignInUser { get; set; }  
        
        public TravelsWindow()
        {
            InitializeComponent();
            ShowLoggedInUser();
            ShowTravelSummary();
            
           
        }

        public void LoggedInUser(string username)
        {
            SignInUser = username;
            ShowLoggedInUser();

        }

        private void ShowLoggedInUser()
        {
            InloggedUserName.Content = "User:  " + SignInUser;
        }

        private void ShowTravelSummary()
        {
            List<Vacation> vacations = new();

            vacations.Add(new Vacation("London", true));
            vacations.Add(new Vacation("New York", false));

            deslandinfo.ItemsSource = vacations;
        }

        private void TrvButton(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new AddTravelWindow();
            addTravelWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TravelDetailsWindow detailsWindow = new TravelDetailsWindow();
            detailsWindow.Show();
        }
    }
}
