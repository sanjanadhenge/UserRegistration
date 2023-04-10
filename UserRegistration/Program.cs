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
            UsingLambdaFunction usingLambdaFunction = new UsingLambdaFunction();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Select option \n 1. First Name \n 2.Last Name \n 3.Mobile Number \n 4.Mail ID \n 5.PassWord \n 6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string first = Console.ReadLine();
                        //user.ValidateFirstName(first);
                      bool flag2=  usingLambdaFunction.ValidFirstNameLamba(first);
                        Console.WriteLine(flag2);
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string last = Console.ReadLine();
                        // user.ValidateLastName(last);
                       bool flag3= usingLambdaFunction.ValidLastNameLamba(last);
                       Console.WriteLine(flag3);
                        break;
                    case 3:
                        Console.WriteLine("Enter Mobile Number");
                        string Number = Console.ReadLine();
                        bool flag4= usingLambdaFunction.ValidMobileLamba(Number);
                        // user.ValidateMobile(Number);
                        Console.WriteLine(flag4);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mail ID");
                        string Mail = Console.ReadLine();
                        bool flag5 = usingLambdaFunction.ValidMailLamba(Mail);
                        Console.WriteLine(flag5);
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string pass = Console.ReadLine();
                        //user.ValidatePass(pass);
                        bool flag6 = usingLambdaFunction.ValidPasswordLamba(pass);
                        Console.WriteLine(flag6);
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
