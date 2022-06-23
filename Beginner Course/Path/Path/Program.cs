using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Frank\Documents\Git\C#\Beginner Course\HelloWorld\HelloWorld.sln";

            // One way of getting extension
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // Best way to get extension
            Console.WriteLine("Extension: " + System.IO.Path.GetExtension(path));
            Console.WriteLine("File Name: " + System.IO.Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + System.IO.Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + System.IO.Path.GetDirectoryName(path));
        }
    }
}
