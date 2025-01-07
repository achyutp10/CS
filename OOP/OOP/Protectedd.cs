using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Protectedd
    {
        class Point
        {
            public int x;
            private protected int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        class Position : Point
        {
            private protected int z;

            public Position(int x, int y, int z) : base(x, y)
            {
                this.z = z;
                //this.
            }
        }
        class Test : Position
        {
            public Test() : base(5, 5, 5)
            {
                //this.
            }
        }
        static void Main(string[] args)
        {
            Point point = new Point(5, 5);
            point.x = 0;

            Position position = new Position(5, 5, 5);
            //position

            Console.ReadLine();
        }
    }
}
