using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class PassingByReference
    {
        public static void PassingByReferencee()
        {

            /*int num = 10; //1
          string name = "Joe";
          Assign(ref num, ref name);
          Console.WriteLine(num);
          Console.WriteLine(name);*/

            int.TryParse("", out int index);

            string name = "Joe";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty of null!");
            }


            Console.ReadLine();
        }
        static bool ChangeName(ref string name, string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
        }
        static void Assign(ref int num, ref string name) //1
        {
            name = "Aba";
            num = 20;
        }
    }
}
