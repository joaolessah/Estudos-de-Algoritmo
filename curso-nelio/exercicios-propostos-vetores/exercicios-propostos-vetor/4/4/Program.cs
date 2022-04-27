using System;
using System.Globalization;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N; 
            N = int.Parse(Console.ReadLine());

            double [] valores = new double[N];

            string [] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < s.Length; i++)
            {
                valores[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double soma = 0;


            //for (int i=0; i<N; i++) é a mesma coisa do foreac
            //mas como os dados dos valores são double tem que ser assim

            foreach (double i in valores)
            {
                soma += i;
            }
            double media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            foreach (double i in valores)
            {
                if (i < media)
                {
                    Console.WriteLine(i.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
