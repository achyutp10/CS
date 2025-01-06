using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //class Box
    //{
    //    private double length, height, width;

    //    public double Length { get => length; set => length = CheckRange(value); }
    //    //public double Length
    //    //{
    //    //    get 
    //    //    { 
    //    //        return length; 
    //    //    }
    //    //    set
    //    //    {
    //    //        //if (value < 1)
    //    //        //{
    //    //        //    length = 1;
    //    //        //}
    //    //        //else
    //    //        //{
    //    //        //    length = value;
    //    //        //}
    //    //        length = value < 1 ? 1 : value;
    //    //    }

    //    //}
    //    public double Height
    //    {
    //        get 
    //        { 
    //            return height; 
    //        }
    //        set
    //        {
    //            //if (value < 1)
    //            //{
    //            //    height = 1;
    //            //}
    //            //else
    //            //{
    //            //    height = value;
    //            //}
    //            height = CheckRange(value);
    //        }

    //    }
    //    public double Width
    //    {
    //        get 
    //        { 
    //            return width; 
    //        }
    //        set
    //        {
    //            if (value < 1)
    //            {
    //                width = 1;
    //            }
    //            else
    //            {
    //                width = value;
    //            }
    //        }

    //    }

    //    public Box(double length, double height, double width)
    //    {
    //        //if (length < 1)
    //        //{
    //        //    this.length = 1;
    //        //}
    //        //else
    //        //{
    //        //    this.length = length;
    //        //}



    //        Length = length;
    //        Height = height;
    //        Width = width;

    //        //this.length = length;
    //        //this.height = height;
    //        //this.width = width;
    //    }

    //    public double CheckRange(double value)
    //    {
    //        return value < 1 ? 1 : value;
    //    }

    //    /*
    //    public void SetLength(double length)
    //    {
    //        this.length = length;
    //    }
    //    public double GetLength() => length;

    //    public void SetHeight(double height)
    //    {
    //        this.height = height;
    //    }
    //    public double GetHeight() => height;
    //    public void SetWidth(double width)
    //    {
    //        this.width = width; ;
    //    }
    //    public double GetWidth() => width;
    //    */

    //    public string ReturnDetails()
    //    {
    //        return $"{length} - {height} - {width}";
    //    }
    //}
    //public class Task2
    //{


    //    public static void Main2()
    //    {

    //        double length = ReadDouble("length"); ;
    //        double height = ReadDouble("height");
    //        double width = ReadDouble("width");


    //        //Box box;
    //        //Box box = new Box(ReadDouble("length"), ReadDouble("height"), ReadDouble("width"));
    //        Box box = new Box(length, height, width);

    //        //box.SetLength(length);
    //        //box.SetHeight(height);
    //        //box.SetWidth(width);

    //        box.Length = 10;
    //        box.Height = 20;
    //        box.Width = 30;

    //        Console.WriteLine(box.Length);
    //        Console.WriteLine(box.Height);
    //        Console.WriteLine(box.Width);
    //        //Console.WriteLine($"Your length is {box.GetLength()} and your heigth is {box.GetHeight()} and width is {box.GetWidth()}");

    //        Console.WriteLine(box.ReturnDetails());

    //        length = ReadDouble("new length");
    //        height = ReadDouble("new height");
    //        width = ReadDouble("new width");

    //        //box.SetLength(length);
    //        //box.SetHeight(height);
    //        //box.SetWidth(width);

    //        //Console.WriteLine($"Your new length is {box.GetLength()} and your new heigth is {box.GetHeight()} and new width is {box.GetWidth()}");

    //        Console.WriteLine(box.ReturnDetails());


    //        //box.length = length;
    //        //box.height = height;
    //        //box.width = width;

    //        //Console.WriteLine("Enter length: ");
    //        //box.length = Convert.ToDouble(Console.ReadLine());
    //        //Console.WriteLine("Enter height: ");
    //        //box.height = Convert.ToDouble(Console.ReadLine());
    //        //Console.WriteLine("Enter width: ");
    //        //box.width = Convert.ToDouble(Console.ReadLine());

    //        //Console.WriteLine($"{box.length} - {box.height} - {box.width}");
    //        //Console.WriteLine(ReturnDetails(box));
    //        //Console.WriteLine(box.ReturnDetails());
    //    }

    //    static double ReadDouble(string message)
    //    {
    //        Console.Write($"Enter {message}: ");
    //        return Convert.ToDouble(Console.ReadLine());
    //    }

    //    //static string ReturnDetails(Box box)
    //    //{
    //    //    return $"{box.GetLength()} - {box.GetHeight()} - {box.GetWidth()}";
    //    //}
    //}

    /*
        * Continue project from Task5
        * 
        * To make the next output easier, instead of new lines,
        * make the return details function use tab's (\t)
        * 
        * Now try and overload the following operators:
            * + (add two boxes together, return new box)
            * - (minus two boxes together, return new box)
            * ++ (add 1 to each property, return box)
            * -- (minus 1 to each property, return box)
                * what happens if they are 1 and u do --, does it become 0?
            * == (if two boxes have same property values, return bool)
            * != (if two boxes don't have same property values, return bool)
            * 
        * Try them all out in the main function and make sure they all work!
        * 
        * Extra: create >, >=, <, <=, *, /
        * 
        * What happens when you try to use: += -=
        */
    class Box
    {
        private double length, height, depth;

        public double Length { get => length; set => length = CheckRange(value); }
        public double Height { get => height; set => height = CheckRange(value); }
        public double Depth { get => depth; set => depth = CheckRange(value); }
        public Box(double length, double height, double depth)
        {
            Length = length;
            Height = height;
            Depth = depth;
        }

        public double CheckRange(double value)
        {
            return value < 1 ? 1 : value;
        }
        public string ReturnDetails()
        {
            return $"Length: {length}\tHeight: {height}\tDepth: {depth}";
        }

        public static Box operator +(Box a, Box b)
        {
            /*double length = a.Length + b.Length;
            double height = a.Height + b.Height;
            double depth = a.Depth + b.Depth;

            return new Box(a.Length + b.Length, a.Height + b.Height, a.Depth + b.Depth);*/
            a.Length += b.Length;
            a.Height += b.Height;
            a.Length += b.Length;
            return a;
        }
        public static Box operator -(Box a, Box b)
        {
            a.Length -= b.Length;
            a.Height -= b.Height;
            a.Length -= b.Length;
            return a;

            //return new Box(a.Length - b.Length, a.Height - b.Height, a.Depth - b.Depth);
        }
        public static Box operator ++(Box a)
        {
            a.Length++;
            a.Height++;
            a.Depth++;

            return a;
        }
        public static Box operator --(Box a)
        {
            a.Length--;
            a.Height--;
            a.Depth--;

            return a;
        }
        public static bool operator ==(Box a, Box b)
        {
            return a.Length == b.Length && a.Height == b.Height && a.Depth == b.Depth;
        }
        public static bool operator !=(Box a, Box b)
        {
            return a.Length != b.Length || a.Height != b.Height || a.Depth == b.Depth;
        }
        public static bool operator >(Box a, Box b)
        {
            return a.Length > b.Length && a.Height > b.Height && a.Depth > b.Depth;
        }
        public static bool operator >=(Box a, Box b)
        {
            return a.Length >= b.Length && a.Height >= b.Height && a.Depth >= b.Depth;
        }
        public static bool operator <(Box a, Box b)
        {
            return a.Length < b.Length && a.Height < b.Height && a.Depth < b.Depth;
        }
        public static bool operator <=(Box a, Box b)
        {
            return a.Length <= b.Length && a.Height <= b.Height && a.Depth <= b.Depth;
        }
        public static Box operator *(Box a, Box b)
        {
            /*a.Length *= b.Length;
            a.Height *= b.Height;
            a.Depth *= b.Depth;

            return a;*/

            return new Box(a.Length * b.Length,
                        a.Height * b.Height,
                        a.Depth * b.Depth);
        }
        public static Box operator /(Box a, Box b)
        {
            /*a.Length /= b.Length;
            a.Height /= b.Height;
            a.Depth /= b.Depth;

            return a;*/

            return new Box(a.Length / b.Length,
                        a.Height / b.Height,
                        a.Depth / b.Depth);
        }
        


        static void Main(string[] args)
        {
            Box box = new Box(200, 250, 300);
            Box test = new Box(20, 26, 30);

            Console.WriteLine(box > test);
            Console.WriteLine(box >= test);

            Console.WriteLine(box < test);
            Console.WriteLine(box <= test);

            Box divide = box / test;
            Console.WriteLine(box.ReturnDetails());
            Console.WriteLine(divide.ReturnDetails());

            Box times = box * test;
            Console.WriteLine(box.ReturnDetails());
            Console.WriteLine(times.ReturnDetails());

            Box minus = box - test;
            Console.WriteLine(box.ReturnDetails());

            box -= test;
            Console.WriteLine(box.ReturnDetails());

            Console.ReadLine();
        }
        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
