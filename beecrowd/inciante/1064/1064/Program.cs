using System;
using System.Globalization;
namespace _1064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, media, soma;
            int positivos;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            positivos = 0;
            soma = 0;

            if (n1 > 0)
            {
                positivos++;
                soma += n1;
            }
            if (n2 > 0)
            {
                positivos++;
                soma += n2;
            }
            if (n3 > 0)
            {
                positivos++;
                soma += n3;
            }
            if (n4 > 0)
            {
                positivos++;
                soma += n4;
            }
            if (n5 > 0)
            {
                positivos++;
                soma += n5;
            }
            if (n6 > 0)
            {
                positivos++;
                soma += n6;
            }

            media = soma / positivos;
            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
