using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Box
    {
        private double length, height, width;

        public double Length { get => length; set => length = CheckRange(value); }
        //public double Length
        //{
        //    get 
        //    { 
        //        return length; 
        //    }
        //    set
        //    {
        //        //if (value < 1)
        //        //{
        //        //    length = 1;
        //        //}
        //        //else
        //        //{
        //        //    length = value;
        //        //}
        //        length = value < 1 ? 1 : value;
        //    }
             
        //}
        public double Height
        {
            get 
            { 
                return height; 
            }
            set
            {
                //if (value < 1)
                //{
                //    height = 1;
                //}
                //else
                //{
                //    height = value;
                //}
                height = CheckRange(value);
            }
             
        }
        public double Width
        {
            get 
            { 
                return width; 
            }
            set
            {
                if (value < 1)
                {
                    width = 1;
                }
                else
                {
                    width = value;
                }
            }
             
        }

        public Box(double length, double height, double width)
        {
            //if (length < 1)
            //{
            //    this.length = 1;
            //}
            //else
            //{
            //    this.length = length;
            //}

            

            Length = length;
            Height = height;
            Width = width;

            //this.length = length;
            //this.height = height;
            //this.width = width;
        }

        public double CheckRange(double value)
        {
            return value < 1 ? 1 : value;
        }

        /*
        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetLength() => length;

        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeight() => height;
        public void SetWidth(double width)
        {
            this.width = width; ;
        }
        public double GetWidth() => width;
        */

        public string ReturnDetails()
        {
            return $"{length} - {height} - {width}";
        }
    }
    public class Task2
    {
        

        public static void Main2()
        {

            double length = ReadDouble("length"); ;
            double height = ReadDouble("height");
            double width = ReadDouble("width");


            //Box box;
            //Box box = new Box(ReadDouble("length"), ReadDouble("height"), ReadDouble("width"));
            Box box = new Box(length, height, width);

            //box.SetLength(length);
            //box.SetHeight(height);
            //box.SetWidth(width);

            box.Length = 10;
            box.Height = 20;
            box.Width = 30;

            Console.WriteLine(box.Length);
            Console.WriteLine(box.Height);
            Console.WriteLine(box.Width);
            //Console.WriteLine($"Your length is {box.GetLength()} and your heigth is {box.GetHeight()} and width is {box.GetWidth()}");

            Console.WriteLine(box.ReturnDetails());

            length = ReadDouble("new length");
            height = ReadDouble("new height");
            width = ReadDouble("new width");

            //box.SetLength(length);
            //box.SetHeight(height);
            //box.SetWidth(width);

            //Console.WriteLine($"Your new length is {box.GetLength()} and your new heigth is {box.GetHeight()} and new width is {box.GetWidth()}");

            Console.WriteLine(box.ReturnDetails());


            //box.length = length;
            //box.height = height;
            //box.width = width;

            //Console.WriteLine("Enter length: ");
            //box.length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height: ");
            //box.height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter width: ");
            //box.width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"{box.length} - {box.height} - {box.width}");
            //Console.WriteLine(ReturnDetails(box));
            //Console.WriteLine(box.ReturnDetails());
        }

        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        //static string ReturnDetails(Box box)
        //{
        //    return $"{box.GetLength()} - {box.GetHeight()} - {box.GetWidth()}";
        //}
    }
}
