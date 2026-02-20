using System;

namespace Metodus4
{
    internal class Program
    {

        static bool Szamfelbontas(out int harmasok, out int parosak)
        {
            harmasok = 0;
            parosak = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0) harmasok++;
                if (i % 2 == 0) parosak++;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("=== OUT paraméter ===");
            if (Szamfelbontas(out int e, out int p))
            {
                Console.WriteLine($"0-100: {e} db 3-zal osztható, {p} db páros");
            }

        }
    }
}
