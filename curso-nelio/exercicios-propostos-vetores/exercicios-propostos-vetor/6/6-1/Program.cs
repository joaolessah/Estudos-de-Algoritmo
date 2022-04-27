using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int maisVelho = 0;
            string[] nome = new string[N];
            int[] idade = new int[N];
            string nomeVelho = " ";

            // Leitura de dados
            for (int i = 0; i < N; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                nome[i] = x[0];
                idade[i] = int.Parse(x[1]);
            }

            // Verificando quem é o mais velho
            for (int i = 0; i < N; i++)
            {
                if (idade[i] > maisVelho)
                {
                    maisVelho = idade[i];
                    nomeVelho = nome[i];
                }
            }
            Console.WriteLine(nomeVelho);
        }
    }
}
