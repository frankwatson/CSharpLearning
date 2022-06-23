using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        // Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            // Defensive Programming
            //// Prevent null from being entered
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }

    }
}