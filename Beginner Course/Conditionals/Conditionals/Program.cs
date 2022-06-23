using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If else statements
            /*            int hour = 10;

                        if (hour > 0 && hour < 12)
                        {
                            Console.WriteLine("It's morning.");
                        }
                        else if (hour >= 12 && hour < 18)
                        {
                            Console.WriteLine("It's afternoon.");
                        }
                        else
                        {
                            Console.WriteLine("It's evening.");
                        }*/

            /*            bool isGoldCustomer = true;

            *//*            float price;
                        if (isGoldCustomer)
                            price = 19.95f;
                        else
                            price = 19.95f;*//*

                        float price = (isGoldCustomer) ? 19.95f : 19.95f;
                        Console.WriteLine(price);*/

            // Season enum
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to the beach.");
                    break;
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("It is Spring or Winter.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}
