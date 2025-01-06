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
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name!";
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
            return $"Name: {name}\nAge: {Age}";
        }
        public override string ToString()
        {
            return $"Name: {name}\nAge: {Age}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person; //run time
                return Name.Equals(person.Name) && Age == person.Age;
            }

            return false;
        }
    }
    class OR_ToString
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 25);
            Person test = new Person("Aba", 25);
            Console.WriteLine(person);
            Console.WriteLine(test);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

            Console.ReadLine();
        }
    }
}
