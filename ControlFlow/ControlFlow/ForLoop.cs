using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class ForLoop
    {
        public static void ForLoopMethod() {

            /*
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.Write("How many times you wanna repeat?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter < 0) {
                Console.WriteLine("Sorry please enter value greater than 0");
            }

            for (int i = 0; i < loopCounter; i++) {
                Console.WriteLine(message);
            }
            
            for (int i = 0; i <= 15; i+=2) {
                Console.WriteLine(i);
            }
            */

            // Task for loop

            int total = 0;
            for (int i = 1; i <= 10; i++) { 
                total += i;
            }
            // Console.WriteLine(total);
            Console.WriteLine(total);


        }
    }
}
