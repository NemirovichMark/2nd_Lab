using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    internal class Point
    {
        private double coordX;
        public double CoordX { get { return coordX; } set { coordX = value; } }

        private double coordY;
        public double CoordY { get { return coordY; } set { coordY = value; } }

        /// <summary>
        /// Creates a point in space with zero coordinates
        /// </summary>
        public Point()
        {
            this.coordX = 0;
            this.coordY = 0;
        }

        /// <summary>
        /// Creates a point in the space with user data
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.coordX = x;
            this.coordY = y;
        }

        /// <summary>
        /// Calculates the distance from the first point to the second
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Distance between two points without calculating the square root</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Pow(p2.CoordX - p1.CoordX, 2) + Math.Pow(p2.CoordY - p1.CoordY, 2);
        }

        public static Point InitializePoint()
        {
            Console.Write("Enter the coordinate x: ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.Write("Enter the coordinate y: ");
            double.TryParse(Console.ReadLine(), out double y);

            return new Point(x, y);
        }

        override public string ToString()
        {
            return $"({CoordX}; {CoordY})";
        }
    }
}