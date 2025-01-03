using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    public class Task
    {
        public Task()
        {
            /*
         * Create an array of any type and give it 1 value
         * Try and print out an index like [1] so it returns an error
         * Why doesn't it work? What is this error type?
         * Notice the error, make a try...catch to fix it
         * While keeping the original code the same
         * Output a message in the catch
         * Extra: add another catch all clause
        */

            //string[] test = new string[] { "test", "", "", "" };

            //try
            //{
            //    Console.WriteLine(test[10]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine($"Index out of range please use between 0 and {test.Length - 1}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Something went wrong!");
            //}

            ////IndexOutOfRangeException

            //Console.ReadLine();

            /*
         * Create a int and try convert any string to an int
         * Notice the error, write a try...catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Why is this a bad situation and how can we know if its been converted?
         * 
         * Create a custom try parse function
         * Find the real function and copy return tyoe/params
         * Read the tooltip it gives you, to give you ideas on what to do
        */

            /*bool success = false;

            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yey" : "Oh no");*/

            //    Console.Write("Enter a number: ");
            //    if (TryParse(Console.ReadLine(), out int result))
            //    {
            //        Console.WriteLine("Yey " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Oh no");
            //    }

            //    Console.ReadLine();
            //}
            //static bool TryParse(string input, out int result)
            //{
            //    result = -1;

            //    try
            //    {
            //        result = Convert.ToInt32(input);
            //        return true; //
            //    }
            //    catch (Exception)
            //    {
            //        return false;
            //    }

            /*
         * Try and create a int variable with the value of X / O
         * Why doesn't it work? What is this error type?
         * 
         * Create and store two int values from console
         * Then try and dividing them both, make sure second one is 0
         * 
         * Notice the error, make a try...catch to fix it
         * While keeping the original code the same
         * Output a message in the catch
         * Extra: add another catch all clause
        */
            //int x = 5 / 0;

            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num / num1);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (OverflowException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadLine();

            /*
         * Try create an int with a very large digit count (10)
         * Why doesn't it work? What is this error type?
         * 
         * Use another way of inserting a very big number into an int
         * Notice the error, make a try...catch to fix it
         * 
         * While keeping the original code the same
         * Output a message in the catch
         * Extra: add another catch all clause
        */
                //int x = 1000000000000000000000;

                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(x);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Int too big, try a smaller value.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();


            }

    }
}
