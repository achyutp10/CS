using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Fields
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            //public void SetName(string name)
            //{
            //if (!string.IsNullOrEmpty(name))
            //{
            //    this.name = name;
            //}
            //else
            //{
            //this.name = "Invalid Name";
            //}
            //    this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
            //}

            //public string GetName()
            //{
            //    return name;
            //}


            //public void SetAge(int age)
            //{
            //    //if (age >= 0 && age <= 150)
            //    //{
            //    //this.age = age;                    
            //    //}
            //    //else
            //    //{
            //    //    this.age = -1;
            //    //}
            //    this.age = age >= 0 && age <= 150 ? age : -1;
            //}

            //public int GetAge()
            //{
            //    return age;
            //}


            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
            public string GetName() => this.name;
            public void SetAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;
            public int GetAge() => age;

            public string ReturnDetails()
            {
                return $"Name: {name}\n Age: {age}";

            }

        }
        public static void Main3()
        {
            Person person = new Person("Achyut", 22);
            Console.WriteLine(person.ReturnDetails());

            //person.name = "Harry";
            //person.age = 25;

            person.SetName("Harry");
            person.SetAge(25);
            //person.SetName(null);

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");
        }
    }
}
