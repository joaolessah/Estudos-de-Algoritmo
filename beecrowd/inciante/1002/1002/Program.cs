using System;
using System.Globalization;
namespace _1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fórmula para calcular a área é area = n . raio²
            // Nesse caso N = 3.14159

            double raio, area, n;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n = 3.14159;

            area = n * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
