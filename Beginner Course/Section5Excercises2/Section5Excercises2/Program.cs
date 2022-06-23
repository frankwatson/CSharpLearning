using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Excercises2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine how many numbers between 1 & 100 are divisible by 3
            /*            var count = 0;

                        for (int i = 0; i <= 100; i++)
                        {
                            if (i % 3 == 0)
                            {
                                count += 1;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        Console.WriteLine(count);*/

            // Ask user to keep entering numbers
            /*            string input;
                        long sum = 0;

                        Console.WriteLine("Please enter a number.");
                        input = Console.ReadLine();

                        while (input != "ok")
                        {
                            Console.WriteLine("Please enter a number.");
                            input = Console.ReadLine();
                            sum += Convert.ToInt64(input);
                        }*/

            // Calculate factorial from user input
            /*            Console.WriteLine("Please input a number to be factored");
                        var input = Console.ReadLine();

                        long calculation = Convert.ToInt64(input);

                        for (var i = Convert.ToInt64(input); i > 1; i--)
                        {
                            calculation *= (i - 1);
                        }

                        Console.WriteLine(String.Format("{0}! = {1}", input, calculation));*/

            // Guess number between 1 and 10
            /*            var randomNumGen = new Random();
                        var randomNum = randomNumGen.Next(1, 10);

                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine("Guess a number between 0 and 10.");
                            var input = Convert.ToInt16(Console.ReadLine());

                            if (input == randomNum)
                            {
                                Console.WriteLine("You won!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have lost.");
                            }
                        }

                        Console.WriteLine("Game over.");*/

            // Find max number
            int valueTemp;
            Console.Write("Enter a series of numbers separated by comma: ");
            var userInput = Console.ReadLine();

            string[] array = userInput.Split(',');
            List<int> intList = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out valueTemp))
                {
                    intList.Add(valueTemp);
                }
            }
            Console.WriteLine("The largest number is {0}", intList.Max());
        }
    }
}
