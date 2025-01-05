//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    class Person
//    {
//        //private string name;
//        //private int age;
//        public string Name { get; set; }
//        public int Age { get; set; }

//        //public string Name
//        //{
//        //    get
//        //    {
//        //        return name;
//        //    }
//        //    set
//        //    {
//        //        this.name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";
//        //    }
//        //}
//        //public string Name
//        //{
//        //    get => name;
            
//        //    set => name = !string.IsNullOrEmpty(value) ? value : "Invalid Name";
            
//        //}

//        //public string Name { get => name; set => name = value; }
//        //public int Age
//        //{
//        //    get
//        //    {
//        //        return age;
//        //    }
//        //    set
//        //    {
//        //        age = value;
//        //    }
//        //}
//        //public int Age
//        //{
//        //    get => age;
            
//        //    set => age = value >= 0 && value <= 150 ? value : -1;
            
//        //}
//        //public int Age { get => age; set => age = value; }

//        public Person(string name, int age)
//        {
//            //this.name = name;
//            //this.age = age;

//            Name = name;
//            Age = age;
//        }


//        /*
//        public void SetName(string name)
//        {
//            this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
//        }

//        public string GetName()
//        {
//            return name;
//        }


//        public void SetAge(int age)
//        {
//            this.age = age >= 0 && age <= 150 ? age : -1;
//        }

//        public int GetAge()
//        {
//            return age;
//        }
//        */

//        public string ReturnDetails()
//        {
//            return $"Name: {Name}\n Age: {Age}";

//        }

//    }
//    public class Properties
//    {
//        public static void Main5()
//        {
//            Person person = new Person("Achyut", 22);
//            Console.WriteLine(person.ReturnDetails());

//            person.Name = "Harry";
//            person.Age = 22;

//            //Console.WriteLine(person.ReturnDetails());

//            Console.WriteLine($"Your name is {person.Name} and age is {person.Age}");
            
//        }
//    }
//}
