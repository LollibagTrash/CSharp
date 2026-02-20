using System;

namespace Palindrome2
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = " ";
            string reverseText = " ";
            char[] reverse_array = null;



            Console.WriteLine("Palindrome szókereső");
            Console.WriteLine();
            Console.Write("Kérek egy szót: ");
            inputText = Console.ReadLine();

            reverse_array = inputText.ToCharArray();
            Array.Reverse(reverse_array);
            reverseText = new string(reverse_array);

            if (inputText.Equals(reverseText))
            {
                Console.WriteLine("A beírt szó palindrom!");
            }
            else
            {
                Console.WriteLine("A beírt szó nem palindrom!");
            }

            Console.WriteLine();
            Console.WriteLine("Enterre kilépés!");
            Console.ReadLine();

        }

    }
}
