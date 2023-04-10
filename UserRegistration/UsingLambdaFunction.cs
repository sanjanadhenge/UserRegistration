using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UsingLambdaFunction
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public static string MOBILENUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string Mail_ID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string Password = "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
        public bool ValidFirstNameLamba(string firstName)=>Regex.IsMatch(firstName, NAME_REGX) ? true: false;
        public bool ValidLastNameLamba(string lastName) => Regex.IsMatch(lastName, NAME_REGX) ? true : false;
        public bool ValidMobileLamba(string Mobile) => Regex.IsMatch(Mobile, NAME_REGX) ? true : false;
        public bool ValidMailLamba(string Mail) => Regex.IsMatch(Mail, NAME_REGX) ? true : false;
        public bool ValidPasswordLamba(string Pass) => Regex.IsMatch(Pass, NAME_REGX) ? true : false;

    }
}
