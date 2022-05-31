using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [,] Mat = new int [N, N];

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    Mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    soma += Mat [i, j];
                }

                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
