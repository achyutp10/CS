using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_app
{
    /// <summary>
    /// Nice Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// This is a demo for fundamentals
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //int x,y,z;
            //int x=10,y=20,z=30;
            //int x=10,
            //y=20,
            //z=30;


            //Console.WriteLine("Hello world");
            //Console.ReadLine();
            int age1 = 25; // initializing, declaring and assigning in same line 
            int age3 = -25; // initializing, declaring and assigning in same line
            int age; // initializing, declaring
            age = 22; // assigning
            long bigNmber = 9000000000L;
            long bigNmber2 = -9000000000L;
            //Console.ReadLine();
            Console.WriteLine(age);
            Console.WriteLine(bigNmber);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

           
            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.0000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            age = 50;
            Console.ReadLine();

            //string
            string name = "Achyut";
            char letter = 'a';
            Console.WriteLine(letter);
            Console.WriteLine("Your name is ");
            Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine(name);
            //Console.Writeline(name); syntax error
            //Convert.ToString('Achyut'); runtime error string cant be converted to int

            // convert from string to numbers
            string textAge = "-23";
            int ageInt = Convert.ToInt32(textAge);
            Console.WriteLine(ageInt);

            string textBigNo = "-900000000";
            long bigNoLong = Convert.ToInt64(textBigNo);
            Console.WriteLine(bigNoLong);

            string textDoubleNo = "-55.2";
            double doubleNo = Convert.ToDouble(textDoubleNo);
            Console.WriteLine(doubleNo);

            string textPrecision = "5.0000001";
            float precisionNo = Convert.ToSingle(textPrecision);
            Console.WriteLine(precisionNo);

            string textDecimal = "14.99";
            decimal decimalNo = Convert.ToDecimal(textDecimal);
            Console.WriteLine(decimalNo);

            bool value = true;
            Console.WriteLine(value);

            bool isMale = false;

            int age5 = 5;
            age5++;
            age5 = age5 + 10;
            age5 += 10;
            Console.WriteLine(age5);
            age5--;
            age5 = age5 - 1;
            age5 -= 1;
            Console.WriteLine(age5);

            age5 *= 5;
            double age6 = 55;
            age6 /= 10;

            string nameA = "Achyut";
            nameA += " is Programming";

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            ++i;

            int fNum = 10;
            int fNum2 = 3;

            Console.WriteLine(fNum/fNum2);
            Console.WriteLine(fNum % fNum2);

            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            // var keyword

            //var age2; error
         
            var age2 = 23;
            var bigN = 90000000L;
            var neg = -25.22D;

            //var p = 21.2; not preferable

            // constants

            //int vat = 20;
            //vat = 10; here vat should be fixed so

            const int VAT = 20;
            Console.WriteLine(VAT);

            int balance = 1000;
            Console.WriteLine($"VAT is: {balance *(VAT/100D)}");
            Console.WriteLine("VAT is: {0}", balance *(VAT/100D));

            const double percentVAT = VAT / 100D;
            Console.WriteLine($"VAT is: {balance *percentVAT}");

            const string version = "v1.0";

            // Datatypes

            sbyte sByte; // -129 -> 127
            byte Byte; // 0 -> 255
            short Short; // -32,768 -> 32,767
            ushort uShort; // 0 -> 65,535
            int iInt; //-2.147,483,648 -> 2,147,483,647
            uint uInt; //0 -> 4,294,967,295
            long iLong; //-9,223,372,036,854,775,808 -> 9, 223,372,036,854,775,807
            ulong uLong; //0 -> 18,446,744,073,709,551,615

            string name1 = "Achyut";
            long number = 9259774563L;
            int ageMy = 22;
            Console.WriteLine(name1);
            Console.WriteLine(number);
            Console.WriteLine(ageMy);

            var name2 = "Achyut";
            var num2 = 9796554123;
            var ageV = 22;
            Console.WriteLine(name2);
            Console.WriteLine(num2);
            Console.WriteLine(ageV);

            int num1 = 5;
            int num22 = 10;
            int num3 = 15;
            int total = num1 + num22 + num3;
            int avg = total / 3;
            Console.WriteLine(avg);
            Console.WriteLine(total);

            string a = "Hello";
            string b = "World";
            Console.WriteLine(b);
            Console.WriteLine(a);

            int ab = 10;
            int xy = 2;
            int rem = ab % xy;
            Console.WriteLine(rem);

            //Console.WriteLine("Enter Your Name: ");
            Console.Write("Enter Your Name: ");
            string name22;
            name22 = Console.ReadLine();
            Console.WriteLine(name22);
            Console.ReadLine();

            Console.Write("Enter your age: ");
            string age22 = Console.ReadLine();
            Console.WriteLine(age22);

            Console.Write("Your name is ");
            Console.Write(name22);
            Console.Write(" and your age is ");
            Console.Write(age22);

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            string ageInp = Console.ReadLine();
            int ageINT = Convert.ToInt32(ageInp);


        }
    }
}
