using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal
{
    internal class Travel
    {
       

       public string Destination {  get; set; }


        public Travel(string destination)
        {
            Destination = destination;
        }

        


        public virtual string GetInfo()
        {
            return $"destination: {Destination}"; 
        }





        


    }
}
