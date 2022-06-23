using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Start to begin the timer");
            var input = Console.ReadLine();
            var stopWatch = new StopWatch();

            while (!string.IsNullOrEmpty(input))
            {
                if (input.ToLower() == "start")
                {
                    stopWatch.Start();
                    Console.WriteLine("Type Stop to end the timer");
                    input = Console.ReadLine();
                }
                else if (input.ToLower() == "stop")
                {
                    var timeDiff = stopWatch.Stop();
                    Console.WriteLine(String.Format(@"Days: {0}   " +
                                                    "Hours: {1}   " +
                                                    "Minutes: {2}   " +
                                                    "Seconds: {3}   " +
                                                    "Milliseconds: {4}   ", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds, timeDiff.Milliseconds));
                    Console.WriteLine("Type Start to begin the timer");
                    input = Console.ReadLine();
                }
                else
                {
                    throw new Exception("Input not recognized");
                }
            }
        }
    }
}
