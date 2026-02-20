using System;

namespace TeruletKerulet2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, K, T, S;
            string inputText;
            Console.WriteLine("Háromszög Kerület/Terület számítás");

            Console.WriteLine("Add meg a háromszög első oldalhosszát");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out a);

            Console.WriteLine("Add meg a háromszög második oldalhosszát");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out b);

            Console.WriteLine("Add meg a háromszög harmadik oldalhosszát");
            inputText = Console.ReadLine();
            double.TryParse(inputText, out c);

            K = a + b + c;

            S = K / 2;

            T = Math.Sqrt(S * (S - a) * (S - b) * (S - c));

            Console.WriteLine($"Kerület: {K}");
            Console.WriteLine($"Terület: {T}");
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();

        }

    }
}