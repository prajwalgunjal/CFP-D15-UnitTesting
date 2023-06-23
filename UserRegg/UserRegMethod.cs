using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegg
{
    public class UserRegMethod
    {
        public bool FirstName(string name)
        {
            Regex Checkname = new Regex("^[A-Z][a-z]{2,}");
            Match match = Checkname.Match(name);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool LastName(string name)
        {
            Regex CheckLname = new Regex("^[A-Z][a-z]{2,}");
            if (CheckLname.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Email(string email)
        {
            Regex CheckEmail = new Regex("^\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}\\b");

            if (CheckEmail.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Phone(string phno)
        {
            //Regex Phone = new Regex("^\\+\\d{1,3}\\s?(\\(\\d{1,3}\\))?\\s?\\d{1,4}\\s?\\d{1,4}\\s?\\d{1,9}$");
            Regex Phone = new Regex("^(\\+?\\d{1,3})\\s\\d{10}$");

            if (Phone.IsMatch(phno))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Password(string password)
        {
            Regex CheckPassword = new Regex("^[A-Za-z]{8,}$");

            if (CheckPassword.IsMatch(password))
            {
                return true;            }
            else
            {
                return false;            }
        }
    }
}
