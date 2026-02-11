namespace Metodus1
{
    internal class Program
    {
        static int Osszeadas(int a, int b)
        { 
            int eredmeny = a + b;
            return eredmeny;
        }

        static string Szoveghossza(string szoveg)
        { 
            return szoveg.Length.ToString();
        }

        static void Kiir() {
            Console.WriteLine("Ez egy void metódus!");
        }
        static double Szorzas(double c, double d)
        {
            double szorzoeredmeny = c * d;
            return szorzoeredmeny;
        }
        static void Main(string[] args
            
            )
        {
            Console.WriteLine(Osszeadas(7, 3));
            Console.WriteLine(Szoveghossza("Hello"));
            Kiir();
            Console.WriteLine(Szorzas(2.3, 4.5));
            Console.WriteLine();  
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }
    }
}
