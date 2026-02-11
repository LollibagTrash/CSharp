using System;
using Exception;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter a number: ");

            var num = int.Parse(Console.ReadLine()); // veszélyes kód - exception kezelés

            Console.WriteLine($"The square of {num} is {num * num}");*/

            try
            {
                Console.WriteLine("Enter a number: ");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine($"The square of {num} is {num * num}");
            }

            catch 
            { 
                Console.WriteLine("Error occured.");
            }
            finally
            {
                Console.WriteLine("Re-try with a different number.");
            }
            Console.WriteLine();
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }
    }
}
