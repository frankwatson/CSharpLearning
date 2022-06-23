using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder("Hello World");

            // You can chain methods together since they are not void output
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }
}
