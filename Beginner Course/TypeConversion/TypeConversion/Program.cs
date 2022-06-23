using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This works becuse there is no data loss converitng'
            /*            byte b = 1;
                        int i = b;
                        Console.WriteLine(i);*/

            // Can't convert source type to byte
            /*            int i = 1;
                        byte b = i;*/

            // Can solve by casting
            /*            int i = 1;
                        byte b = (byte)i;
                        Console.WriteLine(b);*/

            // Non-compatitble types
            /*            var number = "1234";
                        int i = Convert.ToInt32(number);
                        Console.WriteLine(i);*/

            // Try catch example
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
