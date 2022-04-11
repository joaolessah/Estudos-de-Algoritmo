using System;
using System.Globalization;

namespace _1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
    

            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total, comissao;


            comissao = vendasEfetuadas - (vendasEfetuadas * 0.85);

            total = salario + comissao;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
