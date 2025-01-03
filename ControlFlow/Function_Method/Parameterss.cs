using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Function_Method
{
    public class Parameterss
    {
        //static void Main()
        //{
        //    Console.WriteLine("Hello");
        //    Console.WriteLine(Add(1,2));
        //    Console.WriteLine("Enter a no: ");
        //    int num = ReadInt("Number");
        //    Console.WriteLine(num);
        //    int angle = ReadInt("Angle");
        //    Console.WriteLine(angle);
        //    int firstN = ReadInt("first no");
        //    int secondN = ReadInt("second no");
        //    int result = Add(firstN, secondN);
        //    Console.WriteLine(result);

        //    string name = ReadString("Name");
        //    int age = ReadInt("Age");

        //    string details = UserDetails(name, age);
        //    Console.WriteLine(details);

        //    Print(WelcomeMessage());

        //    Print(GoodbyeMessage());
        //}

        //static string WelcomeMessage()
        //{
        //    return "Hello";
        //}
        //static string GoodbyeMessage()
        //{
        //    return "Goodbye";
        //}
        //static string UserDetails(string name, int age)
        //{
        //    return name + " " + age;
        //}
        //static int ReadInt(string message)
        //{
        //    Console.WriteLine($"Enter a {message}: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}
        //static string ReadString(string message)
        //{
        //    Console.WriteLine($"Enter a {message}: ");
        //    return Console.ReadLine();
        //}

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static void Print(string message)
        //{
        //    Console.WriteLine(message);
        //}

        // Optional parameters ========================>>>>>>>>>>>>>>>>>>>>>>

        //static void Main()
        //{
        //    int result = Add(5);
        //    Console.WriteLine(result);

        //    Print("Hello");

        //    Print("Goodbye");
        //}

        //static int Add(int a, int b = 50) {
        //static int Add(int a, [Optional] int b) {
        //static int Add(int a, int b = default) {
        //    Console.WriteLine(b); // b = 0 as optional
        //return a + b;
        //}
        ////static void PrintName(string name = default)
        //static void PrintName(string name = "Achyut")
        //{
        //    Console.WriteLine(name);
        //}

        //static void Print(string message, bool inline = false)
        //{
        //    if (inline) Console.WriteLine(message);
        //    else Console.WriteLine(message);
        //}


        // Named parameters ========================>>>>>>>>>>>>>>>>>>>>>>


        //static void Main()
        //{
        //    string nameInp = "Achyut";
        //    int ageInp = 22;
        //    string addressInp = "BRT";

        //    PrintInfo(age:ageInp, 
        //        name:nameInp, 
        //        address:addressInp
        //        );

        //    Print(inline:true, message:WelcomeMessage());

        //    Print(message: GoodbyeMessage());

        //}

        //static void PrintInfo(string name, int age, string address)
        //{
        //    Console.WriteLine(name);
        //    Console.WriteLine(age);
        //    Console.WriteLine(address);
        //}


        //static void Print(string message, bool inline = false)
        //{
        //    if (inline) Console.WriteLine(message);
        //    else Console.WriteLine(message);
        //}

        //static string WelcomeMessage()
        //{
        //    return "Hello";
        //}
        //static string GoodbyeMessage()
        //{
        //    return "Goodbye";
        //}

        // Out parameters ========================>>>>>>>>>>>>>>>>>>>>>>


        //public static void MainC()
        //{
        //    int num = 0;
        //    bool success = testc(out num);
        //    //int.TryParse();
        //    //int.TryParse("123", out int result);
        //    int.TryParse("123", out int result);
            
        //    List<string> shoppingList = new List<string>
        //    {
        //        "Coffee", "Milk"
        //    };
        //    Console.WriteLine("Enter item to search: ");
        //    string search = Console.ReadLine();
        //    Console.WriteLine(shoppingList.IndexOf("Coffee"));
        //    //Console.WriteLine(FindInList("Milk", shoppingList, out int index));

        //    if (FindInList(search, shoppingList, out int index))
        //    {
        //        Console.WriteLine(index);
        //    }

        //    //int index = -1;
        //    //for (int i = 0; i < shoppingList.Count; i++)
        //    //{
        //    //    if (shoppingList[i].ToLower().Equals("coffee"))
        //    //    {
        //    //        index = i;
        //    //    }
        //    //}
        //    //bool found = index > -1;
        //    //Console.WriteLine(found ? "Found" : "Not Found" );
        //}

        

        
        //static bool FindInList(string s, List<string> list, out int index)
        //{
        //    index = -1;
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i].ToLower().Equals(s.ToLower()))
        //        {
        //            index = i;
        //        }
        //    }
        //    bool found = index > -1;
        //    Console.WriteLine(found ? "Found" : "Not Found");
        //    return found;
        //}
        //static bool TryParse(string s, out int result)
        //{
        //    result = 0;
        //    return true;
        //}    
        //static bool testc(out int num)
        //{
        //    //num = 5;
        //    //return num;
        //    num = 5;
        //    return true;
        //    //Console.WriteLine(num);
        //}



    }
}
