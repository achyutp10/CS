using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class Switch
    {
        public static void SwitchMethod()
        {
            //Console.WriteLine("Enter a day of the week: ");
            //int day =  Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(day);

            //if (day == 0)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //else if (day == 1) {
            //    Console.WriteLine("Monday");
            //}

            /*
            switch (day) {
                case 0:
                case 1: Console.WriteLine("Sunday");
                    break;
                case 2: Console.WriteLine("Monday");
                    break;
                case 3: Console.WriteLine("Tuesday");
                    break;
                case 4: Console.WriteLine("Wednesday");
                    break;
                case 5: Console.WriteLine("Thursday");
                    break;
                case 6: Console.WriteLine("Friday");
                    break;
                case 7: Console.WriteLine("Saturday");
                    break;
                default: Console.WriteLine("Invalid day entered");
                    break;

            } */

            char grade = 'a';
            grade = char.ToUpper(grade);

            switch (grade) {
                case 'A': Console.WriteLine("Excellent");
                    break;
                case 'B': Console.WriteLine("V Good");
                    break;
                case 'C': Console.WriteLine("Good");
                    break;
                case 'D': Console.WriteLine("Pass");
                    break;
                default: Console.WriteLine("Invalid grade");
                    break;
            }

        }
    }
}
