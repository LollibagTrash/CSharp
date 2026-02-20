using System;
using System.Globalization;

namespace TombStatistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            int[] szamok = new int[5];
            int min = 0;
            int max = 0;
            double avg;
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"Kérem a {i + 1}. számot: ");
                inputText = Console.ReadLine();
                int.TryParse(inputText, out szamok[i]);
            }
            avg = szamok.Average();
            min = szamok.Min();
            max = szamok.Max();
            Console.WriteLine("Számok átlaga: " + avg);
            Console.WriteLine("Számok minimuma: " + min);
            Console.WriteLine("Számok maximuma: " + max);
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();

        }
    }
}
