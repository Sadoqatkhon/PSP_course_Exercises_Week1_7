using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP_course_Exercise_Week1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*              
             * Ask user to enter password, and store
             * Ask user to enter password again , and store
             * Check if they are both contain something
                *if so check if they are the same
                    *if they are, print "Password match"
                    *if they are not , print "Passwords don't match"
                *If they are empty, print "Please enter a password"
             */

            ////---------------------------
            ////version of YouTube Tutorial

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Enter password again");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Password match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("please enter 6 or more characters");
                    }

                }
                else
                {
                    Console.WriteLine("Enter password confirmation again");
                }
            }
            else
            {
                Console.WriteLine("Enter password again");
            }
        }

    }

}



