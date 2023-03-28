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
        public static string MOBILENUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string Mail_ID = "^[0-9a-zA-Z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z][.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string Password = "^[a-zA-Z0-9]{8,}$";
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
        public void ValidateMobile(string Mobile)
        {
            if (Regex.IsMatch((string)Mobile, MOBILENUMBER))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidateMailID(string Mail)
        {
            if (Regex.IsMatch((string)Mail, MOBILENUMBER))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void ValidatePass(string Pass)
        {
            if (Regex.IsMatch((string)Pass, Password))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
