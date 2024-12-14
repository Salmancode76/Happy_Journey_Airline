using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Journey_Airline.Backend
{
    internal static class GlobalUser
    {
        // The static property to hold the logged-in user.
        public static User LoggedInUser { get; set; }

        // A static property to check if the user is logged in or not.
        public static bool IsLoggedIn => LoggedInUser != null;
    }
}
