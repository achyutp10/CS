using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class VoidMethods
    {
        public static void VM()
        {
            //if (int.TryParse("123", out int result))
            //{
            //    Console.WriteLine(result);
            //}
            ////bool success = int.TryParse("123", out int result);
            ////Console.WriteLine(success);
            //string test = "Hllo";
            ////test.Replace();

            //StringBuilder sb = new StringBuilder();
            //sb = sb.Replace(" ", "");
            ////Array.Reverse();
            ///

            //CreateAndPrintArray();

            //Name();
            Welcome();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Goodbye();
            
        }
        //static void CreateAndPrintArray()
        //{
        //    int[] no = new int[]
        //    {
        //        0, 1, 2,3,4
        //    };
        //    foreach (var item in no)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //static void Name()
        //{
        //    Console.WriteLine("Achyut");
        //}


        static void Welcome() {
            Console.WriteLine("Welcome");
        }
        static void Goodbye() {
            Console.WriteLine("Goodbye");
        }


    }
}
