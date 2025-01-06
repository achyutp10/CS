//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP
//{
//    //class Person
//    //{
//    //    public string name;
//    //    public int age;

//    //    public Person(string name, int age)
//    //    {
//    //        //Console.WriteLine(name); parameter
//    //        this.name = name;
//    //        this.age = age;
//    //        //Console.WriteLine(this.name); global
//    //    }
//    //    public string ReturnDetails()
//    //    {
//    //        //x = 20;
//    //        return $"Name: {name}\n Age: {age}";
//    //    }

//    //}
//    public class VariableScope
//    {
//        static int x = 5;
        
//        public static void Main5()
//        {
//            Person person = new Person("Achyut", 22);

//            Console.WriteLine(person.ReturnDetails());

//            x = 20;

//        }

//        static void something(Person person)
//        {
//            x = 10;
//        }

//    }
//}
