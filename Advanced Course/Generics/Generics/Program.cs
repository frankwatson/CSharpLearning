using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "11111", Title = "C# Advanced" };

            // var numbers = new List();
            // numbers.Add(10);
            //
            // var books = new BookList();
            // books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", book);
        }
    }

    internal class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
    }
}
