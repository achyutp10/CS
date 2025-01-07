using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Create a Customer class
        * Properties:
            * id (to define a customer)
            * name (public name to identify customer)
            * discount (any discount they have available on any purchase)
                * add extra code to lock value 0 - 100
        * Constructor to initialise properties
        * Override to string to output properties
     * Create a Item class
        * Properties:
            * id (to define an item)
            * name (public name to identify item)
        * Constructor to initialise properties
        * Override to string to output properties
     * Create a Invoice class
        * Properties:
            * id (to define an invoice)
            * customer (identify customer in the purchase)
            * item (identify the item the customer purchased)
            * amount (the quantity they bought of that item)
                * lock value to >= 1
        * Constructor to initialise properties
            * Extra: which parameter could be optional?
        * Override to string to output properties
     * In the main:
        * Create a customer
        * Create a item
        * Create a invoice, give it the customer & item declared above
        * Print them all to the screen and make sure it works
        * Play around with the quantity and the name of the items
    */
    class CustomerInvoices
    {
        class Customer
        {
            public int id { get; set; }
            public string name { get; set; }
            public double discount { get; set; }

            public Customer(int id, string name, double discount)
            {
                this.id = id;
                this.name = name;
                this.discount = discount < 0 || discount > 100 ? 0 : discount;

                /*if (discount < 0 || discount > 100)
                {
                    this.discount = 0;
                }
                else
                {
                    this.discount = discount;
                }*/
            }

            public override string ToString()
            {
                return $"id: {id}\nName: {name}\nDiscount: {discount}%";
            }
        }
        class Item
        {
            public int id { get; set; }
            public string name { get; set; }

            public Item(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public override string ToString()
            {
                return $"id: {id}\nName: {name}";
            }
        }
        class Invoice
        {
            public int id { get; set; }
            public Customer customer { get; set; }
            public Item item { get; set; }
            public int amount { get; set; }

            public Invoice(int id, Customer customer, Item item, int amount = 1)
            {
                this.id = id;
                this.customer = customer;
                this.item = item;
                this.amount = amount <= 0 ? 1 : amount;
            }

            public override string ToString()
            {
                //return $"id: {id}\nCustomer: {customer.name}\nItem: {item.name}\nAmount: {amount}";
                return $"{customer.name} has purchased {item.name} using their {customer.discount}% discount {amount} time(s)!";
            }
        }
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Aba", 50);
            Console.WriteLine(customer);

            Console.WriteLine();

            Item item = new Item(1, "C++ Course");
            Console.WriteLine(item);

            Console.WriteLine();

            Invoice invoice = new Invoice(1, customer, item);
            Console.WriteLine(invoice);

            Console.ReadLine();
        }
    }
}
