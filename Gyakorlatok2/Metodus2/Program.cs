using System;

namespace Metodus2
{
    internal class Program
    {
        static void Rendeles(string termeknev, int mennyiseg = 1, decimal kedvezmeny = 0m)
        {
            decimal osszeg = mennyiseg * 1000m * (1m - kedvezmeny);
            Console.WriteLine($"{mennyiseg} db {termeknev}: {osszeg:F0} Ft");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== Optimal argumentek ===");
            Rendeles("Egér");               // 1 db, 0% kedvenmény
            Rendeles("Billentyűzet", 2);    // 2 db, 0% kedvezmény
            Rendeles(termeknev: "Monitor", kedvezmeny: 0.1m);

            Console.WriteLine("\n === Named argumentek tetszőleges sorrendben ===");
            Rendeles(kedvezmeny: 0.2m, mennyiseg: 3, termeknev: "Laptop");
            Console.WriteLine();
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }
    }
}
