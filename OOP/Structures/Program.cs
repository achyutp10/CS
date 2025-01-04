using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int DOB;

            public Person(string name, int age, int DOB)
            {
                this.name = name;
                this.age = age;
                this.DOB = DOB;
                 
            }

        }
        static void Main(string[] args)
        {
            /* string name = "Aba";
            int age = 23;

            Person person;
            person.name = "Achyut";
            person.age = 22;
            person.DOB = 2002;
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{person.name} - {person.age} - {person.DOB}");

            //string newName = ReturnPerson(out int newAge, out int newDOB);
            //Console.WriteLine($"{newName} - {newAge} - {newDOB}");

            string newName = "";
            int newAge = 0;
            int newDOB = 0;

            ReturnPerson(ref newName, ref newAge, ref newDOB);
            Console.WriteLine($"{newName} - {newAge} - {newDOB}");
            */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.DOB}");

            Task_Box_Structure.Main2();


        }
        static Person ReturnPerson ()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your DOB: ");
            int dob = Convert.ToInt32(Console.ReadLine());

            /*
            Person person;

            person.name = name;
            person.age = age;
            person.DOB = dob;
            */

            //return person;

            return new Person(name, age, dob);
        }
        //static string ReturnPerson(out int age, out int dob)
        //{
        //    Console.WriteLine("Enter your name: ");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("Enter your age: ");
        //    age = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter your DOB: ");
        //    dob = Convert.ToInt32(Console.ReadLine());

        //    return name;
        //}
        /*
        static void ReturnPerson(ref string name, ref int age, ref int dob)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your DOB: ");
            dob = Convert.ToInt32(Console.ReadLine());
        }

        */

    }
}
