using System;
using System.Globalization;
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            double[] numeros =  new double[N];

            string [] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }


            int cont = 0;
            double soma = 0;

            for (int i =0; i < N; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    cont++;
                    soma += numeros[i];
                }
            }
            double media = soma / cont;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
