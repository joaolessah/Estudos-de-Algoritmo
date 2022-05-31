using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Lendo as dimensões da matriz que é M linhas e N colunas
            string [ ] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            // Declarando e instanciando minha matriz 

            int [,] Mat = new int[M, N];

            // Atribuindo valores aos campos das matrizes

            // Enquanto I < M (linhas) é para executar
            for (int i = 0; i < M; i++)
            {
                // Leitura dos dados
                string [] x = Console.ReadLine().Split(' ');

                //Aqui J vai ter que ser menor que N para executar as colunas da linha
                for (int j = 0; j < N; j++)
                {
                    // Aqui o item que esta na Mat posição i e j recebe o valor x digitado na posição J

                    // por exemplo se o j vale 0 e o i vale 0, o item vai estar na posição 0,0 e o x que ele vai receber digitado está no 0 o vetor da string
                    Mat [i, j] = int.Parse(x[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS: ");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Mat [i, j] < 0)
                    {
                        Console.WriteLine (Mat [i, j]);
                    }
                }
            }
         }
    }
}
