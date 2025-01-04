using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Method_Function
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public string ReturnDetails()
            {
                return $"Name: {name}\n Age: {age}";

            }

        }
        public Method_Function()
        {
            Person person = new Person("Achyut", 22);

            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
            
        }

        //static string ReturnDetails(Person person)
        //{

        //    return $"Name: {person.name}\n Age: {person.age}";            
        //}
        //static string ReturnDetails(string name, int age)
        //{

        //    return $"Name: {name}\n Age: {age}";            
        //}

    }
}
