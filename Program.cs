using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().Replace("r", "l").Replace("R", "L");
            Console.WriteLine($"Como o cebolinha falaria: {frase}");
            Console.ReadKey();

        }
    }
}
