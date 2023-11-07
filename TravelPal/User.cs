using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Interface;

namespace TravelPal
{
    public class User : IUser
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public List<Travel> Travels { get; set; } = new List<Travel>();

        public User(string adminusername, string adminpassword) 
        {
            Username = adminusername;
            Password = adminpassword;
        }

    }
  
}

