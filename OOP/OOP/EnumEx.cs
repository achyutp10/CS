using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class EnumEx
    {
        /*
     * Create an enum for days of the week
     * Create variable with new enum type and assign a day of the week to it
         * Print it to the screen and see what you get
     * 
     * Start the enum value Mon at 1, instead of the default 0
     * 
     * Write some code to ask the user to input a day
     * Then use *something* to convert it to the new enum value
     * Print the enum value to the screen to make sure it works
     * 
     * Extra: add Invalid value in enum
     * So if the user inputs it wrong, it shows invalid
     * 
    */
        class Program
        {
            public enum Days
            {
                Invalid,
                Mon,
                Tue,
                Wed,
                Thu,
                Fri,
                Sat,
                Sun
            }
            static void Main(string[] args)
            {
                /*Days day = Days.Mon;
                Console.WriteLine(day);
                Console.WriteLine(Convert.ToInt32(day));*/

                /*Console.Write("Enter a day: ");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, out Days day))
                {
                    if (!Enum.IsDefined(typeof(Days), day))
                    {
                        day = 0;
                    }
                }*/

                Days day = GetDay();
                Console.WriteLine(day);

                /*if (day != Days.Invalid)
                {
                    Console.WriteLine(day);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }*/

                Console.ReadLine();
            }
            static Days GetDay()
            {
                Console.Write("Enter a day: ");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, out Days day))
                {
                    if (!Enum.IsDefined(typeof(Days), day))
                    {
                        day = default;
                    }
                }

                return day;
            }
        }
    }
}
