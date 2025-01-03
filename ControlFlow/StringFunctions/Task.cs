using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    public class Task
    {
        public static  void TaskMethod()
        {
            //Console.Write("Enter a message: ");
            //string message = Console.ReadLine();
            //int messageLength = message.Length;
            //Console.WriteLine($"The length of the message is {messageLength}");

            //if  ( messageLength > 6 ) {
            //    Console.WriteLine("Valid");
            //} else { 
            //    Console.WriteLine("Invalid");
            //}
            //Console.WriteLine(messageLength >= 6 ? "Valid" : "Invalid");

            //for (int i = 0; i < messageLength; i++) {
            //    Console.WriteLine(message[i]);
            //}
            //for (int i = messageLength-1; i >= 0; i--) {
            //    Console.WriteLine(message[i]);
            //}
            //for (int i = length - 1; i >= 0; i--) //forr
            //{

            //}

            //Console.Write("Enter a Password: ");
            //string password = Console.ReadLine();

            //Console.Write("Enter a Confirm Password: ");
            //string passwordC = Console.ReadLine();

            //if (!password.Equals(string.Empty))
            //{
            //    if (!passwordC.Equals(string.Empty))
            //    {
            //        if (password.Length >= 6 && passwordC.Length >= 6)
            //        {
            //            if (password.Equals(passwordC))
            //            {
            //                Console.WriteLine("Match");
            //            }
            //            else
            //            {
            //                Console.WriteLine("PW Donot match");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter 6 or more characters");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a password Connirmation");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a password");
            //}

            //Console.Write("Enter a First Name: ");
            //string fName = Console.ReadLine();
            //Console.Write("Enter a Last Name: ");
            //string lName = Console.ReadLine();

            //fName = fName.Trim();
            //lName = lName.Trim();

            //Console.WriteLine(fName + " " + lName);
            //Console.Write(fName);
            //Console.Write(" ");
            //Console.Write(lName + "\n");
            //Console.Write(string.Concat(fName, " ", lName));
            //Console.WriteLine($"{fName} {lName}");
            //Console.WriteLine("{0} {1}", fName,lName);

            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++) {
                //Console.WriteLine(message[i]);

                if (char.IsLower(message[i]))
                {
                    //Console.WriteLine("Lower");
                    Console.WriteLine(char.ToUpper(message[i]));
                }
                else if (char.IsUpper(message[i]))
                {
                    //Console.WriteLine("Upper");
                    Console.WriteLine(char.ToLower(message[i]));

                    Console.WriteLine(char.IsLower(message[i]) ? 
                    char.ToUpper(message[i]) : 
                    char.ToLower(message[i]));
                }
            }

            foreach (char ch in message)
            {
                if (char.IsLower(ch))
                {
                    //Console.WriteLine("Lower");
                    Console.WriteLine(char.ToUpper(ch));
                }
                else if (char.IsUpper(ch))
                {
                    //Console.WriteLine("Upper");
                    Console.WriteLine(char.ToLower(ch));
                    Console.WriteLine(char.IsLower(ch) ? 
                    char.ToUpper(ch) : 
                    char.ToLower(ch));
                }

            }

            StringBuilder sb = new StringBuilder();

            foreach (char ch in message)
            {
                sb.Append(char.IsLower(ch) ? 
                char.ToUpper(ch) : 
                char.ToLower(ch));
                
            }

        }

    }
}
