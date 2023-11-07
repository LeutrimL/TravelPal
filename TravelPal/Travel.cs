using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal
{
    public class Travel
    {

        public string City { get; set; }
        public string Country {  get; set; }
        public int Travelers { get; set; }

        public Travel(string city, string country, int travelers)
        {
            City = city;
            Country = country;
            Travelers = travelers;
        }

        public virtual string GetInfo()
        {
            return $"destination: {City}"; 
        }
    }
}
