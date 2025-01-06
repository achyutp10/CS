using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}";
        }

    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tGrade: {Grade}";
        }

    }
    public class Inheritance
    {
        static void Main222()
        {
            Person person = new Person("Achyut", 23);
            Student student = new Student("Achyut", 23, 1);
            Console.WriteLine(person);
            Console.WriteLine(student);
        }
    }
}
