using System;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenNumbers = from num in numbers
            //                  // where num % 2 == 0
            //                  where num > 3 && num < 10
            //                  select num;

            List<int> resultNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    resultNumbers.Add(num);
                }
            }

            foreach (int num in resultNumbers)
            {
                Console.WriteLine(num);
            }

            //foreach (var num in evenNumbers) 
            //{
            //    Console.WriteLine(num);
            //}
            Console.WriteLine();
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }
    }
}
