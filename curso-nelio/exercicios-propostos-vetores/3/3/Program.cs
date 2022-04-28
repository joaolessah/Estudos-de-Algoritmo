using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int [] A = new int[N];
            int [] B = new int[N];

            string[] x = Console.ReadLine().Split(' ');
            string[] y = Console.ReadLine().Split(' ');

            //Lendo vetores A e B
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(x[i]);
                B[i] = int.Parse(y[i]);
            }

            // Geração vetor C
            int [] C = new int[N];

            for (int i = 0; i < N; i++)
            {
                // C na posição i recebe a na posição i mais b na posição i
                C [i] += A[i] + B[i];
            }

            // Aqui estou varrendo o inteiro - elemento i- apelido - dentro do vetor C e imprimindo ele a cada iteração
            foreach (int i in C)
            {
                Console.Write(i + " ");
            }
            

        }
    }
}
