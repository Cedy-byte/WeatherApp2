using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Login
    {
        // Variable declaration
        private string username;
        private string password;
        private string userType;

        // Constructor
        public Login(string username, string password, string userType)
        {
            this.Username = username;
            this.Password = password;
            this.UserType = userType;
        }

        // Get and Set methods
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserType { get => userType; set => userType = value; }
    }
}
