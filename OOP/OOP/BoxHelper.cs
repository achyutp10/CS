using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BoxHelper
    {
        /*
       * Continue project from Task10
       * 
       * Creating a box requires the same code, read in 3 values, create the Box
       * Abstract = no boxes to be created, Square of Rectangle only
       * Figure out a way to have a helper function to create an instance
       * 
       * In main:
           * Use the new helper function and make sure it works
           * Create multiple instances, notice the very short code
               * Main purpose of functions but also static functions can act as helper functions
       */
        interface IBox
        {
            double calcArea();
        }
        abstract class Box : IBox
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

            public abstract double calcArea();
            public static double ReadDouble(string message)
            {
                Console.Write($"Enter {message}: ");
                return Convert.ToDouble(Console.ReadLine());
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

            public override double calcArea()
            {
                return 6 * (Size * Size);
            }

            public static Square Create()
            {
                double size = Box.ReadDouble("size");
                return new Square(size);
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
            public override double calcArea()
            {
                /*double a = Length * Depth;
                double b = Length * Height;
                double c = Depth * Height;

                double result = a + b + c;

                return 2 * result*/

                return 2 * ((Length * Depth) + (Length * Height) + (Depth * Height));
            }
            public static Rectangle Create()
            {
                double length = Box.ReadDouble("length");
                double height = Box.ReadDouble("height");
                double depth = Box.ReadDouble("depth");

                return new Rectangle(length, height, depth);
            }
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = Rectangle.Create();
            Console.WriteLine(rectangle);

            Square square = Square.Create();
            Console.WriteLine(square);

            Rectangle rectangle1 = Rectangle.Create();
            Console.WriteLine(rectangle);

            Square square1 = Square.Create();
            Console.WriteLine(square1);

            Console.ReadLine();
        }
    }
}
