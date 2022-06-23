using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                // Do something
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");

            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // 
            }

            fileInfo.OpenRead();
        }
    }
}
