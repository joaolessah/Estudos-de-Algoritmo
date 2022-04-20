using System;
using System.Globalization;
namespace _1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double divisao;
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string [ ] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                

                if ( y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = (double)x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
