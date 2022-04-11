using System;
using System.Globalization;
namespace _1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, mediaPonderada;
            int pA, pB, pC;

            pA = 2;
            pB = 3;
            pC = 5;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = ((A * pA) + (B * pB) + (C * pC)) / (pA + pB + pC);

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
