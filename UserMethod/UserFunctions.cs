using System.Text.RegularExpressions;

namespace UserMethod
{
    public class UserFunctions
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public static string Mail_ID = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]+[@]{1}[a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILENUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string Password = "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
        // public static string Mail_ID = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]";
        public string ValidateFirstName(string firstName)
        {
            try
            {

                if (Regex.IsMatch(firstName, NAME_REGX))
                {
                    return "valid";
                }

            }
            catch (Exception)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID, "Invalid");
            }

            return "";
            

        }
        public string ValidateLastName(string lastName)
        {
            try
            {

                if (Regex.IsMatch(lastName, NAME_REGX))
                {
                    return "valid";
                }

            }
            catch (Exception)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID, "Invalid");
            }

            return "";
        }
        public string ValidateMailID(string mail)
        {
            try
            {

                if (Regex.IsMatch(mail, Mail_ID))
                {
                    return "valid";
                }

            }
            catch (Exception)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID, "Invalid");
            }

            return "";

        }

        public string ValidateMobile(string Mobile)
        {
            try
            {

                if (Regex.IsMatch(Mobile, MOBILENUMBER))
                {
                    return "valid";
                }

            }
            catch (Exception)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID, "Invalid");
            }

            return "";
        }
        public string ValidatePass(string Pass)
        {
            try
            {

                if (Regex.IsMatch(Pass, Password))
                {
                    return "valid";
                }

            }
            catch (Exception)
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID, "Invalid");
            }

            return "";
        }
        public string ValidateMailIDArray(string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                if (Regex.IsMatch(word, Mail_ID))
                {
                    return "valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            return "";

        }


    }
}
