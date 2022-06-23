using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // UPCASTING

            // Text text = new Text();
            //
            // // Upcasting
            // // Implicitly convert an object reference (text) to a space class reference (shape)
            // Shape shape = text;
            //
            // // Points to the same object in memory so it is updated
            // text.Width = 200;
            // shape.Width = 100;
            //
            // Console.WriteLine(text.Width);

            // StreamReader reader = new StreamReader(new MemoryStream());

            // // Can store any type w/o conversion
            // var list = new ArrayList();
            // list.Add(1);
            // list.Add("Frank");
            // list.Add(new Text());
            //
            // // Restricted list by one type
            // var anotherList = new List<Shape>();

            // DOWNCASTING

            Shape shape = new Text();
            Text text = (Text)shape;
            
        }
    }
}
