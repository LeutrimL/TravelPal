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

        public WorkTrip(string meetingDetails, string destination) : base(destination)
        {
            MeetingDetails = meetingDetails;
        }

        public override string GetInfo()
        {
            return $"Destination: {Destination}, Meeting Details: {MeetingDetails}";
        }
    }
}
