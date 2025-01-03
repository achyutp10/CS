using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Arrays
    {
        public static void Arrayy()
        {
            //int n1 = 5;
            //int n2 = 15;
            //int n3 = 25;

            //int total = n1 + n2 + n3;

            //if (total == 180)
            //{
            //    Console.WriteLine("Valid");
            //}


            //int[] numbers = new int[4];
            //Console.Write("Enter a no: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a no: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a no: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a no: ");
            //numbers[3] = Convert.ToInt32(Console.ReadLine());
            ////numbers[1] = 20;
            ////numbers[2] = 30;

            ////Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            //Console.Write($"How many no do you want?: ");
            //int[] numbers = new int[4];
            //Console.Write("How many numbers do you want?: ");
            //int numCount = int.Parse(Console.ReadLine()); 
            //int[] numbers = new int[numCount];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter no {i+1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //Console.WriteLine();
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i} ");
            //}

            //int[] angles = new int[3];

            //for (int i = 0; i < angles.Length; i++)
            //{
            //    Console.Write($"Enter angle {i+1}: ");
            //    angles[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int angleSum = 0;
            //foreach (int angle in angles)
            //{
            //    angleSum += angle;
            //}
            //Console.WriteLine(angleSum);

            //if (angleSum == 180)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invaid");
            //}
            //Console.WriteLine(angleSum==180 ? "Valid": "Invalid!");


            // ============================================================

            //const int angleCount = 3;
            //angleSum = 0;

            //for (int i = 0; i < angleCount; i++)
            //{
            //    Console.Write($"Enter angle {i + 1}: ");
            //    angleSum += Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid!");

            //string coffee = "Coffee";
            //string bread = "Bread";
            //string milk = "Milk";
            //string eggs = "Eggs";

            //Console.WriteLine("My Shopping lish:\n");
            //Console.WriteLine($"1. {coffee}");
            //Console.WriteLine($"2. {bread}");
            //Console.WriteLine($"3. {milk}");
            //Console.WriteLine($"4. {eggs}");

            //string[] shoppingList = new string[4];


            //shoppingList[0] = "Coffee";
            //shoppingList[1] = "Bread";
            //shoppingList[2] = "Milk";
            //shoppingList[3] = "Eggs";

            //string[] shoppingList = new string[]
            //{
            //    "Coffee", "Bread", "Milk", "Eggs"
            //};

            ////for (int i = 0; i < shoppingList.Length; i++)
            ////{
            ////Console.Write($"{i+1}. {shoppingList[i]} ");
            ////}

            //int i = 1;

            //foreach (string item in shoppingList)
            //{
            //    Console.WriteLine($"{i}. {item}");
            //    i++;
            //}

            // ==========================
            // sorting arrays

            //int[] numbers = new int[] {
            //    1, 12, 3, 14, 2, 6, 4, 8, 9, 10
            //};

            //string test = "";
            //test = test.Replace(" ", "");

            ////Array.Sort(numbers);

            ////foreach (int i in numbers)
            ////{
            ////    Console.WriteLine($"{i}");
            ////}

            //// Task2

            //string[] shoppingList = new string[]
            //{
            //    "Coffee", "Bread", "Milk", "Eggs"
            //};

            //Array.Sort(shoppingList);
            //Console.WriteLine("My Sorted: "+ Environment.NewLine);

            ////for (int i = 0; i < shoppingList.Length; i++)
            ////{
            ////    Console.Write($"{i+1}. {shoppingList[i]} ");
            ////}

            //int i = 0;

            //foreach (var item in shoppingList)
            //{
            //    Console.Write($"{i+1}. {item} ");

            //}

            //// Reverse arrays

            //int[] numbers = new int[] {
            //    1, 12, 3, 14, 2, 6, 4, 8, 9, 10
            //};

            //int[] sorted = new int[numbers.Length];

            //int x = 0;

            //for (int q = numbers.Length - 1; q >= 0; q--)
            //{
            //    sorted[x] = numbers[q];
            //    x++;
            //}

            //foreach (var no in sorted)
            //{
            //    Console.WriteLine(no);
            //}

            //Array.Reverse(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}

            // ===============<<<<<<<<<<<<<<<<<<############>>>>>>>>>>>>>>>>>>>>>>>##############<<<<<<<<<<<<<<<<<>>>>>>>>
            // Task 3

            //string[] shoppingList = new string[]
            //{
            //    "Coffee", "Bread", "Milk", "Eggs"
            //};

            //Array.Reverse(shoppingList);

            //Console.WriteLine("My Reversed shopping list: ");

            ////for (int i = 0; i < shoppingList.Length; i++)
            ////{
            ////    Console.WriteLine($"{i+1}. {shoppingList[i]}");
            ////}

            //foreach (var item in shoppingList)
            //{
            //    Console.WriteLine(item);
            //}

            // ===============<<<<<<<<<<<<<<<<<<############>>>>>>>>>>>>>>>>>>>>>>>##############<<<<<<<<<<<<<<<<<>>>>>>>>
            // Copy Arrays

            //int[] numbers = new int[] {
            //    1, 12, 3, 14, 2, 6, 4, 8, 9, 10
            //};

            ////int[] copyTest = new int[5];
            //int[] copyTest = new int[numbers.Length];

            //Array.Copy(numbers, copyTest, 5);
            //Array.Copy(numbers, copyTest, copyTest.Length);
            //Array.Copy(numbers, 2, copyTest, 2, 8);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    copyTest[i] = NumberStyles[i];
            //}

            //foreach (int number in copyTest)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] a = new int[] {1};
            //int[] b = new int[a.Length];

            //b = a;
            //Console.WriteLine(b[0]);
            //a[0] = 100;

            //Console.WriteLine(b[0]);

            // Clear array

            //int[] numbers = new int[] {
            //    1, 12, 3, 14, 2, 6, 4, 8, 9, 10
            //};
            //Array.Clear(numbers, 5, 5);

            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    numbers[i] = default;
            ////}
            //for (int i = 5; i < 10; i++)
            //{
            //    numbers[i] = default;
            //}


            //Array.Clear(numbers, 0, numbers.Length);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] shoppingList = new string[]
            //{
            //    "Coffee", "Bread", "Milk", "Eggs"
            //};

            ////Array.Clear(shoppingList, 0, shoppingList.Length);

            //for (int i = 0; i < shoppingList.Length; i++)
            //{
            //    if (!string.IsNullOrEmpty(shoppingList[i])) {

            //    Console.WriteLine($"{i+1} {shoppingList[i]}");
            //    }
            //}
            //foreach (var item in shoppingList)
            //{
            //    if (!string.IsNullOrEmpty(item))
            //    {
            //        Console.WriteLine($"{item}");
            //    }
            //}

            // IndexOf

            //int[] numbers = new int[] {
            //    1, 12, 3, 14, 2, 6, 4, 8, 9, 10
            //};
            //Console.WriteLine("Enter no to search: ");
            //int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search);
            //int position = Array.IndexOf(numbers, search, 2);
            //int position = Array.IndexOf(numbers, search, 1, 2);

            //if (position > -1)
            //{
            //    Console.WriteLine($"No {search} is found at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //int position = -1;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == search)
            //    {
            //        position = i;
            //    }
            //}
            //if (position > -1)
            //{
            //    Console.WriteLine($"No {search} is found at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            // Task

            //string[] shoppingList = new string[]
            //{
            //    "Coffee", "Bread", "Milk", "Eggs"
            //};
            //Console.WriteLine("Enter item to search: ");
            //string search = Console.ReadLine().ToLower();

            ////int position = Array.IndexOf(shoppingList, search);

            //bool found = false;
            //int position = -1;

            ////foreach (var item in shoppingList)
            ////{
            ////    if (item.Equals(search))
            ////    {
            ////        found = true;
            ////    }
            ////}

            //for (int i = 0; i < shoppingList.Length; i++)
            //{

            //    if (shoppingList[i].ToLower().Equals(search))
            //    {
            //        position = i;
            //    }
            //}
            //if (position > -1)
            //{
            //    Console.WriteLine($"{shoppingList[position]} was found at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //if (found)
            //{
            //    Console.WriteLine($"{search} was found.");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //if (position > -1)
            //{
            //    Console.WriteLine($"{shoppingList[position]} was found at position {position}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < shoppingList.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. {shoppingList[i]}");
            //}

            //================Multi Dimensional Array================Multi Dimensional Array>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //================Multi Dimensional Array================Multi Dimensional Array>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            // >>>>>>>>>>>>>>>Multi Dimensional Array<<<<<<<<<<<<<<<<Multi Dimensional Array>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //================Multi Dimensional Array================Multi Dimensional Array>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            //================Multi Dimensional Array================Multi Dimensional Array>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            int[] no = new int[4];
            no[0] = 2;
            no[1] = 1;
            no[2] = 3;
            no[3] = 4;

            int[] row1 = new int[]
            {
                0, 1, 2
            };
            int[] row2 = new int[3];
            int[] row3 = new int[3];

            //char[,] board = new char[3, 3];
            //board[0,0] = 'X'; 
            //board[0,1] = 'X';
            //board[0,2] = 'X';
            //board[1,0] = 'X';
            //board[1,1] = 'X';
            //board[2,2] = 'X';

            int[,] board = new int[3,3]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };

            int[,,] chessBoard = new int[3, 4, 3]
            {
                {
                    { default, default, default},
                    { default, default, default},
                    { default, default, default},
                    { default, default, default}
                },{
                    { default, default, default},
                    { default, default, default},
                    { default, default, default},
                    { default, default, default}
                },{
                    { default, default, default},
                    { default, default, default},
                    { default, default, default},
                    { default, default, default}
                },

            };

            //Console.WriteLine(chessBoard.GetLength(0)); // levels
            //Console.WriteLine(chessBoard.GetLength(1)); // Row
            //Console.WriteLine(chessBoard.GetLength(2)); // Columns

            //Console.WriteLine(chessBoard.GetLength(1)); // Row
            //Console.WriteLine(chessBoard.GetLength(2)); // Columns

            //Console.WriteLine(chessBoard.Length);
            //Console.WriteLine(board.Length);

            //for (int i = 0; i < board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < board.GetLength(0); j++)
            //    {
            //        Console.Write($"{board[i,j]} ");
            //    }
            //    //Console.WriteLine(board[i,0]);
            //    Console.WriteLine();
            //}

            for (int i = 0; i < chessBoard.GetLength(0); i++) // levels
            {
                for (int j = 0; j <  chessBoard.GetLength(1); j++) // Rows
                {
                    for (int k = 0; k < chessBoard.GetLength(2); k++) // columns
                    {
                        Console.Write($"{chessBoard[i,j,k]} ");
                    }
                    Console.WriteLine();
                    }
                    Console.WriteLine();
            }

            foreach (var item in board)
            {
                Console.WriteLine($"{item}");
            }
            foreach (var item in chessBoard)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
