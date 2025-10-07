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

            bool isPasswordMatch = false; ;
            do
            {
                Console.Write("Enter a password: ");
                string password1 = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter the password again: ");
                string password2 = Console.ReadLine();

                Console.WriteLine();

                if (password1 != string.Empty && password2 != string.Empty)
                {
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
                }

            } while (!isPasswordMatch);
        }
    }
}
