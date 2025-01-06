using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;

            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";

        }
        public int Age
        {
            get => age;

            set => age = value >= 0 && value <= 150 ? value : -1;

        }

        public Person(string name, int age)
        {

            Name = name;
            Age = age;
        }

        public string ReturnDetails()
        {
            return $"Name: {Name}\n Age: {Age}";

        }

        public static bool operator == (Person a, Person b)
        {
            return a.Name.Equals(b.Name) && a.Age == b.Age;
        }
        public static bool operator != (Person a, Person b)
        {
            return !a.Name.Equals(b.Name) || a.Age != b.Age;

        }

        public static Person operator ++(Person a)
        {
            a.Age++;
            return a;
        }
        public static Person operator --(Person a)
        {
            a.Age--;
            return a;
        }

        public static bool operator >=(Person a, Person b)
        {
            return a.Age >= b.Age;
        }
        public static bool operator >(Person a, Person b)
        {
            return a.Age > b.Age;
        }
        public static bool operator <=(Person a, Person b)
        {
            return a.Age <= b.Age;
        }
        public static bool operator <(Person a, Person b)
        {
            return a.Age < b.Age;
        }
        public static Person operator +(Person a, Person b)
        {
            a.Age += b.Age;
            return a;
        }

    }
    public class OperatorOverloading
    {
        static void Main22()
        {
            Person person = new Person("Achyut", 23);
            Person test = new Person("Achyut", 23);
            Person test2 = new Person("Aba", 25);
            Console.WriteLine(person);
            Console.WriteLine(test);

            if (person == test)
            {
                Console.WriteLine("Same");
            }
            if (person != test2)
            {
                Console.WriteLine("Not Same");
            }

            person++;
            Console.WriteLine(person.Age);

            Console.WriteLine(person > test);
            Console.WriteLine(person >= test);
            Console.WriteLine(person < test);
            Console.WriteLine(person <= test);
            Console.WriteLine(person == test);
            Console.WriteLine(person != test);

            person = person + test;
            Console.WriteLine(person.Age);

            //if (person >= test)
            //{
            //    Console.WriteLine($"{person.Name} is Older than {test.Name}");
            //}
            //else
            //{
            //    Console.WriteLine($"{test.Name} is older than {person.Name}");
            //}
            //if (person.Equals(test))
            //{
            //    Console.WriteLine("Same");
            //}
        }
    }
}
