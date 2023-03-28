using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Select option \n 1. First Name \n 2.Last Name \n 3.Mobile Number \n 4.Mail ID \n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string first = Console.ReadLine();
                        user.ValidateFirstName(first);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string last = Console.ReadLine();
                        user.ValidateLastName(last);
                        break;
                    case 3:
                        Console.WriteLine("Enter Mobile Number");
                        string Number = Console.ReadLine();
                        user.ValidateMobile(Number);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mail ID");
                        string Mail = Console.ReadLine();
                        user.ValidateMailID(Mail);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
