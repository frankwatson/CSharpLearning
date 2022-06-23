using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stores type obj
            var list = new ArrayList();
            // Boxing happens
            list.Add(1);
            // Boxing doesn't happen
            list.Add("Frank");
            // Boxing happens
            list.Add(DateTime.Today);

            var number = (int)list[1];

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add();
        }
    }
}
