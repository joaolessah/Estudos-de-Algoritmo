using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [,] Mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');

                for(int j = 0; j < s.Length; j++)
                {
                    Mat[i, j] = int.Parse(s[j]);
                }
            }

            int maior = 0;

            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (Mat[i , j]  > maior)
                    {
                        maior = Mat [i, j];
                    }
                   
                }
                Console.WriteLine(maior);

                maior = 0;
            }
        }
    }
}
