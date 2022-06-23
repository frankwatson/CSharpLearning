using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FacebookLikes();
            // NameReverse();
            // UniqueNumbers();
            // NumQuit();
            CommaNumberList();

            void FacebookLikes()
            {
                Console.WriteLine("Please continue to enter names: ");
                var input = Console.ReadLine();

                var list = new List<string>();
                while (input != "")
                {
                    list.Add(input);
                    input = Console.ReadLine();
                }

                Console.WriteLine("Count: " + list.Count);

                if (list.Count == 0)
                {
                    Console.WriteLine();
                }
                else if (list.Count == 1)
                {
                    Console.WriteLine(list[0]);
                }
                else if (list.Count == 2)
                {
                    Console.WriteLine(list[0] + ", " + list[1]);
                }
                else
                {
                    Console.WriteLine(list[0] + ", " + list[1] + " and " + (list.Count() - 2) + " others like your post.");
                }
            }

            void NameReverse()
            {
                Console.WriteLine("Please enter a name to be reversed: ");
                var nameInput = Console.ReadLine();
                var reversedName = nameInput.ToArray();

                Array.Reverse(reversedName);
                Console.WriteLine(reversedName);
            }

            void UniqueNumbers()
            {
                string numInput;
                var errorStatus = false;
                var uniqueNumList = new List<long>();

                Console.WriteLine("Please enter 5 unique numbers: ");

                for (int i = 0; i < 5; i++)
                {
                    numInput = Console.ReadLine();
                    if (!uniqueNumList.Contains(Convert.ToInt64(numInput)))
                    {
                        uniqueNumList.Add(Convert.ToInt64(numInput));
                    }
                    else
                    {
                        errorStatus = true;
                        break;
                    }
                }
                
                if (errorStatus == true)
                {
                    Console.WriteLine("Error, the number has already been entered.");
                }
                else
                {
                    uniqueNumList.Sort();
                    foreach (var num in uniqueNumList)
                    {
                        Console.WriteLine(num);
                    }

                    Console.WriteLine("Sucess.");
                }
            }

            void NumQuit()
            {
                var numList = new List<long>();
                var numQuitStatus = true;

                while (numQuitStatus == true)
                {
                    Console.WriteLine("Enter a number: ");
                    var numQuitInput = Console.ReadLine();

                    if (numQuitInput == "Quit")
                    {
                        Console.WriteLine("Unique numbers entered:");
                        IEnumerable<long> distinctNums = numList.Distinct();
                        foreach (long num in distinctNums)
                        {
                            Console.WriteLine(num);
                        }
                        numQuitStatus = false;
                    }
                    else
                    {
                        numList.Add(Convert.ToInt64(numQuitInput));
                    }
                }
            }

            void CommaNumberList()
            {
                Console.WriteLine("Please enter a comma seperated list of numbers: ");
                var input = Console.ReadLine();

                var inputCS = input.Split(',').ToList();

                if (inputCS.Count < 5)
                {
                    Console.WriteLine("Invalid List.");
                }
                else
                {
                    Console.WriteLine("Sorted List: ");
                    inputCS.Sort();
                    Console.WriteLine(String.Format("{0}, {1}, {2}", inputCS[0], inputCS[1], inputCS[2]));
                }
            }
        }
    }
}
