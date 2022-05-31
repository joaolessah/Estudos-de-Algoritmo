using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] z = Console.ReadLine().Split(' ');
            int M = int.Parse(z[0]);
            int N = int.Parse(z[1]);

            int[,] a = new int[M, N];
            int[,] b = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    a[i, j] = int.Parse(s[j]);

                }

            }

            for (int i = 0; i < M; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    b[i, j] = int.Parse(x[j]);
                }
            }



            int[,] C = new int[M, N];
            

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C [i, j] = a[i, j] + b[i,j];
                }

            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write (C[i, j] + " ");
                }
                Console.WriteLine ();
            }
        }
    }
}
