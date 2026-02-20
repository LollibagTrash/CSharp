using System;

namespace BMIKalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centi = 0;
            double meter = 0;
            double testSuly = 0;
            double BMI = 0;
            string inputText = "";
            Console.WriteLine("~ BMI kalkulátor ~");
            Console.WriteLine("Add meg a magasságot (cm): ");
            inputText = Console.ReadLine();
            bool isValidFormat = double.TryParse(inputText, out centi);
            while (!isValidFormat)
            {
                Console.WriteLine("Add meg a magasságot *jó formátumban* ---> (cm) <----: ");
                inputText = Console.ReadLine();
                isValidFormat = double.TryParse(inputText, out centi);
            }
            meter = centi / 100;
            Console.WriteLine("Add meg a súlyod (kg): ");
            inputText = Console.ReadLine();
            bool isValidFormatt = double.TryParse(inputText, out testSuly);
            while (!isValidFormatt)
            {
                Console.WriteLine("Add meg a súlyod *jó formátumbab* ---> (kg) <----: ");
                inputText = Console.ReadLine();
                isValidFormatt = double.TryParse(inputText, out testSuly);
            }
            BMI = testSuly / (meter * meter);

            if (BMI < 18.5)
            {
                Console.WriteLine("Sovány vagy!");
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                Console.WriteLine("Normál testsúly!");
            }
            else if (BMI > 24.9 && BMI < 29.9)
            {
                Console.WriteLine("Túlsúly!");
            }
            else
            {
                Console.WriteLine("Elhíztál!");
            }
            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();

        }
    }
}
