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
        public static string Mail_ID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string Password = "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
        public static string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
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
        public void ValidateMailID()
        {
           for (int i = 0; i < arr.Length; i++)
           {
                string word = arr[i];
                if (Regex.IsMatch(word, Mail_ID))
                {
                    Console.WriteLine("Valid----->" + word);
                }
                else
                {
                    Console.WriteLine("Invalid------>" + word);
                }
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
