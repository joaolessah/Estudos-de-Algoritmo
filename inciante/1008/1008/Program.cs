using System;
using System.Globalization;
namespace _1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, horasTrabalhadas;
            double valorHora, SALARY;

            NUMBER = int.Parse(Console.ReadLine());

            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = horasTrabalhadas * valorHora;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}


// CultureInfor.InvariantCulture considera o . como forma de contabilizar casas decimais, sem ele utilizamos virgula.