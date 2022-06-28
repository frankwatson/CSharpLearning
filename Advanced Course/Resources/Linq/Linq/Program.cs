using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /*// LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title);

            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);*/

            //// With .single there must always be only a single element
            //// Use .SingleOrDefault if you are unsure; will return null
            var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            var book2 = books.First(b => b.Title == "C# Advanced Topics");
            var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var sum = books.Sum(b => b.Price);

            Console.WriteLine(sum);
            
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));
        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }

    
    }
}
