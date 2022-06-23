using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Excercises
{
    public class Validate
    {
        public string NumValidator(int valNum)
        {
            if (valNum >= 1 && valNum <= 10)
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }
    public class Number
    {
        public double MaxFinder(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
    public class Image
    {
        public string Orientation(long width, long height)
        {
            if (width > height)
            {
                return "Landscape";
            }
            else
            {
                return "Portrait";
            }
        }
    }
    public class SpeedCamera
    {
        public string Demerit(long carSpeed, long speedLimit)
        {
            int points;

            if (carSpeed > speedLimit)
            {
                points = Convert.ToUInt16((carSpeed - speedLimit) / 5);
                if (points > 12)
                {
                    return "License suspended.";
                }
                else
                {
                    return String.Format("The driver has recieved {0} demerit points.", points);
                }
            }
            else if (carSpeed <= speedLimit)
            {
                return "Ok";
            }
            else
            {
                return "Unable to calculate demerit points";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Validate if user input is between 1 and 10
            Console.WriteLine("Please enter a number between 1 and 10");
            var usrInput1 = Convert.ToInt16(Console.ReadLine());

            Validate usrValResponse = new Validate();
            var a = usrValResponse.NumValidator(usrInput1);

            Console.WriteLine(a);

            // Repeat in conosle the highest number between two numbers
            Console.WriteLine("Please enter number one");
            var numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter number two");
            var numB = Convert.ToDouble(Console.ReadLine());

            Number usrNums = new Number();
            var b = usrNums.MaxFinder(numA, numB);

            Console.WriteLine(b + " is the highest number.");

            // Determine from width & height if image is landscape or portrait
            Console.WriteLine("Please enter width");
            var usrWidth = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter height");
            var usrHeight = Convert.ToInt64(Console.ReadLine());

            Image img = new Image();
            var c = img.Orientation(usrWidth, usrHeight);
            Console.WriteLine(c);

            // SpeedCamera
            //// Every 5 miles over speedlimit, recieve 1 demerit point
            //// If over 12 demerit points, state license suspended
            Console.WriteLine("Please enter the speed limit.");
            var usrSpeedLimit = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter the car speed.");
            var usrCarSpeed = Convert.ToInt64(Console.ReadLine());

            var speedCamera = new SpeedCamera();
            var d = speedCamera.Demerit(usrCarSpeed, usrSpeedLimit);
            Console.WriteLine(d);
        }
    }
}
