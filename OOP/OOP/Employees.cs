using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
    * Create an Employee class
       * Properties
           * id (to identify an employee)
           * name (public name for an employee)
           * salary (yearly salary)
       * Constructor to initialise properties
       * Create a function to give an employee a raise
           * return double, takes in a double
           * increase the salary by the param
               * the param is the % increase in salary
           * store and return new salary
       * Override to string to output properties
       * Extra: add const for number of months
    * In the main:
       * Create an employee
       * Print their details
       * Increase the age & print it through the return values
       * Print and validate new salary in final output
   */
    class Employees
    {
        class Employee
        {
            private const double noOfMonths = 12D;
            private const double decimalConversion = 100D;
            public int id { get; set; }
            public string name { get; set; }
            public double salary { get; set; }

            public Employee(int id, string name, double salary)
            {
                this.id = id;
                this.name = name;
                this.salary = salary;
            }
            public void getARaise(double percentage)
            {
                //50 -> 50% = 75
                //50% of 50 = 25
                //50 + 25 = 75

                //50% / 100 = (0.5) * 50 = 25
                //percentage / 100 = X * salary = raise
                //salary = salary + raise
                //salary += raise
                //double raise = (percentage / 100D) * salary; //50 -> 25
                //salary = salary + raise;
                //salary += raise;
                //return salary;

                salary += (percentage / decimalConversion) * salary;
            }
            public double getMonthlySalary()
            {
                return salary / noOfMonths;
            }
            public override string ToString()
            {
                // return $"id: {id}\nName: {name}\nSalary: £{salary}";

                return $"{name} makes {salary.ToString("C")} a year, which is {getMonthlySalary().ToString("C")} a month";
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Aba", 50000);

            Console.WriteLine(employee);
            employee.getARaise(50);
            Console.WriteLine(employee);

            Console.ReadLine();
        }
    }
}
