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
                *Ask the user to enter their password, then request it again for confirmation.
                *If the two entered passwords match,
                *acknowledge with a message displayed in green. 
                *Otherwise, show an error message in red.
             */

            ////version 2.0

            bool isPasswordMatch = false;
            string password1, password2 = null;
            do
            {
                do
                {
                    Console.Write("Enter  password: ");
                    password1 = Console.ReadLine();
                    Console.WriteLine();


                } while (password1.Equals(string.Empty));

                do
                {
                    Console.Write("Enter the password again: ");
                    password2 = Console.ReadLine();
                    Console.WriteLine();


                } while (password2.Equals(string.Empty));

                if (password1.Equals(password2))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Passwords match !");
                    isPasswordMatch = true;
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Passwords don't match !");
                    Console.ResetColor();
                    Console.WriteLine();
                }

            } while (!isPasswordMatch);
        }
    }
}
