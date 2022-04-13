using System;

namespace _1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            string [] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            while (n1 != 0 || n2 != 0)
            {
                if (n1 > 0 && n2 > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (n1 < 0 && n2 > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (n1 < 0 && n2 < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (n1 > 0 && n2 < 0)
                {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');
                n1 = int.Parse(vet[0]);
                n2 = int.Parse(vet[1]);

            }
        }
    }
}
