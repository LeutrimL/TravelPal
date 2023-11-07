using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal
{
    internal class WorkTrip : Travel
    {
        public string MeetingDetails {  get; set; } 

        public WorkTrip(string meetingDetails, string destination, string country, int travelers) : base(destination, country, travelers)
        {
            MeetingDetails = meetingDetails;
        }

        public override string GetInfo()
        {
            return $"Destination: {City}, Meeting Details: {MeetingDetails}";
        }


        public override string ToString()
        {
            return $"Work Trip to {City}, {Country}";
        }
    }
}
