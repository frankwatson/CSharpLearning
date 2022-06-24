using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can't instantiate shape because its abstract
            //// var shape = new Shape();

            var circle = new Circle();
            circle.Draw();
            
            var rectangle= new Rectangle();
            rectangle.Draw();
        }
    }
}
