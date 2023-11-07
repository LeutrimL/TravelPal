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
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;

namespace TravelPal
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {

        public static List<Travel> defaultTravelList = new();

        public string SignInUser { get; set; }
       

        public TravelsWindow()
        {
            InitializeComponent();
            ShowLoggedInUser();
            LoadTravels();
            Refresh();
           
            
           
           
        }

       

        public void UpdateListView(string city)
        {
            deslandinfo.Items.Add(city);
        }

        
       



        private void LoadTravels()
        {
           
            
                if (UserManager.CurrentlySignedInUser != null)
                {
                    if (UserManager.CurrentlySignedInUser is User currentUser)
                    {
                        foreach (var travel in currentUser.Travels)
                        {
                            deslandinfo.Items.Add(travel);
                        }
                    }
                    else
                    {
                        foreach (var user in UserManager.Users)
                        {
                            if (user is User)
                            {
                                foreach (var travel in ((User)user).Travels)
                                {
                                    deslandinfo.Items.Add(travel);
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Användaren är inte inloggad, vidta lämpliga åtgärder
                }
            






            //if(UserManager.CurrentlySignedInUser is User)
            //{
            //    foreach(var travel in ((User)UserManager.CurrentlySignedInUser).Travels)
            //    {
            //        deslandinfo.Items.Add(travel);
            //    }
            //}
            //else
            //{
            //    foreach(var user in UserManager.Users)
            //    {
            //        if(user is User)
            //        {
            //            foreach(var travel in ((User)user).Travels)
            //            {
            //                deslandinfo.Items.Add(travel);
            //            }
            //        }
            //    }

            //}

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

       
        private void TrvButton(object sender, RoutedEventArgs e)
        {
            AddTravelWindow addTravelWindow = new AddTravelWindow();
            addTravelWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (deslandinfo.SelectedItem is Travel selectedTravel)
            {
                // Skapa en instans av TravelDetailsWindow
                TravelDetailsWindow detailsWindow = new TravelDetailsWindow(selectedTravel);
                detailsWindow.Show();
            }



        }

        private void Remove_Click_1(object sender, RoutedEventArgs e)
        {

                if (deslandinfo.SelectedItem is Travel selectedTravel)
                {
                    if (UserManager.CurrentlySignedInUser is Admin adminUser)
                    {
                        if (adminUser != null)
                        {
                            if (UserManager.Users.FirstOrDefault(user => user is User && ((User)user).Travels.Contains(selectedTravel)) is User userAdmin)
                            {
                                userAdmin.Travels.Remove(selectedTravel);
                            }
                        }

                        //Ta bort selected Travel
                        deslandinfo.Items.Remove(selectedTravel);
                    }
                    else
                    {
                    MessageBox.Show("Only Admin can remove a Travel");
                    }
                }
        }



        private void Refresh()
        {
            deslandinfo.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();

            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
        }

  
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InfoWindow infowindow = new InfoWindow();
            infowindow.Show();
        }

        private void deslandinfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
