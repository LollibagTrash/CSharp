using System;

namespace Dog
{
    public class Dog
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Dog(string color, string name, string breed, double height, double weight)
        {
            this.Color = color;
            this.Name = name;
            this.Breed = breed;
            this.Height = height;
            this.Weight = weight;
        }

        public void WagTail()
        {
            Console.WriteLine($"{Name} csóválja a farkát.");
        }

        public void LieDown()
        {
            Console.WriteLine($"{Name} lefekszik.");
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} ugat: Vau-vau!");
        }

        public void Shake()
        {
            Console.WriteLine($"{Name} rázza a testét.");
        }

        public void Come()
        {
            Console.WriteLine($"{Name} ide jön.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eszik.");
        }

        public void Drink()
        {
            Console.WriteLine($"{Name} iszik.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} lepihen.");
        }



        public override string ToString()
        {
            return $"Dog: {Name} ({Breed}), Color: {Color}, Height: {Height} cm, {Weight} kg";
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Dog bobby = new Dog("Yellow Brown", "Bobby", "Labrador", 43.18, 10.89);
                Dog rex = new Dog("Black", "Rex", "German Shephard", 50.0, 60.0);
                Console.WriteLine(bobby);
                bobby.WagTail();
                bobby.LieDown();
                bobby.Bark();
                bobby.Shake();
                bobby.Come();
                bobby.Eat();
                bobby.Drink();
                bobby.Sleep();

                Console.WriteLine(rex);

                rex.WagTail();
                rex.LieDown();
                rex.Bark();
                rex.Shake();
                rex.Come();
                rex.Eat();
                rex.Drink();
                rex.Sleep();

                Console.WriteLine();
                Console.WriteLine("Enterre kilépés!");
                Console.ReadLine();
            }
        }
    }
}
