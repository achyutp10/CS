using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class Task
    {
        public static void Taskk()
        {
            //    /*
            // * Ask the user for two integers, store them both
            // * Make function called Remainder, with bool return type
            // * 3 parameters, 2 ints and 1 out int
            // * the function should:
            //    * calculate the remainder
            //    * if the remainder if 0, return true
            //    * if the remainder is not 0, return false
            // * call the function:
            //    * if the return value is true, output they are divisible
            //    * if the return value is false, output they are not divisible + the reminder
            // * Extra: any other use of functions
            //*/
            //        int[] numbers = new int[2];

            //        for (int i = 0; i < numbers.Length; i++)
            //        {
            //            numbers[i] = ReadInt("Enter a number");
            //        }

            //        if (Remainder(numbers, out int remainder))
            //        {
            //            Console.WriteLine($"{numbers[0]} is divisible by {numbers[1]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"The remainder of {numbers[0]} % {numbers[1]} is {remainder}");
            //        }

            //        Console.ReadLine();
            //    }
            //    static int ReadInt(string message)
            //    {
            //        Console.Write($"{message}: ");
            //        return Convert.ToInt32(Console.ReadLine());
            //    }
            //    static bool Remainder(int[] numbers, out int reminder)
            //    {
            //        reminder = -1;

            //        if (numbers.Length == 2)
            //        {
            //            reminder = numbers[0] % numbers[1];

            //            return reminder == 0;
            //        }

            //        return false;
            //    }

            /*
             * Ask the user for two integers, store them both
             * Make function call Remainder, with void return type
             * 4 parameters, ref bool, 2 ints and 1 ref int
             * the function should:
                * calculate the remainder
                * if the remainder is 0, set bool to true
                * if the reminder is not 0, set bool to false
             * create variables needed to pass by reference
             * call the function:
                * if bool is true, output they are divisible
                * if bool is false, output they are not divisible + the remainder
            */

            //    int[] numbers = new int[2];

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        numbers[i] = ReadInt("Enter a number");
            //    }
            //    bool success = false;
            //    int remainder = -1;

            //    Remainder(ref success, numbers, ref remainder);

            //    if (success)
            //    {
            //        Console.WriteLine($"{numbers[0]} is divisible by {numbers[1]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The remainder of {numbers[0]} % {numbers[1]} is {remainder}");
            //    }

            //    Console.ReadLine();
            //}
            //static int ReadInt(string message)
            //{
            //    Console.Write($"{message}: ");
            //    return Convert.ToInt32(Console.ReadLine());
            //}
            //static void Remainder(ref bool success, int[] numbers, ref int reminder)
            //{
            //    if (numbers.Length == 2)
            //    {
            //        reminder = numbers[0] % numbers[1];

            //        success = reminder == 0;
            //    }
            //}

            int[] numbers = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadInt("Enter a number");
            }
            /*bool success = false;
            int remainder = -1;

            Remainder(ref success, numbers, ref remainder);

            if (success)
            {
                Console.WriteLine($"{numbers[0]} is divisible by {numbers[1]}");
            }
            else
            {
                Console.WriteLine($"The remainder of {numbers[0]} % {numbers[1]} is {remainder}");
            }*/

            if (Remainder(numbers, out int remainder))
            {
                Console.WriteLine($"{numbers[0]} is divisible by {numbers[1]}");
            }
            else
            {
                Console.WriteLine($"The remainder of {numbers[0]} % {numbers[1]} is {remainder}");
            }

            Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Remainder(ref bool success, int[] numbers, ref int reminder)
        {
            if (numbers.Length == 2)
            {
                reminder = numbers[0] % numbers[1];

                success = reminder == 0;
            }
        }
        static bool Remainder(int[] numbers, out int reminder)
        {
            reminder = -1;

            if (numbers.Length == 2)
            {
                reminder = numbers[0] % numbers[1];

                return reminder == 0;
            }

            return false;
        }

    }
}
