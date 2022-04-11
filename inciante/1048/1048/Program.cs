using System;
using System.Globalization;

namespace _1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajusteGanho;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0 && salario <= 400.00)
            {
                percentual = 15;
                novoSalario = salario + (salario * percentual / 100);
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");

            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                novoSalario = salario + (salario * percentual / 100);
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }

            else if (salario >= 800.01 && salario <= 1200.00){

                percentual = 10;
                novoSalario = salario + (salario * percentual / 100);
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else if (salario >= 1200.01 && salario <= 2000)
            {
                percentual = 7;
                novoSalario = salario + (salario * percentual / 100);
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
            else
            {
                percentual = 4;
                novoSalario = salario + (salario * percentual / 100);
                reajusteGanho = novoSalario - salario;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajusteGanho.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + percentual + " %");
            }
        }
    }
}
