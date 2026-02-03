using System;

namespace AverageOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40 };
            //double avg = numbers.Average();

            int[] numbers;
            int tombHossz;
            string inputText;
            double avg;

            Console.WriteLine("Adjunk be egész számokat");
            Console.WriteLine("Hány számot olvassunk be?");
            inputText = Console.ReadLine();
            tombHossz = Convert.ToInt32(inputText);

            numbers = new int[tombHossz];

            for (int i = 0; i < tombHossz; i++)
            {
                Console.WriteLine($"Kérjük a(z) {i+1}. számot:");
                inputText = Console.ReadLine();
                numbers[i] = Convert.ToInt32(inputText);
            }

            avg = numbers.Average();
            Console.WriteLine($"Average: {avg}");
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();
        }
    }
}
