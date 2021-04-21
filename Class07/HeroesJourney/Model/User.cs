using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesJourney.Model
{
    public class User
    {
        private string Email { get; set; }
        private string Password { get; set; }

        public User()
        {

        }

        public User(string email, string pass)
        {
            Email = email;
            Password = pass;
        }

        public string GetEmail()
        {
            return Email;
        }

        public string GetPassword()
        {
            return Password;
        }


    }
}
