using System;

namespace _1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            string [] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
                // Aqui não basta verificar se só um é multiplo, é um ou o outro ser multiplo
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
