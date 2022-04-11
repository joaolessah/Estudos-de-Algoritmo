using System;
using System.Globalization;
namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double A, B, p1, p2, mediaPonderada;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1 = 3.5;
            p2 = 7.5;

            mediaPonderada = ((A*p1) + (B*p2))/ (p1 + p2);

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
