using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Task2
    {
        class Box
        {
            public double length, height, width;

            public Box(double length, double height, double width)
            {
                this.length = length;
                this.height = height;
                this.width = width;
            }

            public string ReturnDetails()
            {
                return $"{length} - {height} - {width}";
            }
        }

        public static void Main2()
        {

            double length = ReadDouble("length"); ;
            double height = ReadDouble("height");
            double width = ReadDouble("width");


            //Box box;
            //Box box = new Box(ReadDouble("length"), ReadDouble("height"), ReadDouble("width"));
            Box box = new Box(length, height, width);

            //box.length = length;
            //box.height = height;
            //box.width = width;

            //Console.WriteLine("Enter length: ");
            //box.length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height: ");
            //box.height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter width: ");
            //box.width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{box.length} - {box.height} - {box.width}");
            Console.WriteLine(ReturnDetails(box));
            Console.WriteLine(box.ReturnDetails());
        }

        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static string ReturnDetails(Box box)
        {
            return $"{box.length} - {box.height} - {box.width}";
        }
    }
}
