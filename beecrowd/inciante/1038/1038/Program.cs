using System;
using System.Globalization;
namespace _1038
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int codigo, quantidade;
            double total;
            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    total = quantidade * 4.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    total = quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    total = quantidade * 5.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    total = quantidade * 2.00;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    total = quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }

        }
    }
}
