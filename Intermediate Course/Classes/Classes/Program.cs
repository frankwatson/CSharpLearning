using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // If declared as static, don't have to create new object
        /// Ex. var person = new Person();
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("John");
            person.Introduce("Frank");
        }
    }
}
