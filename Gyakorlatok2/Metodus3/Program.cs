using System;

namespace Metodus3
{
    internal class Program
    {

        static void ErtekAtadas(int szam)
        {
            szam = 999;
            Console.WriteLine($"Belső: {szam}");
        }
        static void RefAtadas(ref int szam)
        {
            szam = 888;
            Console.WriteLine($"Belső ref: {szam}");
        }
        static void Main(string[] args)
        {
            int ertek = 123;

            Console.WriteLine("=== Érték Átadás ===");
            Console.WriteLine($"Külső elötte: {ertek}");
            ErtekAtadas(ertek);
            Console.WriteLine($"Külső utána: {ertek}"); // 123 marad!

            Console.WriteLine("\n === Referencia Átadás ===");
            Console.WriteLine($"Külső elötte: {ertek}");
            RefAtadas(ref ertek);
            Console.WriteLine($"Külső utána: {ertek}"); // 888 lesz!
            Console.WriteLine();
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }


