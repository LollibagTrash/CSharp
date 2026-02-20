using System;

namespace AtlagSzamitas2
{
    class Program
    {
        static void Main()
        {

            int a, b, c, sum;
            double avg;
            string inputText;

            Console.WriteLine("Add meg az első egész számot.");
            inputText = Console.ReadLine();
            int.TryParse(inputText, out a);

            Console.WriteLine("Add meg a második egész számot.");
            inputText = Console.ReadLine();
            int.TryParse(inputText, out b);

            Console.WriteLine("Add meg a harmadik egész számot.");
            inputText = Console.ReadLine();
            int.TryParse(inputText, out c);

            sum = a + b + c;

            avg = sum / 3;

            Console.Write($"A szám átlaga: {avg}");
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();

        }

    }
}
