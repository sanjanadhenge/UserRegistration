using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class User
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_REGX))
            {
                Console.WriteLine("Valid first name");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        public void ValidateLastName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_REGX))
            {
                Console.WriteLine("Valid last name");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
