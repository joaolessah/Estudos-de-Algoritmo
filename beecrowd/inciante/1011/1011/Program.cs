using System;
using System.Globalization;
namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R, pi, volumeEsfera;
            pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volumeEsfera = (4.0 / 3) * pi * Math.Pow(R, 3);
            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
