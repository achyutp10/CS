using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class List1
    {
        public static void List2() 
        {
            //int[] numbers = new int[4];
            //int[] newNumbers = new int[5];

            //int[] numbers = new int[3]
            //    {
            //        1,2,3
            //    };

            ////List<int> listNo = new List<int>();
            //List<int> listNo = new List<int>()
            //{
            //   8,9,10
            //};

            //listNo.Add(15);
            //listNo.Add(16);
            //listNo.Add(13);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter a no: ");
            //    listNo.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //for (int i = 0; i < listNo.Count; i++)
            //{
            //    Console.WriteLine(listNo[i]);
            //}

            //listNo.RemoveAt(0);

            // Task

            List<string> shoppingList = new List<string>()
            {
                "Cheese","Bread","Milk","Chocolate"
            };

            Console.Write("Enter a item: ");
            string input = Console.ReadLine();
            //shoppingList.Add();
           /* bool found = false;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals(input.ToLower()))
                {
                    found = true;
                }

            }
            if (found)
            {
                Console.WriteLine("Found");
            }
            else
            {
                shoppingList.Add(input);
            }
           */


            //if (!shoppingList.Contains(input)) {
            //    shoppingList.Add(input);    
            //}
            //else
            //{
            //    Console.WriteLine($"{input} already exist in list. \n");
            //}
            //for (int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a item to update: ");
            string update = Console.ReadLine();

            int index = shoppingList.IndexOf(update);

            if (index > -1)
            {
                Console.WriteLine("Enter your replacement: ");
                shoppingList[index] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a item to delete: ");
            string delete = Console.ReadLine();

            index = shoppingList.IndexOf(delete);

            if (index > -1)
            {
               
                shoppingList.RemoveAt(index);
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
