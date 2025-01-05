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

    }
    public class OperatorOverloading
    {
        static void Main22()
        {
            Person person = new Person("Achyut", 23);
        }
    }
}
