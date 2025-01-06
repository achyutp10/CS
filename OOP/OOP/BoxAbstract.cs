using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BoxAbstract
    {
        /*
        * Continue project from Task8
        * 
        * In the square class make a size auto property
        * What does this limit you to? ^
        * Update the property to allow the base properties to change
        * 
        * In the main:
            * Remove box instances (fix errors)
            * Make sure operators still work
            * Test ones in Box base class
        */
        abstract class Box
        {
            private double length, height, depth;

            public double Length { get => length; set => length = CheckRange(value); }
            public double Height { get => height; set => height = CheckRange(value); }
            public double Depth { get => depth; set => depth = CheckRange(value); }

            public double CheckRange(double value)
            {
                return value < 1 ? 1 : value;
            }

            public Box(double length, double height, double depth)
            {
                Length = length;
                Height = height;
                Depth = depth;
            }
            public Box(double size)
            {
                Length = size;
                Height = size;
                Depth = size;
            }
            public static Box operator +(Box a, Box b)
            {
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
            public override string ToString()
            {
                return $"Length: {length}\tHeight: {height}\tDepth: {depth}";
            }
            public override bool Equals(object obj)
            {
                if (obj is Box)
                {
                    Box box = obj as Box; // run time
                    return Length == box.Length &&
                        Height == box.Height &&
                        Depth == box.Depth;
                }

                return false;
            }
        }
        class Square : Box
        {
            private double size;

            public double Size
            {
                get => size;
                set
                {
                    size = value;
                    Length = value;
                    Height = value;
                    Depth = value;
                }
            }
            public Square(double size) : base(size)
            {
                this.size = size;
            }
            public static Square operator *(Square a, Square b)
            {
                return new Square(a.size * b.size);
            }
            public static Square operator /(Square a, Square b)
            {
                return new Square(a.size / b.size);
            }
        }
        class Rectangle : Box
        {
            public Rectangle(double length, double height, double depth) : base(length, height, depth)
            {
            }
            public static Rectangle operator *(Rectangle a, Rectangle b)
            {
                return new Rectangle(a.Length * b.Length, a.Height * b.Height, a.Depth * b.Depth);
            }
            public static Rectangle operator /(Rectangle a, Rectangle b)
            {
                return new Rectangle(a.Length / b.Length, a.Height / b.Height, a.Depth / b.Depth);
            }
        }
        static void Main(string[] args)
        {
            //Box box = new Box(10, 10, 10);
            Square square = new Square(500);
            Square square1 = new Square(10);
            Rectangle rectangle = new Rectangle(15, 20, 25);
            Rectangle rectangle1 = new Rectangle(10, 10, 10);

            // Square times = square * square1;
            // Square divide = square / square1;

            Rectangle times = rectangle * rectangle1;
            Rectangle divide = rectangle / rectangle1;

            // Console.WriteLine(times);
            // Console.WriteLine(divide);

            Console.WriteLine(square == square1);
            Console.WriteLine(square > square1);
            Console.WriteLine(square < square1);
            Console.WriteLine(square != square1);

            //Console.WriteLine(box);
            //Console.WriteLine(square);
            //Console.WriteLine(rectangle);

            //square.Size = 20;
            Console.WriteLine(square);

            Console.ReadLine();
        }
        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
