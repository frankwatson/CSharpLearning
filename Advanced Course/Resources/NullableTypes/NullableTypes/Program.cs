
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            // If date has a value you assign to date2, otherwise use today's date
            DateTime date2 = date ?? DateTime.Today;

            // Longer way of doing the above
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;



            Console.WriteLine(date2);



        }
    }
}
