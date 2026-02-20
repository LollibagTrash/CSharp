using System;

namespace NegyzetKocka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konzol kimenete: \n1. Négyzet \n2.Kocka \n3.Kilépés");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Válassz menüpontot: ");
            string inputText;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add meg a négyzet élhosszát: ");
                    double elhossz = double.Parse(Console.ReadLine());
                    Console.WriteLine("A négyzet területe: " + (elhossz * elhossz));
                    break;
                case 2:
                    Console.WriteLine("Add meg a kocka élhosszát: ");
                    double elhossz2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A négyzet területe: " + (elhossz2 * elhossz2 * elhossz2));
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Értelmezhetetlen");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();
        }
    }
}
