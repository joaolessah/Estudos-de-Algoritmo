using System;
using System.Globalization;
namespace _1051
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double aliquota;

            if (salario > 0 && salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            //


            else if (salario > 2000.00 && salario <= 3000.00)
            {
                aliquota = ((salario - 2000) * 8) / 100;
                Console.WriteLine("R$ " + aliquota.ToString("F2", CultureInfo.InvariantCulture));
            }

            // 


            else if (salario > 3000.00 && salario <= 4500.00)
            {
                aliquota = 80 + (((salario - 3000) * 18) / 100);
                Console.WriteLine("R$ " + aliquota.ToString("F2", CultureInfo.InvariantCulture));
            }

            else
            {
                aliquota = 80 + 270 + (((salario - 4500) * 28) / 100);
                Console.WriteLine("R$ " + aliquota.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
