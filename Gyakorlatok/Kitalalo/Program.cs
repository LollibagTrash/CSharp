using System;

namespace Kitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int tipp = 0;
            bool eltalaltuk = false;
            string inputText = "";
            int veletlenSzam = r.Next(1, 100);

            
            do
            {
                
                Console.WriteLine("Kérek tippeket: ");
                inputText = Console.ReadLine();
                tipp = int.Parse(inputText);
                if (tipp < veletlenSzam)
                {
                    Console.WriteLine("A szám nagyobb mint a tipp volt!");
                }
                else if (tipp > veletlenSzam)
                {
                    Console.WriteLine("A szám kisebb mint a tipp volt!");
                }
                else
                {
                    Console.WriteLine("Eltaláltad!");
                    eltalaltuk = true;

                }
            }
            while (!eltalaltuk);
            

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();
        }
      
    }
    
}
