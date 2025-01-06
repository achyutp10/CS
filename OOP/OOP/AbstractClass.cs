//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    abstract class Person
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

        
//        public static bool operator ==(Person a, Person b)
//        {
//            return a.Name.Equals(b.Name) && a.Age == b.Age;
//        }
//        public static bool operator !=(Person a, Person b)
//        {
//            return !a.Name.Equals(b.Name) || a.Age != b.Age;

//        }

//        public static Person operator ++(Person a)
//        {
//            a.Age++;
//            return a;
//        }
//        public static Person operator --(Person a)
//        {
//            a.Age--;
//            return a;
//        }

//        public static bool operator >=(Person a, Person b)
//        {
//            return a.Age >= b.Age;
//        }
//        public static bool operator >(Person a, Person b)
//        {
//            return a.Age > b.Age;
//        }
//        public static bool operator <=(Person a, Person b)
//        {
//            return a.Age <= b.Age;
//        }
//        public static bool operator <(Person a, Person b)
//        {
//            return a.Age < b.Age;
//        }
//        public static Person operator +(Person a, Person b)
//        {
//            a.Age += b.Age;
//            return a;
//        }
//        public abstract void DoWork();
//        //public void DoWork()
//        //{
//        //    Console.WriteLine("Im doing something");
//        //}
        
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
//        public override void DoWork()
//        {
//            Console.WriteLine("Im Studing");
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
//        public override void DoWork()
//        {
//            Console.WriteLine("I'm Marking papers");
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

//        public override void DoWork()
//        {
//            Console.WriteLine("Im Teaching");
//        }


//    }
//    public class AbstractClass 
//    {
//        public static void Main222()
//        {
//            //Person person = new Person("Achyut", 23);
//            Student student = new Student("Achyut", 23, 1);
//            Staff staff = new Staff("Achyut", 23, 10000);
//            Teacher teacher = new Teacher("Achyut", 23, 10000, "C#");
//            //Console.WriteLine(person);
//            Console.WriteLine(student);
//            Console.WriteLine(staff);
//            Console.WriteLine(teacher);
//            Console.WriteLine(student == staff);
//            student.DoWork();
//            staff.DoWork();
//            teacher.DoWork();
//        }
//    }
//}
