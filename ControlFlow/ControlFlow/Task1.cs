using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class Task1
    {
        public static void PerformTask()
        {
            //Console.Write("Enter an hour using 24-hr format"); 
            //string hourInput = Console.ReadLine();
            //int hour = Convert.ToInt32(hourInput);

            //Console.WriteLine(hour);

            //if (hour >= 0 && hour <= 5)
            //{
            //    Console.WriteLine("Dawn");
            //}
            //else if (hour >= 6 && hour <= 11)
            //{
            //    Console.WriteLine("Morning");
            //}
            //else if (hour >= 12 && hour <= 17)
            //{
            //    Console.WriteLine("Afternoon");
            //}
            //else if (hour >= 18 && hour <= 23)
            //{
            //    Console.WriteLine("Evening");
            //}
            //else {
            //    Console.WriteLine("Invalid time");
            //}

            //Task1 task = new Task1();

            // Task control flow ------------------>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<---------------------

            // table exercise

            //Console.Write("Enter a no: "); 
            //int no = Convert.ToInt32(Console.ReadLine());
            ////string noInp = Console.ReadLine();
            ////int inp = Convert.ToInt32(noInp);

            //for (int i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(no + " X " + i +" = " + no*i);
            //    Console.WriteLine("{0} X {1} = {2}", no, i, i*no);
            //}

            // Age check output
            //Console.Write("Enter your age: ");
            //int age;
            //string ageInput = Console.ReadLine();
            //bool success = int.TryParse(ageInput, out age);

            //if (success)
            //if (int.TryParse(Console.ReadLine(), out int age) )
            //{
            //    if (age < 0 || age > 150)
            //    {
            //        Console.WriteLine("Invalid age");
            //    }
            //    else if (age >= 0 && age <= 12)
            //    {
            //        Console.WriteLine("Child");
            //    }else if (age >= 13 && age <= 18)
            //    {
            //        Console.WriteLine("Teen");
            //    }else if (age >= 19 && age <= 59)
            //    {
            //        Console.WriteLine("Adult");
            //    }else if (age >= 60)
            //    {
            //        Console.WriteLine("Senior");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age input");
            //}

            //Console.Write("Enter a value in C: ");
            //double c = Convert.ToDouble(Console.ReadLine());
            //double f = (c * (9D / 5D)) + 32;
            //Console.WriteLine(f);

            //Console.Write("Enter a value in F: ");
            //double fe = Convert.ToDouble(Console.ReadLine());
            //double ce = (fe - 32) * (5D/9D);
            //Console.WriteLine("Value in C is: {0:0.000} C", ce);

            //Console.Write("Enter a value: ");
            //int no = Convert.ToInt32(Console.ReadLine());
            //int resut = no;

            //if (no <= 1) 
            //{
            //    resut = 1;
            //}
            //else
            //{
            //    for (int i = 1; i < no; i++)
            //    {
            //        resut *= i;
            //        Console.WriteLine(resut);
            //    }
            //}
            //Console.WriteLine("{0}! = {1}", no, resut);

            // ====================
            //bool threeDiv = false;
            //bool fiveDiv = false;
            //for (int i = 1; i <= 15; i++)
            //{
            //    threeDiv = i % 3 == 0;
            //    fiveDiv = i % 3 == 0;
            //    if (threeDiv && fiveDiv)
            //    {
            //        Console.WriteLine("Fizzbuzz");
            //    }
            //    else if (threeDiv) 
            //    {
            //        Console.WriteLine("Fizz");
            //    }else if (fiveDiv) 
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // ============================> how many days since birth

            //const int currYear = 2025;
            //const int yearDays = 365;

            //Console.WriteLine("Enter your birth year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //int yearDiff = currYear - year;
            //int totalDays = yearDiff * yearDays;
            //Console.WriteLine(totalDays);
            //Console.WriteLine((currYear - year) * yearDays);

            // ============================

            //Console.Write("Enter a day of week (1-7): ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //if (day >= 1 && day <=7)
            //{
            //    if (day == 1)
            //    {
            //        Console.WriteLine("Sunday");
            //    }
            //    else if (day == 2) {
            //        Console.WriteLine("Monday");
            //    }else if (day == 3) {
            //        Console.WriteLine("Tuesday");
            //    }else if (day == 4) {
            //        Console.WriteLine("Wednesday");
            //    }else if (day == 5) {
            //        Console.WriteLine("Thursday");
            //    }else if (day == 6) {
            //        Console.WriteLine("Friday");
            //    }else if (day == 7) {
            //        Console.WriteLine("Saturday");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //switch (day) { 
            //case 1: Console.WriteLine("Sunday"); break;
            //case 2: Console.WriteLine("MonDay"); break;
            //case 3: Console.WriteLine("Tuesday"); break;
            //case 4: Console.WriteLine("Wednesday"); break;
            //case 5: Console.WriteLine("Thursday"); break;
            //case 6: Console.WriteLine("Friday"); break;
            //case 7: Console.WriteLine("Saturday"); break;
            //    default: Console.WriteLine("Invalid"); break;
            //}
            // ===========================

            //for (int i = 1; i <= 100; i++) {
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine("Even");
            //    } else
            //    {
            //        Console.WriteLine("Odd");
            //    }

            //}

            // ===============================

            //Console.Write("Enter angle 1: ");
            //int angle1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter angle 2: ");
            //int angle2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter angle 3: ");
            //int angle3 = Convert.ToInt32(Console.ReadLine());

            //int angleSum = angle1 + angle2 + angle3;

            //if (angleSum == 180) {
            //    Console.WriteLine("Valid");
            //} else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            //int total = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write("Enter a no ({0}): ", i);



            //    if (int.TryParse(Console.ReadLine(), out int num))
            //    {
            //        total += num;
            //    }
            //    else
            //    {
            //        total += 0;
            //    }

            //}
            //Console.WriteLine("The total is: ({0})", total);

            // ====================>>>

            //Console.Write("Enter 1: ");
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 2: ");
            //int no2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 3: ");
            //int no3 = Convert.ToInt32(Console.ReadLine());

            //int total = no1 * no2 * no3;
            //Console.Write(total);

            //Console.Write("Enter 1: ");
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 2: ");
            //int no2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter 3: ");
            //int no3 = Convert.ToInt32(Console.ReadLine());

            //if (no1 > no2 && no1 > no3)
            //{
            //    Console.WriteLine("{0} is the biggest", no1 );
            //}
            //else if (no2 > no1 && no2 > no3)
            //{
            //    Console.WriteLine("{0} is the biggest", no2 );
            //}
            //else if (no2 == no1 && no2 == no3)
            //{
            //    Console.WriteLine("equal");
            //}
            //else
            //{
            //    Console.WriteLine("{0} is the biggest", no3 );
            //}

            Console.WriteLine("Enter a no: ");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} is {1}", no,no%2==0 ? "Even": "Odd");

        }

    }
}
