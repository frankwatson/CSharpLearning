using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reversed Name
            Console.WriteLine("What's you name?");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);

            // Get Unique Nums
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit to exit)");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
            {
                Console.WriteLine(number);
            }
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - 1] = name[i - 1];
            }

            return new string(array);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniqueNums = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniqueNums.Contains(number))
                {
                    uniqueNums.Add(number);
                }
            }

            return uniqueNums;
        }
    }
}
