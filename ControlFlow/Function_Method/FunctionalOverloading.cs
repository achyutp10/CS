using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class FunctionalOverloading
    {
        public FunctionalOverloading()
        {
            int a = 5;
            int b = 10;
            int c = 20;

            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(a, b, c));

            double x = 5.5;
            double y = 10.5;

            Console.WriteLine(Add(x, y));

            int[] numbers = new int[3] { a, b, c };
            Console.WriteLine(Add(numbers));

            string name = "Aba";
            int age = 23;

            Console.WriteLine(PrintDetails(name, age));
            Console.Title = PrintDetails(name);

            Console.ReadLine();
        }
        static string PrintDetails(string name, int age)
        {
            return $"Your name is {name} and your age is {age}";
        }
        static string PrintDetails(string name)
        {
            return $"Your name is {name}";
        }
        static int Add(int[] numbers)
        {
            int total = 0;

            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static int Add(int x, int y, int z, int a)
        {
            return x + y + z + a;
        }
        static double Add(double x, double y)
        {
            return x + y;
        }

    }
    }

