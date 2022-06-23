using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Removes whitespace at end of name
            var fullName = "Frank Watson ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            // Get first and last name
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            // Easier way
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Frank", "Cyrus"));
            fullName.Replace('F', 'f');

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "22";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
