using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TaskBoxInheritance
    {
        /*
        * Continue project from Task7
        * 
        * Create a Square class
            * Constructor should call the base constructor
            * Make all properties the same value
        * Create a rectangle class
            * Constructor should call the base constructor
        * 
        * In the main:
            * Create a Box/Square/Rectangle
            * Test out the operators and make sure they work with custom classes
            * Also try out ToString() and Equals()
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
            public static Box operator *(Box a, Box b)
            {
                return new Box(a.Length * b.Length,
                            a.Height * b.Height,
                            a.Depth * b.Depth);
            }
            public static Box operator /(Box a, Box b)
            {
                return new Box(a.Length / b.Length,
                            a.Height / b.Height,
                            a.Depth / b.Depth);
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
        static void Main(string[] args)
        {
            Box box = new Box(10, 10, 10);
            Box test = new Box(10, 10, 10);

            Console.WriteLine(box);
            Console.WriteLine(test);

            Console.WriteLine(box.Equals(test) ? "Same" : "Not same");

            Console.ReadLine();
        }
        static double ReadDouble(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
