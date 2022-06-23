using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loops
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // For each loops
            var name = "John Smith";

            //// For loop
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //// For each loop
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            // Arrays with for each
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Same code as for loop
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                    i++;
                }
            }

            // Another while loop example
            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine(input);
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
