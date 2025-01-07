using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Create Student class
        * Properties:
            * name
            * email
            * school (what school they are attending)
            * CourseType (what type of course they are doing)
            * start year
            * fees (how much they are paying for the course)
        * Constructor to initialise properties
        * Override to string to output properties
            * Extra: use string format to output currency instead of just a number
     * Create Staff class
        * Properties
            * name
            * email
            * school (what school they are attending)
            * salary (how much they earn a year)
        * Constructor to initialise properties
        * Override to string to output properties
            * Extra: use string format to output currency instead of just a number
     * In the main:
        * Create a student
        * Create a staff
        * Print them both to the screen
     * Extra: notice any duplications?
        * Make a something class (abstract?)
        * And use it in the other classes (inheritance of variable?)
        * Make enum for the courseTypes and the schools
     *
     * Check the main again and make sure there is no output difference from before
     * Output shouldn't change, only the structure to be more efficient 
    */
    class PSS
    {
        public enum CourseType
        {
            Degree,
            SelfTaught,
            Internship
        }
        public enum School
        {
            Oxford,
            Cambridge
        }
        abstract class Person
        {
            public string name { get; set; }
            public string email { get; set; }
            public School school { get; set; }

            public Person(string name, string email, School school)
            {
                this.name = name;
                this.email = email;
                this.school = school;
            }

            public override string ToString()
            {
                return $"Name: {name}\nEmail: {email}\nSchool: {school}";
            }
        }
        class Student : Person
        {
            public CourseType courseType { get; set; }
            public int startYear { get; set; }
            public double fees { get; set; }

            public Student(string name, string email, School school, CourseType courseType, int startYear, double fees) : base(name, email, school)
            {
                this.courseType = courseType;
                this.startYear = startYear;
                this.fees = fees;
            }

            public override string ToString()
            {
                return $"{base.ToString()}\nCourse Type: {courseType}\nStart Year: {startYear}\nFees: {fees.ToString("C")}";
            }
        }
        class Staff : Person
        {
            public double salary { get; set; }

            public Staff(string name, string email, School school, double salary) : base(name, email, school)
            {
                this.salary = salary;
            }

            public override string ToString()
            {
                return $"{base.ToString()}\nSalary: {salary.ToString("C")}";
            }
        }
        static void Main(string[] args)
        {
            Staff staff = new Staff("Aba", "abacodes@gmail.com", School.Oxford, 50000);
            Student student = new Student("Aba", "abacodes@gmail.com", School.Oxford, CourseType.Degree, 2018, 20000);

            Console.WriteLine(staff);
            Console.WriteLine();
            Console.WriteLine(student);

            Console.ReadLine();
        }
    }
}
