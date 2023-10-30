using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TravelPal.Interface;


namespace TravelPal
{
    internal static class UserManager
    {

        public static List<User> Users { get; set; } = new List<User>();

        internal static List<User> GetUsers()
        {
            return Users;
        }

        public static void RemoveUser(User user)
        {
            if (user !=null && Users.Contains(user))
            {
                
                Users.Remove(user);
            }
        } 

        public static bool SignInUser(string username, string password)
        {
          
            foreach (User user in Users)
            {

                Console.WriteLine($"Checking User: {user.Username}, Password: {user.Password}");

                if (user.Username == username && user.Password == password)
                { 
                    return true;
                }
            }
            return false; 
        }

        public static bool AddUser(User user)
        {
            //Ifall lösenordet är 0 eller tomt, retunera en varning!
            if (user !=null && !string.IsNullOrEmpty(user.Password))
            {
                Users.Add(user);
                return true;
            }
            return false;
        }

        public static bool UsernameExists(string username)
        {
            return Users.Any(User => User.Username == username);
        }

    }
}

