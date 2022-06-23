using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            Directory.Delete(@"c:\temp\folder1");

            var path = @"C:\Users\Frank\Documents\Git\C#\Beginner Course";

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

/*            foreach (var file in files)
            {
                Console.WriteLine(file);
            }*/

            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
