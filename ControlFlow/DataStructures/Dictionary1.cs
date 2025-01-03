using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Dictionary1
    {
        public static void Dictionary2()
        {
            //Dictionary<int, string> namess = new Dictionary<int, string>()
            //{
            //    {1, "Achyut" },
            //    {2, "Ab" },
            //    {3, "Sm" }
            //};
            //Dictionary<int, string> names = new Dictionary<int, string>();
            //names.Add(1, "Achyut");
            //names.Add(2, "Sam");
            //names.Add(3, "Abu");

            //for (int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<int, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"{pair.Key}, {pair.Value}");
            //}

            //foreach (KeyValuePair<int, string> item in names)
            //{
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}

            //Dictionary<string, string> teachers = new Dictionary<string, string>
            //{
            //    {"Math", "Aba" },
            //    {"Science", "Ram" },
            //};
            //Console.WriteLine(teachers["Math"]);

            //if (teachers.TryGetValue("Math", out string teacher))
            //{
            //    Console.WriteLine(teacher);
            //    teachers["Math"] = "Joe";
            //} else
            //{
            //    Console.WriteLine("Not found");
            //}
            //if (teachers.ContainsKey("Math"))
            //{
            //    teachers.Remove("Math");
            //}
            //foreach (var item in teachers)
            //{
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}

            // Task
            //Dictionary<string, int> scores = new Dictionary<string, int>
            //{
            //    { "Aba", 5 },
            //    { "Test", 2 },
            //    { "Joe", 1 } //Joe -> joe
            //};

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            ////TryParse
            //if (scores.TryGetValue(name, out int score))
            //{
            //    Console.WriteLine($"{name} has score of {score}");
            //}
            //else
            //{
            //    Console.WriteLine("Name not found!");
            //}

            //foreach (var item in scores)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //}

            //Console.ReadLine();
            //Console.Clear();

            ////End of section 1 (get)

            //Console.Write("Enter your name: ");
            //string nameInput = Console.ReadLine();

            //Console.Write("Enter your score: ");
            //int scoreInput = Convert.ToInt32(Console.ReadLine());

            //if (!scores.ContainsKey(nameInput))
            //{
            //    scores.Add(nameInput, scoreInput);
            //}
            //else
            //{
            //    scores[nameInput] += scoreInput;
            //}

            //foreach (var item in scores)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //}

            //Console.ReadLine();
            //Console.Clear();

            ////End of section 2 (insert)

            //Console.Write("Enter a name to remove: ");
            //nameInput = Console.ReadLine();

            //if (!scores.Remove(nameInput))
            //{
            //    Console.WriteLine("Name does not exist");
            //}

            //foreach (var item in scores)
            //{
            //    Console.WriteLine($"{item.Key}\t{item.Value}");
            //}

            //Console.ReadLine();

            // ==========================================


            //CSV files
            //Name, Age, Score
            //Aba,23,1
            //Joe,20,10

            /*string comma = "Aba,23,1";
            string[] commas = comma.Split(',');
            Console.WriteLine(string.Join("", commas)); //Aba231

            string name;
            int age;
            int score;

            if (commas.Length == 3)
            {
                name = commas[0];
                age = Convert.ToInt32(commas[1]);
                score = Convert.ToInt32(commas[1]);
            }

            foreach (var item in commas)
            {
                Console.WriteLine(item);
            }*/

            /*string word = "Hello my name is Aba";
            string[] words = word.Split(' ');
            Console.WriteLine($"There is {words.Length} words in this sentence.");
            Console.WriteLine(string.Join("", words));

            foreach (var item in words)
            {
                Console.WriteLine(item.Length);
            }*/

            /*string number = "1$2$3";
            string[] numbers = number.Split('$');
            Console.WriteLine(string.Join(" ", numbers));*/ // 1 2 3

            string pair = "Name:Aba";
            string[] pairs = pair.Split(':'); //Name Aba

            if (pairs.Length == 2)
            {
                Console.WriteLine($"{pairs[0]} {pairs[1]}");
            }




            Console.ReadLine();
        }

        
    }
}
