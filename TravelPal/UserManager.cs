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

        public static List<IUser> users { get; set; } = new List<IUser>();

        internal static List<IUser> GetUsers()
        {
            return users;
        }

        public static void removeUser(IUser user)
        {
            if (user !=null && users.Contains(user))
            {
                users.Remove(user);
            }
        } 

        public static bool SignInUser(string username, string password)
        {
            foreach (IUser user in users)
            {
                if (user.Username == username && user.Password == password)
                { 
                    return true;
                }
            }
            return false; 
        }

        public static bool AddUser(User user)
        {
            if (user !=null)
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        public static bool UsernameExists(string username)
        {
            return users.Any(User => User.Username == username);
        }

    }
}

