using System;
using System.Globalization;
namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double [,] mat = new double[N, N];

            //Leitura de dados da matriz

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N ; j++)
                {
                    mat[i,j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            // Soma de todos elementos positivos da matriz

            double soma = 0;

            for (int i = 0; i < N ; i++)
            {
                for (int j = 0; j < N ; j++)
                {
                    if (mat[i,j] > 0)
                    {
                        soma += mat[i,j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));


            // Leitura do índice de uma linha da matriz e imprimir os elementos da linha

            int leituraLinha = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N ; i++)
            {
                Console.Write(mat[leituraLinha,i].ToString("F1", CultureInfo.InvariantCulture)+ " ");
            }
            Console.WriteLine();

            // Leitura do índice de uma coluna da matriz e imprimir elementos  da coluna

            int leituraColuna = int.Parse (Console.ReadLine());
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, leituraColuna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // Imprimir os elementos da diagonal principal

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();


            // Alterar matriz elevando ao quadrado todos os números negativos da mesma e imprimir a matriz alterada

            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat [i,j] < 0)
                    {
                        mat[i,j] = Math.Pow(mat[i,j], 2);
                       //mat [i,j] = mat[i,j]*mat[i,j];
                        
                    }

                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
                
            }

        }
    }
}
