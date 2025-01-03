using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class While_Do_While
    {
        public static void WhileDoWhile()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 0;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;  
            //}

            //Console.Write("Enter the 1st no: ");
            //string numberAInput = Console.ReadLine();
            //int numberA = Convert.ToInt32(numberAInput);
            
            //Console.Write("Enter the 2nd no: ");
            //string numberBInput = Console.ReadLine();
            //int numberB = Convert.ToInt32(numberBInput);

            //int answer = numberA * numberB;
            //int actualAnswer = 0;

            //Console.Write("Whats the value of " + numberA + " X " + numberB + ": ");

            //while (answer != actualAnswer) {
            //    Console.Write("Enter your answer: ");
            //    string answerInput = Console.ReadLine();
            //    actualAnswer = Convert.ToInt32(answerInput);

            //    if (answer != actualAnswer)
            //    {
            //         Console.WriteLine("Close but it was wrong");
            //    }
            //}
            //        Console.WriteLine("Well Done!");

            //do
            //{
            //    Console.Write("Enter your answer: ");
            //    string answerInput = Console.ReadLine();
            //    actualAnswer = Convert.ToInt32(answerInput);

            //    if (answer != actualAnswer)
            //    {
            //        Console.WriteLine("Close but it was wrong");
            //    }
            //}
            //while (answer != actualAnswer);
            //Console.WriteLine("Well done");

            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Sell");
            Console.WriteLine("3. Swap");
            Console.Write("Choose a value (1-3): ");
            int option = Convert.ToInt32(Console.ReadLine());

            while (option < 1 || option > 3) {
                Console.WriteLine("Invalid Choice");
                Console.Write("Choose a menu option: ");
                option = Convert.ToInt32(Console.ReadLine());
            }

            switch (option) { 
                case 1: Console.WriteLine("Buy"); break;
                case 2: Console.WriteLine("Sell"); break;
                case 3: Console.WriteLine("Swap"); break;
                default : Console.WriteLine("Invalid"); break;
            }



        }
    }
}
