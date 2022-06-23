using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("The index of 9 is: " + index);

            // Clear() - setting them to null
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effects of Reverse()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
