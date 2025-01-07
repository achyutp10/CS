using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Enums
    {
        public enum Grade
        {
            Invalid,
            A = 1, //1
            B, //2
            C, //3
            D, //4
            E, //5
        }
        class Person
        {
            public string Name { get; set; }
            public Grade Grade { get; set; }

            public Person(string name, Grade grade)
            {
                Name = name;
                Grade = grade;
            }

            public override string ToString()
            {
                /*string grade = "";

                switch (Grade)
                {
                    case Grade.A: grade = "A"; break;
                    case Grade.B: grade = "B"; break;
                    case Grade.C: grade = "C"; break;
                    case Grade.D: grade = "D"; break;
                    case Grade.E: grade = "E"; break;
                    default: grade = ""; break;
                }*/

                return $"Your name is {Name} and your grade is {Grade}.";
            }

            public static Person Create()
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("A = 1");
                Console.WriteLine("B = 2");
                Console.WriteLine("C = 3");
                Console.WriteLine("D = 4");
                Console.WriteLine("E = 5");
                Console.Write("Enter your grade: "); //A a Z z 1

                string input = Console.ReadLine();

                if (char.IsLower(input[0]))
                {
                    input = input.ToLower();
                }

                if (Enum.TryParse(input, out Grade myGrade))
                {
                    if (!Enum.IsDefined(typeof(Grade), myGrade))
                    {
                        myGrade = default;
                    }
                }

                return new Person(name, myGrade);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person person = Person.Create();
                Console.WriteLine(person);

                Console.ReadLine();
            }
        }
    }
}
