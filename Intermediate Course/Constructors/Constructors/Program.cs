using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var customer = new Customer(1, "Frank");
            
            
            // Can also do this way without constructor overload
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Frank";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
