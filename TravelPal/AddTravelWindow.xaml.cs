using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for AddTravelWindow.xaml
    /// </summary>
    public partial class AddTravelWindow : Window
    {

        public event EventHandler<Travel> TravelAdded;

        List<TravelInfo> travelList = new List<TravelInfo>();



        public AddTravelWindow()
        { 
            InitializeComponent();

            List<string> purposes = new List<string>() { "Work trip", "Vacation" };

            cbPurpose.ItemsSource = purposes;

            //OnTravelAdded();

            List<string> countries = new List<string>
            {
                "Sweden",
                "Albania",
                "Norway",
                "Danmark",
                "Estland",
                "Croatia",
                "Taiwan",
                "Finland",
                "England",
                "China",
                "India",
                "Egypt",
                "Brazil",
                "Colombia",
                "Bosnia",
                "Germany",
                "Netherlands",
                "Austria",
                "Grecce",
                "Turkey"                // Lägg till fler länder här
            };

           
            cbCountry.ItemsSource = countries;
        }


       
        private void Saved_Click(object sender, RoutedEventArgs e)
        {
            

            string city = txtCity.Text;
            string country = txtCountry.Text;
            string meetingdetails = txtMeetingDetails.Text;
            string travelers = txtTravelers.Text;
            bool allInclusive = (bool)chkAllInclusive.IsChecked;

            // Har vi valt worktrip eller vacation?

            string purpose = (string)cbPurpose.SelectedItem;

            if(purpose == "Work trip")
            {
                // Gör en work trip
                WorkTrip newWorkTrip = new(meetingdetails, city, country, int.Parse(travelers));

                ((User)UserManager.CurrentlySignedInUser).Travels.Add(newWorkTrip);
            }
            else if(purpose == "Vacation")
            {
                // Gör en vacation
                Vacation newVacation = new(city, allInclusive, country, int.Parse(travelers));

                ((User)UserManager.CurrentlySignedInUser).Travels.Add(newVacation);

            }

            TravelsWindow travelsWindow = new();
            travelsWindow.Show();
            Close();
            this.Close();

            

           
            
        }

        private TravelInfo ConvertToTravelInfo(Travel newTravel)
        {
            return new TravelInfo
            {
                
                City = newTravel.City,
                Country = newTravel.Country,
                
            };
        }

        public void OnTravelAdded()
        {
            TravelInfo newTravel = new();


            travelList.Add(newTravel); 
        }

        public void cbPurpose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPurpose = (string)cbPurpose.SelectedItem;

            if (selectedPurpose != null)
            {
                if (selectedPurpose  == "Vacation")
                {
                    chkAllInclusive.Visibility = Visibility.Visible;
                    txtMeetingDetails.Visibility = Visibility.Collapsed;
                    
            

                }
                else if (selectedPurpose == "WorkTrip")
                {
                    chkAllInclusive.Visibility = Visibility.Collapsed;
                    txtMeetingDetails.Visibility = Visibility.Visible;
                }
                else
                {
                    chkAllInclusive.Visibility = Visibility.Collapsed;
                    txtMeetingDetails.Visibility = Visibility.Collapsed;
                }
            }
            

        }



    }
}
