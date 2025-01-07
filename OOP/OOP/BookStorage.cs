using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Create an Author class
        * Properties:
            * name
            * email
            * gender (Extra: make Gender into a enum)
        * Constructor to initialise properties
        * Override toString to give formatted output
     * 
     * Create a Book class
        * Properties:
            * name
            * author
            * price
            * quantity (default this to 0)
        * Constructor to initialise properties:
            * One for all properties but quantities 
            * Another for all AND quantity property
            * call the other constructor to avoid duplicate code
        * Override toString to give formatted output
     * 
     * Create a Person class
        * Properties:
            * name
            * list of books, not array, why not?
        * Constructor to initialise properties
            * One for just name, no books
            * One for name and list of books
                * Call base name only constructor (avoid duplicate code)
            * One for name and a singular book
                * Call base name only constructor (avoid duplicate code)
        * Override toString to give formatted output
     *   
     * Main:
        * Create and initialise an Author
        * Create and initialise 3 books (assign new author to them)
        * Print them out to validate
        * Create and initialise a Person (assign new book)
        * Make a new list of 3 books
        * Update previous Person to use the new book list
        * Iterate through the list of a persons book and output them all
    */
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

        public Author(string name, string email, Gender gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nGender: {Gender}";
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } // = 0; only use in non defaulted constructors
        public Book(string name, Author author, double price, int quantity = 0)
        {
            Name = name;
            Author = author;
            Price = price;
            Quantity = quantity;
        }
        /*public Book(string name, Author author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
        public Book(string name, Author author, double price, int quantity) : this(name, author, price)
        {
            Quantity = quantity;
        }*/
        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author.Name}\nPrice: {Price}\nQuantity: {Quantity}";
        }
    }
    class Person
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, List<Book> books) : this(name)
        {
            Books = books;
        }
        public Person(string name, Book book) : this(name)
        {
            Books = new List<Book>() { book };
            // Books.Add(book);
        }
        public override string ToString()
        {
            string output = $"{Name} owns these books:\n";

            foreach (var book in Books)
            {
                output += book.Name + "\n";
            }

            return output;
        }
        public void OutputBooks()
        {
            Console.WriteLine($"{Name} owns these books:\n");

            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
    class BookStorage
    {
        static void Main201()
        {
            Author author = new Author("Aba", "abacodes@gmail.com", Gender.Male);
            Console.WriteLine(author);
            Console.WriteLine();

            Book csBook = new Book("C# Programming", author, 10, 5);
            Book cppBook = new Book("C++ Programming", author, 10, 5);
            Book javaBook = new Book("Java Programming", author, 10, 5);
            Console.WriteLine(csBook);
            Console.WriteLine();

            List<Book> books = new List<Book>() { csBook, cppBook, javaBook };

            //Person person = new Person("Harry");
            //Person person = new Person("Harry", csBook);
            Person person = new Person("Harry", books);
            person.OutputBooks();
            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
