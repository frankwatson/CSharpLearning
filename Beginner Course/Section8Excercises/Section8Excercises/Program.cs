using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConsecutiveNumbers();
            // DuplicateCheck();
            // TimeValdation();
            PascalCaseify();
        }

        static void ConsecutiveNumbers()
        {
            bool a = true;
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            var nums = input.Split('-');
            var firstValue = Convert.ToInt32(nums[0]);

            for (int i = 0; i < nums.Length; i++)
            {
                if (Convert.ToInt32(nums[i]) - i != firstValue && Convert.ToInt32(nums[i]) + i != firstValue)
                {
                    a = false;
                    break;
                }
            }

            if (a)
            {
                Console.WriteLine("Consecutive.");
            }
            else
            {
                Console.WriteLine("Not consecutive.");
            }
        }

        static void DuplicateCheck()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            if (input.Length == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            var nums = input.Split('-');
            var distinctCount = nums.Distinct().Count();

            if (distinctCount != nums.Length)
            {
                Console.WriteLine("Duplicates.");
            }
            else
            {
                Console.WriteLine("No duplicates.");
            }
        }

        static void TimeValdation()
        {
            Console.WriteLine("Please enter a time in the 24 hour format (Ex. 19:00).");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No time was entered.");
                return;
            }

            var hour = Convert.ToInt32(input.Split(':')[0]);
            var minute = Convert.ToInt32(input.Split(':')[1]);

            if (hour >= 0 && hour <= 24 && minute >= 0 && minute <= 59)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time.");
            }
        }

        static void PascalCaseify()
        {
            Console.WriteLine("Enter a few words separated by a space.");
            var input = Console.ReadLine();
            var words = input.Split(' ');
            var pascalCase = new List<string>();

            foreach (var word in words)
            {
                pascalCase.Add(word[0].ToString().ToUpper() + word.Remove(0, 1).ToLower());
            }

            Console.WriteLine(string.Join("", pascalCase.ToArray()));
        }
    }
}
