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
                Console.WriteLine("Select option \n 1. First Name \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string first = Console.ReadLine();
                        user.ValidateFirstName(first);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
