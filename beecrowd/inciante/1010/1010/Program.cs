using System;
using System.Globalization;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] vet1 = Console.ReadLine().Split(' ');
            string [] vet2 = Console.ReadLine().Split(' ');
            double valorPagar;

            int codP1 = int.Parse(vet1[0]);
            int codP2 = int.Parse(vet2[0]);
            int qtdP1 = int.Parse(vet1[1]);
            int qtdP2 = int.Parse(vet2[1]);
            double precoP1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            double precoP2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valorPagar = (qtdP1 * precoP1) + (qtdP2 * precoP2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
