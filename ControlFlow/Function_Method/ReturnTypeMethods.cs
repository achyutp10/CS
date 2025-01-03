using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    class ReturnTypeMethods
    {
        //static string name = "Achyut";
        public static void MainM()
        {
            //Console.Title = name;
            Console.Title = $"{ReturnName()} - {ReturnAge()}";

            PrintIntro();

            int[] nos = new int[3];

            //Console.WriteLine("Enter a no: ");
            //nos[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a no: ");
            //nos[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a no: ");
            //nos[2] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nos.Length; i++)
            {
                nos[i] = ReadNoFromConsole();
            }

            foreach (var item in nos)
            {
                Console.WriteLine(item);
            }

            int[] nos2 = CreateRandomArray();

            foreach (var item in nos2)
            {
                Console.WriteLine(item);
            }

            Add();

        }

        static int Add()
        {
            //int.TryParse("", out int x);
            //TryParse();
            return 5 + 5;
        }

        static bool TryParse(string str, out int result)
        {
            result = 0;
            return true;
        }
        static void test()
        {
            // conversion
            //calculation
        }
        static void calculation ()
        {
            //calculation
        }
        static void conversion()
        {
            // conversion

        }
        static int[] CreateRandomArray()
        {
            //int[] nums = new int[3]
            //{
            //    0, 2, 3,
            //};
            //return nums;
            return new int[3] { 0, 1, 2 };
        }
        static int ReadNoFromConsole()
        {
            Console.WriteLine("Enter a no: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Achyut";
        }
        static int ReturnAge()
        {
            return 22;
        }
        public static void PrintIntro()
        {
            string name = ReturnName();
            int age = ReturnAge();
            //Console.WriteLine(name);
            Console.WriteLine(ReturnName());
            string output = $"Hello my name is {name} and age is {age}";
            string output2 = $"Hello my name is {ReturnName()} and age is {ReturnAge()}";
            Console.WriteLine(name);
            Console.WriteLine(output);
            Console.WriteLine(output2);
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
    }
}
