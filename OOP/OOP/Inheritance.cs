//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }

//        public override string ToString()
//        {
//            return $"Name: {Name}\tAge: {Age}";
//        }

//    }

//    class Student : Person
//    {       
//        public int Grade { get; set; }

//        public Student(string name, int age, int grade) : base(name, age)
//        {
//            Grade = grade;
//        }

//        public override string ToString()
//        {
//            return $"{base.ToString()}\tGrade: {Grade}";
//        }

//    }
//    class Staff : Person
//    {
//        public int Salary { get; set; }

//        public Staff(string name, int age, int salary) : base(name, age)  
//        { 
//            Salary = salary; 
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}\tSalary: {Salary}";
//        }
//    }
//    class Teacher : Staff
//    {
//        public string Subject { get; set; }
//        public Teacher(string name, int age, int salary, string subject) : base(name, age, salary)
//        {
//            Subject = subject;
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}\tSubject: {Subject}";
//        }
//    }
//    public class Inheritance
//    {
//        static void Main222()
//        {
//            Person person = new Person("Achyut", 23);
//            Student student = new Student("Achyut", 23, 1);
//            Staff staff = new Staff("Achyut", 23, 10000);
//            Teacher teacher = new Teacher("Achyut", 23, 10000, "C#");
//            Console.WriteLine(person);
//            Console.WriteLine(student);
//            Console.WriteLine(staff);
//            Console.WriteLine(teacher);
//        }
//    }
//}
