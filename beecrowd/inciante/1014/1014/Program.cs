using System;
using System.Globalization;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Y, Consumo;


            int X = int.Parse(Console.ReadLine());
            Y = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Consumo = X / Y;

            Console.WriteLine(Consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            Console.ReadLine();

        }
    }
}
