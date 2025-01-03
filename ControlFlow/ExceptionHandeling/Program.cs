using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bool loop = true;
            while (loop)
            {
                try
                {
                    Console.Write("Enter a no: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    loop = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Format Exception please enter no only {e.Message}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Overflow Exception please input under limit");
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine($"Something went wrong - {e} - {e.Message}");
                }
                Console.WriteLine("Good Bye");
            }
            */

            // ==================== Throwing =========================

            //    int[] numbers = new int[0];

            //    try
            //    {
            //        if (FindInt(numbers, 1, out int index))
            //        {
            //            Console.WriteLine($"1 found at index {index}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("1 was not found");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }

            //    Console.WriteLine("Goodbye!");
            //    Console.ReadLine();
            //}
            //static bool FindInt(int[] numbers, int search, out int index)
            //{
            //    if (numbers.Length == 0)
            //    {
            //        throw new Exception("Array length cannot be 0.");
            //    }

            //    index = -1;

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] == search)
            //        {
            //            index = i;
            //        }
            //    }

            //    return index > -1;

            
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                /*if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }*/

                try
                {

                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too big or too small");
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to convert");
                }

                Console.ReadLine();




            }
    }
}
