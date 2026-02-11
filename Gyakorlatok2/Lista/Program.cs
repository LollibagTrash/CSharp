namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(10);
            lista.Add(20);
            lista.Add(30);
            lista.Add(40);
            lista.Add(50);

            int index = 1;
            Console.WriteLine("Elements in the list (with foreach):");
            foreach (int elem in lista)
            {
                Console.WriteLine($"A(z) {index}. elem a listában: " + elem);
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Elements in the list (with for):");
            for (int i = 0; i < lista.Count; i++) 
            { 
                Console.WriteLine($"A(z) {i+1}. elem a listában: " + lista.ElementAt(i));
            }


            Console.WriteLine();
            Console.WriteLine("Reverse elements in the list (with for):");
            for(int i = lista.Count-1; i >= 0; i--)
            {
                Console.WriteLine($"A(z) {i + 1}. elem a listában: " + lista.ElementAt(i));
            }
            Console.WriteLine($"Element 2 on the List?:" + lista.Contains(2));
            lista.Sort();
            lista.Reverse();
            index = 0;
            Console.WriteLine();
            foreach(int elem in lista)
            {
                Console.WriteLine($"A(z) {index+1}. elem a listában: " + elem);
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Enterrel kilépni!");
            Console.ReadLine();
        }
    }
}
