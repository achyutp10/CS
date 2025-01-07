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
        * Continue project from Task9
        * 
        * Create a new interface for the box
        * Create a new function to calculate the area, return a double
        * 
        * Inherit the interface from the box abstract class
        * Try and fix the errors, where will you define the code for the area?
            * The area for the Square and Rectangle have different formulas
            * Where should they go?
            * Write the functions to actually calculate the area
                * Square = 6 x (Length * Length)
                * Rectangle = 2 x (l*d + l*h + d*h)
        *
        * After inserting area code, run it in the main and check the output
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
        }
        static void Main(string[] args)
        {
            Square square = new Square(10);
            Rectangle rectangle = new Rectangle(15, 20, 25);

            Console.WriteLine($"{square.calcArea()}m²");
            Console.WriteLine($"{rectangle.calcArea()}m²");

            Console.ReadLine();
        }
        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
