using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringFunctions
{
    public class StringFn
    {
        public static void Strings()
        {
            // Interpolation ($)

            //string name = "Achyut";
            //int age = 22;
            //Console.WriteLine($"Your name is {name} and age is {age}");

            // Composite Formatting {0}

            //Console.WriteLine("Your name is {0} and age is {1}", name, age);
            //Console.WriteLine("Name: " +name + "\nAge: " + age);
            //Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            // Interpolation (@)

            // \t \n \" \\ = \

            //string path = "C:\\Users\\Coffee\\Desktop\nNew line";
            //Console.WriteLine(path);
            //string speech = "He said \"Something\"";
            //Console.WriteLine(speech);

            //$ +
            //$"Your name is {name}"
            //"Your name is "+ name

            //path = @"C:\users\achyut\desktop";
            //path = @"C:\users\achyut\desktop" + "\nNew line";
            //Console.WriteLine(path);

            //string name2 = @"Hello ""Someone""";
            //Console.WriteLine(name2);
            //name2 = "Hello 'someone'";
            //Console.WriteLine(name2);

            //// concatination and plus operator

            //Console.WriteLine("Your name is" + name + " and age is " + age);

            //string test = string.Concat("Your name is ", name, " and age is ", age);
            //Console.WriteLine(test);

            //string[] names = new string[] { "Achyut ", "Test ", "Test " };
            //Console.WriteLine(string.Concat(names));

            // Empty ===============>>>>
            //string name3 = "";
            //Console.WriteLine("Enter your name: ");
            //string name5 = Console.ReadLine();
            //if (name5 != string.Empty)
            //{
            //    Console.WriteLine($"Your name is {name}");
            //}else
            //{
            //    Console.WriteLine("Name is empty");
            //}
            //string name4 = string.Empty;


            // equals

            //string m = "Hello";
            //string c = "Hello";

            //if (m == c) {
            //    Console.WriteLine("Same");
            //} else
            //{
            //    Console.WriteLine("Diff");
            //}


            //Console.WriteLine("Enter your name: ");
            //string name6 = Console.ReadLine();

            //if (name6 != "")
            //if (!name.Equals(""))
            //{
            //    Console.WriteLine("Your name is " + name6);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid name input");
            //}

            //char[] chars = new char[] { 'H', 'E', 'L' };
            //object newCompare = new string(chars);

            //if (m == newCompare)
            //{
            //    Console.WriteLine("Same");
            //} else
            //{
            //    Console.WriteLine("Different");
            //}

            // contains
            //string m = "Hello good job";
            //string c = "Hello Achyut hello yaar hello yess";

            //bool success = m.Contains(c);
            //Console.WriteLine(success);
            //Console.WriteLine(c.Contains(m));

            //if (m.Contains(c))
            //{
            //    Console.WriteLine("Success");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //// Insert
            //Console.WriteLine(m.Insert(0, "Wow, "));
            //Console.WriteLine(m.Insert(5, " Wow, "));
            //m = m.Insert(0, "wow, ");

            //string error = "Something went wrong - ";
            //error = error.Insert(error.Length, "Try again later!");
            //Console.WriteLine(error);

            //// Replace
            //m = m.Replace("H", "Je");
            //Console.WriteLine(m);
            //m = m.Replace("e","el");
            //Console.WriteLine(m);
            //m = m.Replace(" ",string.Empty);

            // Index of
            //Console.WriteLine(m.IndexOf("l"));

            //if (m.IndexOf("l")>0)
            //{
            //    Console.WriteLine("Found");
            //}
            //Console.WriteLine("What do you want to search?: ");
            //string search = Console.ReadLine();
            //int index = m.IndexOf(search);

            //if (index >= 0)
            //{
            //    Console.WriteLine($"Found in string at position {index}");
            //} 
            //else 
            //{
            //    Console.WriteLine("Not found");
            //}
            // Remove
            //m = m.Remove(0);
            //Console.WriteLine(m);

            //m = m.Remove(0, 1);
            //Console.WriteLine(m);

            //string colon = "Name:Achyut";
            //int colonIndex = colon.IndexOf(":");
            //Console.WriteLine(colonIndex);
            //Console.WriteLine(colon.Remove(colonIndex));

            //string name = colon.Remove(colonIndex);
            //string value = colon.Remove(0, colonIndex+1);
            //Console.WriteLine(name);
            //Console.WriteLine(value);

            // Substring
            //string m = "Hello good job";
            //string c = "Hello Achyut hello yaar hello yess";

            //m = m.Substring(2);
            //m = m.Substring(1,2);
            //m = m.Substring(0,2);
            //Console.WriteLine(m.Substring(0));
            //Console.WriteLine(m.Substring(1));
            //Console.WriteLine(m.Substring(5));
            //Console.WriteLine(m);

            //string colon = "Name:Achyut";
            //int colonIndex = colon.IndexOf(":");
            //string name = colon.Substring(0,colonIndex);
            //string value = colon.Substring(colonIndex+1);
            //Console.WriteLine($"{name} {value}");

            //colon = "Age:22";
            //colonIndex = colon.IndexOf(":");
            //name = colon.Substring(0,colonIndex);
            //value = colon.Substring(colonIndex+1);
            //Console.WriteLine($"{name} {value}");

            // Iterate through string
            string m = "Hello good job C#";
            string c = "Hello Achyut hello yaar hello yess";
            //Console.WriteLine(m[0]);
            //Console.WriteLine(m[1]);
            //Console.WriteLine(m[2]);
            //Console.WriteLine(m[3]);
            //Console.WriteLine(m[4]);
            //Console.WriteLine(m[5]);
            //Console.WriteLine(m[6]);

            //for (int i = 0; i<m.Length; i++)
            //{
            //    Console.WriteLine(m[i]);
            //    Thread.Sleep(150);
            //}
            //Console.WriteLine(m.Contains("C"));

            //bool contains = false;

            //for (int i = 0; i < m.Length; i++)
            //{
            //    if (m[i].Equals('C'))
            //    {
            //        contains = true;
            //    }
            //}
            // Console.WriteLine(contains);

            // isNullOrEmpty

            //m = null;
            //if (m != "")
            //  Console.WriteLine("0");

            //if (!m.Equals(""))
            //{
            //    Console.WriteLine("1");
            //}
            //if (!string.IsNullOrEmpty(m)) {
            //    if (!m.Equals(""))
            //    {
            //        Console.WriteLine("");
            //    }
            //    Console.WriteLine("2");
            //}

            // ToString

            //int numI = 5;
            //double numD = 5.13D;
            //float numF = 5.987f;
            //decimal numM = 5.456M;
            //string stringI = numI.ToString();

            //Console.WriteLine(numI.ToString());
            //Console.WriteLine(numD.ToString());
            //Console.WriteLine(numF.ToString());
            //Console.WriteLine(numM.ToString());
            //Console.WriteLine(stringI);

            // ToUpper and ToLower

            //string message = "C# is awesome!";
            //Console.WriteLine(message.ToLower());
            //Console.WriteLine(message.ToUpper());

            string name = "Achyut";
            string compare = "achyut";

            //if (name.ToLower().Equals(compare.ToLower())) {
            //    Console.WriteLine("Same");
            //}

            //Console.Write("Enter your name: ");
            //string nI = Console.ReadLine();
            //Console.WriteLine(nI[0]);
            //nI = char.ToUpper(nI[0]).ToString() + nI.Substring(1);
            //Console.WriteLine(nI);

            //StartsWith & EndsWith

            //Console.WriteLine(name.StartsWith("Ac"));
            //Console.WriteLine(name.EndsWith("t"));
            //Console.WriteLine(name.StartsWith("c"));

            //string no = "+9779809887654";
            //Console.WriteLine(no.StartsWith("+977"));

            //if (no.StartsWith("+977"))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //string url = "http://www.google.com";

            // Trim
            //string message = " C# is awesome! ";


            //Console.WriteLine(message.Trim());
            //Console.WriteLine(message.TrimStart());
            //Console.WriteLine(message.TrimEnd());

            string no = " +9779809887654";
            //no = no.Trim().Replace(" ","");
            //Console.WriteLine(no.StartsWith("+977"));
            //Console.WriteLine(no.Trim().StartsWith("+977"));

            string url = " http://www.google.com ";
            //url = url.Trim();
            //Console.WriteLine(url.EndsWith("com "));

            // =============================>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<================================

            // StringBuilder

            //StringBuilder stringBuilder = new StringBuilder(); 
            //StringBuilder stringBuilder = new StringBuilder(5);
            //StringBuilder stringBuilder = new StringBuilder("Hello World");
            //StringBuilder stringBuilder = new StringBuilder(5, 20);
            //StringBuilder stringBuilder = new StringBuilder("Hello world", 5);
            StringBuilder stringBuilder = new StringBuilder("Hello", 0, 5, 10);

            stringBuilder.Append("Hello ");
            stringBuilder.Append("World");
            stringBuilder.AppendLine("Hello ");
            stringBuilder.AppendLine("World");
            stringBuilder.Replace("World", "WORLD");
            stringBuilder.Insert(stringBuilder.Length, "Hi"+Environment.NewLine, 5);
            stringBuilder.Remove(0,5);
            stringBuilder.Clear();

            string message1 = "";
            //message1 += "Hello" + Environment.NewLine;
            message1 += "Hello\n";
            message1 += "World";
            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine(message1);

            for (int i = 0; i < 5; i++)
            {
                message1 += "Hi" + Environment.NewLine;
            }
            Console.WriteLine(message1);
            string message = message1.Replace("Hi", "Hello");
            message = message1.Remove(0,5);
            message = "";

















        }
    }
}
