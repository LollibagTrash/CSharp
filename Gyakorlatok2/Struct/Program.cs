using System;
using System.Drawing;

namespace Struct
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Tavolsag(Point masik)
        {
            double dx = X - masik.X;
            double dy = Y - masik.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public void Kiiras()
        {
            Console.WriteLine($"Pont: ({X:F2}, {Y:F2})");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Point p1 = new Point(0, 0);
                Point p2 = new Point(3, 4);
                p1.Kiiras();
                p2.Kiiras();
                Console.WriteLine($"Távolság: {p1.Tavolsag(p2):F2}");

                Point p3 = p1;
                p3.X = 10;
                p1.Kiiras();
                p3.Kiiras();
                Console.WriteLine();
                Console.WriteLine("Enterrel kilépni!");
                Console.ReadLine();
            }
        }
    }
}
