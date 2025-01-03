using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Task
    {
        public static void Task1()
        {
            /*
         * Create two lists with integer data type, one for even numbers, one for odd
         * Loop from 0-20
            * If number is even, add to even list
            * If number is odd, add to odd list
         * Print even list
         * Print odd list
        */
                List<int> odd = new List<int>();
                List<int> even = new List<int>();

                for (int i = 0; i <= 20; i++)
                {
                    if (i % 2 == 0) //0 1
                    {
                        even.Add(i);
                    }
                    else
                    {
                        odd.Add(i);
                    }
                }

                Console.WriteLine("Printing even numbers");

                foreach (var item in even)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine(Environment.NewLine + "Printing odd numbers:");


                foreach (var item in odd)
                {
                    Console.Write($"{item} ");
                }

                Console.ReadLine();

            /*
         * Define and initalise two integers (num, length)
         * (7, 5) -> [7, 14, 21, 28, 35]
         * Create int array with size length
         * Loop through and insert the (loop counter * num) into the array
         * Print final array
        */
            
                int num = 10;
                int length = 10;
                int[] result = new int[length];
                int counter = 0;

                for (int i = 1; i <= result.Length; i++, counter++) // 0 - 4  1 - 5
                {
                    result[counter] = num * i;
                }

                foreach (var item in result)
                {
                    Console.Write($"{item} ");
                }

                Console.ReadLine();

            /*
         * Create and initalise char array with 'X' and 'O' randomly
         * Use two for loops to print the board to the console
         * Extra: output a board thats similar to TicTacToe with lines
        */
                char[,] board = new char[,]
                {
                { 'X', 'X', 'X' },
                { 'O', 'O', 'X' },
                { 'O', 'O', 'X' }
                };

                for (int i = 0; i < board.GetLength(0); i++) //Row
                {
                    for (int j = 0; j < board.GetLength(1); j++) //Columns
                    {
                        Console.Write($"| {board[i, j]} ");
                    }

                    Console.WriteLine("|");
                    if (i < board.GetLength(0) - 1) //3-1 = 2
                        Console.WriteLine("-------------");// 0 1 2
                }

                Console.ReadLine();

            /*
         * Create and initalise string array with any menu options
         * I choose:
            * Create new file
            * Open a file
            * Update a file
            * Remove a file
         * Why not use foreach here?
         * For loop, print options
         * Ask user for menu index
         * Convert string input to int and store
         * Validate range of menu choice
            * If valid, print "Valid"
            * If not valid, print "Invalid"
        */
                string[] menuOptions = new string[]
                {
                "Create a new file",
                "Open a file",
                "Update a file",
                "Remove a file"
                };//[0]

                /*int i = 1;
                foreach (var item in menuOptions)
                {
                    Console.WriteLine($"{i}. {item}");
                    i++;
                }*/

                for (int i = 0; i < menuOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuOptions[i]}"); //1,
                }

                Console.Write(Environment.NewLine + "Enter a menu option: ");
                int option = Convert.ToInt32(Console.ReadLine()); //0, 1
                option--;

                //>= 0 < 4 0-3
                if (option >= 0 && option < menuOptions.Length) //0-3 1-4
                {
                    switch (option)
                    {
                        case 0: Console.WriteLine("Create new file"); break;
                        case 1: Console.WriteLine("Open a file"); break;
                        case 2: Console.WriteLine("Update a file"); break;
                        case 3: Console.WriteLine("Delete a file"); break;
                        default: Console.WriteLine("Invalid"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

                Console.ReadLine();

            /*
        * Create a 10 length int array
        * Loop through array and ask user for 10 number input's
           * Store all inputs in the array
        * Loop through the array and calculate the total
        * Output the average 
        * Why are we using 2 loops here? Why not in one? Practise
        * Extra: define a const for the count and use it as much as possible
       */
                const int numCount = 5;
                //int[] numbers = new int[numCount];

                /*int i = 0;
                foreach (var item in numbers)
                {
                    Console.Write("Enter a number: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine()); //0
                    i++;
                }*/

                //for (int i = 0; i < numbers.Length; i++)
                //{
                //    Console.Write("Enter a number: ");
                //    numbers[i] = Convert.ToInt32(Console.ReadLine());
                //}

                //int total = 0;

                //foreach (var item in numbers)
                //{
                //    //total = total + item;
                //    total += item;
                //}

                ///*int total = 0;

                //for (int i = 0; i < 10; i++)
                //{
                //    Console.Write("Enter a number: ");
                //    total += Convert.ToInt32(Console.ReadLine()); //123
                //}*/

                //Console.WriteLine(total);

                //double average = total / Convert.ToDouble(numCount);
                //Console.WriteLine(average);

                //Console.ReadLine();


            /*
         * Create a 3 sized int array
         * Insert custom user values into the array using a for loop
         * Ask user for a number to search
         * The index doesn't matter, just determine if the value is in the array
         * If found, output "Your number is in the list!"
         * If not found, output "Your number is not in the list!"
        */
           
                /*List<int> numbers = new List<int>(3);

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter a number: ");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }

                Console.Write("Enter a number to search: ");
                int search = Convert.ToInt32(Console.ReadLine());

                int index = numbers.IndexOf(search);

                Console.WriteLine(numbers.Contains(search) ? "Found" : "Not found");
                Console.WriteLine(index > -1 ? "Found" : "Not found");

                if (numbers.Contains(search))
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }*/

                int[] numbers = new int[3];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter a number to search: ");
                int search = Convert.ToInt32(Console.ReadLine());

                int index = Array.IndexOf(numbers, search);
                bool found = false;

                // 1 1 1 

                foreach (var item in numbers)
                {
                    Console.WriteLine($"test {item}");
                    if (search.Equals(item))
                    {
                        found = true;
                    }
                }
                //

                if (index > -1)
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }

                //Console.WriteLine(index > -1 ? "Found" : "Not found");
                Console.WriteLine(found ? "Found" : "Not found");
                Console.ReadLine();
            }
    }
}
