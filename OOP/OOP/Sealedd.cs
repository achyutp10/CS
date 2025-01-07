using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class A
    {
        public abstract void s();
        public abstract void a();
    }
    class B : A
    {
        public sealed override void a() { }
        public override void s() { }
        public void b()
        {

        }
    }
    class C : B
    {
        //public override void a() { }
        public override void s()
        {
            b();
        }
    }
    class Sealedd
    {
        static void Mainn()
        {
            Console.ReadLine();
        }
    }
}
