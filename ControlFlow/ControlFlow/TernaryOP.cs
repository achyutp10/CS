using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http;

namespace ControlFlow
{
    public class TernaryOP
    {
        public static async void Ternary() {

            //int age = -10;

            //if (age >= 0) {
            //    Console.WriteLine("Valid");
            //} else
            //{
            //    Console.WriteLine("Invalid");
            //}
            //// condition ? true : false
            //string result = age >= 0 ? "Valid" : "Invalid";
            //Console.WriteLine(result);

            //int var1 = 5;
            //int var2 = 10;

            //if (var1 > var2) {
            //    Console.WriteLine("Val1 is Greater");
            //}
            //else
            //{
            //    Console.WriteLine("Val2 is greater");
            //}

            //string result = var1 > var2 ? "Val1 is greater" : "Val2 is greater";
            //Console.WriteLine(result);

            //double alue = 1000D / 12.34D;
            //Console.WriteLine(alue);
            //Console.WriteLine(string.Format("{0} {1}", alue, 1000));
            //Console.WriteLine(string.Format("{0}", alue));
            //Console.WriteLine(string.Format("{0:0}", alue));
            //Console.WriteLine(string.Format("{0:0.0}", alue));
            //Console.WriteLine(string.Format("{0:0.#}", alue));
            //Console.WriteLine(string.Format("{0:0.00}", alue));

            //double money = 10D / 3D;
            //Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}", money));
            //Console.WriteLine(money.ToString("C"));
            //Console.WriteLine(money.ToString("C0"));
            //Console.WriteLine(money.ToString("C1"));
            //Console.WriteLine(money.ToString("C2"));

            //Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            //Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            //Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            //var nepaliCulture = new CultureInfo("ne-NP");
            //nepaliCulture.NumberFormat.CurrencySymbol = "Rs"; // Set the currency symbol to Nepali Rupee

            //Console.WriteLine(money.ToString("C", nepaliCulture));

            //using (HttpClient client = new HttpClient())
            //{
            //    // Example API URL - Replace with actual URL and parameters
            //    string apiUrl = "https://nepali-date-api-endpoint.com/convert?gregorianDate=2024-12-31";

            //    // Set your API key if necessary
            //    client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "your-api-key");

            //    HttpResponseMessage response = await client.GetAsync(apiUrl);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        string nepaliDate = await response.Content.ReadAsStringAsync();
            //        Console.WriteLine("Nepali Date: " + nepaliDate);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error fetching Nepali date");
            //    }
            //}

            // Task

            //Console.WriteLine("Enter the money you had: ");
            //double balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(balance);
            //Console.WriteLine(balance.ToString("C"));

            //if (balance > 0)
            //{
            //    Console.WriteLine("Great");
            //}
            //else
            //{
            //    Console.WriteLine("Interesting");
            //}
            //Console.WriteLine(balance > 0 ? "Great" : "Interesting");

            // TryParse
            //bool success = true;
            //while (success)
            //{
            //    Console.WriteLine("Enter a no: ");
            //    string numInp = Console.ReadLine(); //10h

            //    if (int.TryParse(numInp, out int num))
            //    {
            //        success = false;
            //        Console.WriteLine(num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed");
            //    }

            //}

            //Console.Write("Enter age: ");

            //if (int.TryParse(Console.ReadLine(), out int age))
            //{
            //    if (age >= 0 && age <= 125)
            //    {
            //        Console.WriteLine("Valid");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid range");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorSize = 100;
            Console.CursorVisible = false;
            //Console.Clear();
            Console.WriteLine("Hello");

        }
    }
}
