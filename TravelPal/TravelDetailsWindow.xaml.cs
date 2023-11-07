using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Interaction logic for TravelDetailsWindow.xaml
    /// </summary>
    public partial class TravelDetailsWindow : Window
    {
        public TravelDetailsWindow(Travel selectedTravel)
        {
            InitializeComponent();



                if (selectedTravel is WorkTrip workTrip)
                {
                    // Visa detaljer för WorkTrip i textboxes i TravelDetailsWindow
                    CityTextBox.Text = workTrip.City;
                    CountryTextBox.Text = workTrip.Country;
                    TravelersTextBox.Text = workTrip.Travelers.ToString();
                    MeetingDetailsTextBox.Text = workTrip.MeetingDetails;

                    
                }
                else if (selectedTravel is Vacation vacation)
                {
                    // Visa detaljer för Vacation i textboxes i TravelDetailsWindow
                    CityTextBox.Text = vacation.City;
                    CountryTextBox.Text = vacation.Country;
                    TravelersTextBox.Text = vacation.Travelers.ToString(); // Replace 'NumberOfTravelers' with the correct property name
                    AllInclusiveCheckBox.IsChecked = vacation.AllInclusive;

                    
                }
            
        }
    }
}


