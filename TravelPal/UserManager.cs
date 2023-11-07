using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TravelPal.Interface;


namespace TravelPal 
{
    public class UserManager 
    {

        public static List<IUser> Users { get; set; } = new List<IUser>()
        {
            new Admin("admin", "password"),
            new User("user", "password")
            {
                Travels = new List<Travel>()
                {
                    new WorkTrip("Meeting with new Sponsors", "London", "England", 2),
                    new Vacation("Split", true, "Croatia", 4),
                }
            }
        };

        public static IUser CurrentlySignedInUser { get; set; }






        private static List<User> users;

        

        internal static List<IUser> GetUsers()
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
          
            foreach (IUser user in Users)
            {

                Console.WriteLine($"Checking User: {user.Username}, Password: {user.Password}");

                if (user.Username == username && user.Password == password)
                {
                    CurrentlySignedInUser = user;
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

