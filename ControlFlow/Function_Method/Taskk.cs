using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class Taskk
    {
        /*
         * Ask user for 2 integers, store them
         * Create function called Add with an int return type
         * two parameters, both ints to accept the numbers to add
         * function should return the sum of both numbers
         * call in the main and print out he value
         * Extra: overload to support double values adding
        */
        //static void Main(string[] args)
        //{
        //    int num = ReadInt("Enter a number: ");
        //    int num1 = ReadInt("Enter a number: ");

        //    Console.WriteLine($"{num} + {num1} = {Add(num, num1)}");

        //    double num2 = ReadDouble("Enter a number: ");
        //    double num3 = ReadDouble("Enter a number: ");

        //    Console.WriteLine($"{num2} + {num3} = {Add(num2, num3)}");

        //    Console.ReadLine();
        //}
        //static int ReadInt(string message)
        //{
        //    Console.Write(message);
        //    return Convert.ToInt32(Console.ReadLine());
        //}
        //static double ReadDouble(string message)
        //{
        //    Console.Write(message);
        //    return Convert.ToDouble(Console.ReadLine());
        //}
        //static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //static double Add(double x, double y)
        //{
        //    return x + y;
        //}

        /*
         * Ask user to input message, store it
         * Print the length of the string
         * Create a function NumberOfSpaces, int return type
            * string message param
            * function should loop and add up the number of spaces in the text and return it
         * Use in main and output the return value
        */
        //static void Main(string[] args)
        //{
        //    string message = ReadMessage("Enter a message: ");
        //    Console.WriteLine($"The length of your message is {message.Length}");
        //    Console.WriteLine($"The amount of spaces is {NumberOfSpaces(message)}");

        //    Console.ReadLine();
        //}
        //static string ReadMessage(string message)
        //{
        //    Console.Write(message);
        //    return Console.ReadLine();
        //}
        //static int NumberOfSpaces(string message)
        //{
        //    int spaces = 0;

        //    foreach (var ch in message)
        //    {
        //        if (ch.Equals(' ')) //hello world
        //        {
        //            spaces++;
        //        }
        //    }

        //    return spaces;
        //}

        /*
         * Create and initalise two int variables
         * Create function SwapInt...this is open ended
         * Call the function and print out the swapped values
         * example:
            * a = 5     y = 10
            * a = 10    y = 5
        */
        //static void Main(string[] args)
        //{
        //    int a = 5;
        //    int b = 10;

        //    SwapInt(ref a, ref b);

        //    Console.WriteLine($"{a} {b}");

        //    Console.ReadLine();
        //}
        //static void SwapInt(ref int a, ref int b)
        //{
        //    int temp = a;   //temp = 5, a = 5, b = 10
        //    a = b;          //temp = 5, a = 10, b = 10
        //    b = temp;       //temp = 5, a = 10, b = 5
        //}

        /*
         * Ask user to enter a number, store it
         * Create two functions, Squared and Cubes, decide on return type
         * Functions should calculate Squard and Cubes of an int parameter
         * Call in main and output results to the console
         * Extra: Power function using Math.Pow()
        */
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"{num} squared is {Power(num, 2)}");
        //    Console.WriteLine($"{num} squared is {Power(num, 5)}");
        //    Console.WriteLine($"{num} cubed is {Power(num, 3)}");

        //    Console.ReadLine();
        //}
        //static double Squared(int num)
        //{
        //    //return num * num;
        //    return Math.Pow(num, 2);
        //}
        //static double Cubed(int num)
        //{
        //    //return num * num * num;
        //    return Math.Pow(num, 3);
        //}
        //static double Power(double num, double power)
        //{
        //    /*int total = num;

        //    for (int i = 0; i < power - 1; i++)
        //    {
        //        total *= num;
        //    }

        //    return total;*/

        //    return Math.Pow(num, power);
        //}

        /*
         * Ask user for width and height, store them
         * Create function to calculate the area
         * Function should calculate the area using: (width * height) / 2
         * Call in main and print out the area of the triangle
        */
        //static void Main(string[] args)
        //{
        //    int width = ReadInt("width");
        //    int height = ReadInt("height");

        //    Console.WriteLine($"The area is {CalcArea(width, height)}");

        //    Console.ReadLine();
        //}
        //static int CalcArea(int width, int height)
        //{
        //    return (width * height) / 2;
        //}
        //static int ReadInt(string message)
        //{
        //    Console.Write($"Enter {message}: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        /*
        * Ask user to enter the number of minutes, store it
        * Make a function that calculates the amount of seconds based on an int param
        * Call in the main and print out the result
        * 
        * Extra: create const for seconds in a minute
       */
        //const int secInMinute = 60;
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter minutes: ");
        //    int minutes = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"There is {CalcSeconds(minutes)} seconds in {minutes} minutes");

        //    Console.ReadLine();
        //}
        //static int CalcSeconds(int minutes)
        //{
        //    return minutes * secInMinute;
        //}

        /*
         * Ask the user to enter a number, store as an int
         * Create a Factorial function that takes in a single int param
         * function should calculate the factorial and return back an int
         * 1! = 1
         * 2! = 2
         * 3! = 6
         * 4! = 24
         * 5! = 120
         * Call in main and print the value to the console
        */
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine($"{num}! = {Factorial(num)}");

        //    Console.ReadLine();
        //}
        //static int Factorial(int num)
        //{
        //    int result = num; //5

        //    if (result <= 1)
        //    {
        //        result = 1;
        //    }
        //    else
        //    {
        //        for (int i = 1; i < num; i++) //1-4
        //        {
        //            result *= i; //5 * 4
        //        }
        //    }

        //    return result;
        //}

        /*
         * Create and initalise int array of numbers
         * Create function SumOfNumbers with int return type
         * int array param
         * function should return total of all numbers
         * call in main and output the total
         * extra: check array length
            * return -1 if array empty
            * check return in main and output message
            * do we need to return -1, how else can we make this?
        */
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, -1, -2, -3, -4, -5, -100
            };

            int result = SumOfNumbers(numbers);

            if (result > -1)
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }
            ///
            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }

            Console.ReadLine();
        }
        static int SumOfNumbers(int[] numbers)
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (var item in numbers)
                {
                    total += item;
                }

                return total;
            }

            return -1;
        }
        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;

            if (numbers.Length > 0)
            {
                foreach (var item in numbers)
                {
                    total += item;
                }

                return true;
            }

            return false;
        }
    }
}
