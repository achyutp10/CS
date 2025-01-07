//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    interface IPerson
//    {
//        void DoWork();
//        string Name { get; set; }
//        int Age { get; set; }
//    }
//    abstract class Person : IPerson
//    {
//        public string Name { get; set; } 
//        public int Age { get; set; }
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
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
//        public static bool operator >(Person a, Person b)
//        {
//            return a.Age > b.Age;
//        }
//        public static bool operator >=(Person a, Person b)
//        {
//            return a.Age >= b.Age;
//        }
//        public static bool operator <(Person a, Person b)
//        {
//            return a.Age < b.Age;
//        }
//        public static bool operator <=(Person a, Person b)
//        {
//            return a.Age <= b.Age;
//        }

//        public override string ToString()
//        {
//            return $"Name: {Name}\tAge: {Age}";
//        }

//        public abstract void DoWork();
//    }
//    class Student : Person
//    {
//        public int Grade { get; set; }

//        public Student(string name, int age, int grade) : base(name, age)
//        {
//            Grade = grade;
//        }
//        public override void DoWork()
//        {
//            Console.WriteLine("I'm studying!");
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}\tGrade: {Grade}";
//        }
//        public static Student CreateStudent()
//        {
//            Console.Write("Enter student name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter student age: ");
//            int age = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter student grade: ");
//            int grade = Convert.ToInt32(Console.ReadLine());

//            return new Student(name, age, grade);
//        }
//    }

//    class Staff : Person
//    {
//        public int Salary { get; set; }

//        public Staff(string name, int age, int salary) : base(name, age)
//        {
//            Salary = salary;
//        }
//        public override void DoWork()
//        {
//            Console.WriteLine("I'm marking papers.");
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}\tSalary: {Salary}";
//        }
//        public static Staff CreateStaff(bool teacher = false)
//        {
//            string context = teacher ? "teacher" : "staff";

//            Console.Write($"Enter {context} name: ");
//            string name = Console.ReadLine();

//            Console.Write($"Enter {context} age: ");
//            int age = Convert.ToInt32(Console.ReadLine());

//            Console.Write($"Enter {context} salary: ");
//            int salary = Convert.ToInt32(Console.ReadLine());

//            return new Staff(name, age, salary);
//        }
//    }

//    class Teacher : Staff
//    {
//        public string Subject { get; set; }

//        public Teacher(string name, int age, int salary, string subject) : base(name, age, salary)
//        {
//            Subject = subject;
//        }
//        public Teacher(Staff staff, string subject) : base(staff.Name, staff.Age, staff.Salary)
//        {
//            Subject = subject;
//        }
//        public override void DoWork()
//        {
//            Console.WriteLine("I'm teaching");
//        }
//        public override string ToString()
//        {
//            return $"{base.ToString()}\tSubject: {Subject}";
//        }
//        public static Teacher CreateTeacher()
//        {
//            Staff staff = Staff.CreateStaff(true);

//            Console.Write("Enter teacher subject: ");
//            string subject = Console.ReadLine();

//            //return new Teacher(staff.Name, staff.Age, staff.Salary, subject);
//            return new Teacher(staff, subject);
//        }
//    }
//    class StaticFunctions
//    {
//        static void Main()
//        {
//            Student student = Student.CreateStudent();
//            Staff staff = Staff.CreateStaff();
//            Teacher teacher = Teacher.CreateTeacher();

//            Console.ReadLine();
//        }
//    }
//}

