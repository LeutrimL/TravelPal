﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Interface;

namespace TravelPal
{
    internal class Admin : IUser
    {
        public string? Username { get; set; }
        public string? Password { get; set; }


        public Admin(string adminusername, string adminpassword)
        {
            Username = adminusername;
            Password = adminpassword;
        }

    }
}
