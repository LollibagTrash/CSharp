using System;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Összeadás (+)\n2.Kivonás (-)\n3. Szorzás (*)\n4. Osztás (/)");
            //int choice = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            int a = 10, b = 5;
            switch (choice)
            {
                case "+":
                    Console.WriteLine($"Összeg: {a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Különbség: {a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Szorzat: {a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"Hányados: {a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("Helytelen!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();
        }
    }
}
