using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Class_Constructor
    {
        //struct Person
        //{
        //    public string name;
        //    public int age;

        //    public Person(string name, int age)
        //    {
        //        this.name = name;
        //        this.age = age;
        //    }
        //}

        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name)
            {
                this.name = name;
                //this.age = 0;
            }
            public Person(int age)
            {
                this.age = age;
                //this.name = "";
            }
            public Person()
            {
            }
        }
        public static void Main2()
        {
            //Person person = new Person("Achyut", 22);
            //Person person = new Person("Achyut");
            //Person person = new Person(22);
            //Person person = new Person();

            //Console.WriteLine(person.name);

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);

            if (!string.IsNullOrEmpty(person.name))
            {
                Console.WriteLine(person.name);            
            }

            if (person.age > -1)
            {
                Console.WriteLine(person.age);
            }



        }

    }
}
