using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class VariableScope
    {
        static string message = "Hello";
        public static void VS()
        {
            Console.Write(Welcome());
            //int i;
            //for (i = 0; i < 10; i++)
            //{

            //}
            //Console.WriteLine(i);

            //string message = "Hello";
            //Console.WriteLine(message);
            //{
            //    int test = 5;
            //    Console.WriteLine(test);
            //}
            //Console.WriteLine(test);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write(GoodBye());
            Console.ReadLine(); 
        }

        static string Welcome()
        {

            return "Hello";
            //Console.WriteLine(message);
        }
        static string GoodBye()
        {

            return "GoodBye";
        }
    }
}
