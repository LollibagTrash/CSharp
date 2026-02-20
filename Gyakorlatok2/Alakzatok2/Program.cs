using System;

namespace Alakzatok2
{
    public class Circle
    {
        private double r = 0;

        public Circle(double r)
        {
            this.r = r;
        }

        public double Terulet()
        {
            return Math.PI * r * r;
        }

        public double Kerulet()
        {
            return Math.PI * 2 * r;
        }
        public void Kiir()
        {
            Console.WriteLine($"Kör, sugar: {this.r}");
        }
        public override string ToString()
        {
            return $"Kör objectum: sugara: {this.r} cm";
        }
    }
    public class Rectangle
    {
        private double a = 0;
        private double b = 0;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Kerulet()
        {
            return 2 * (a + b);
        }
        public double Terulet()
        {
            return a * b;
        }
        public void Kiir()
        {
            Console.WriteLine($"Téglalap, a: {this.a}, b: {this.b}");
        }
        public override string ToString()
        {
            return $"Téglalap objectum: a oldala: {this.a} cm, b oldala {this.b} cm";
        }
    }
    public class Square
    {
        private double a = 0;
        public Square(double a)
        {
            this.a = a;
        }
        public double Terulet()
        {
            return a * a;
        }
        public double Kerulet()
        {
            return a * 4;
        }
        public void Kiir()
        {
            Console.WriteLine($"Négyzet, oldal: {this.a}");
        }
        public override string ToString()
        {
            return $"Négyzet objectum: a oldala: {this.a} cm";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle k = new Circle(5);
            k.Kiir();
            Console.Write("A kőr területe: " + k.Terulet());
            Console.WriteLine();
            Console.WriteLine("A kőr kerülete: " + k.Kerulet());

            Console.WriteLine();

            Rectangle t = new Rectangle(6, 7);
            t.Kiir();
            Console.Write("A téglalap területe: " + t.Terulet());
            Console.WriteLine();
            Console.WriteLine("A téglalap kerülete: " + t.Kerulet());

            Console.WriteLine();

            Square n = new Square(8);
            n.Kiir();
            Console.Write("A négyzet területe: " + n.Terulet());
            Console.WriteLine();
            Console.WriteLine("A négyzet kerülete: " + n.Kerulet());

            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();
        }
    }
}
