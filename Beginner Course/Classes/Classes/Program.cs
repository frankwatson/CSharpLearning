using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Math;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            System.Console.WriteLine(result);
        }
    }
}
