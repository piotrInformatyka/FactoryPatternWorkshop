using System;
using System.Collections.Generic;
using System.Text;

namespace workshop
{
    class CreationMethod //metoda wytwórcza
    {
        public enum CoordinateSystem
        {
            Cartesian,
            Polar
        }
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
            protected Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }

            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }
}
