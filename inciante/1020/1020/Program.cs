using System;

namespace _1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeDias = int.Parse(Console.ReadLine());
            int mes, dia, ano, restoAno, restoMes;

            ano = idadeDias / 365;
            restoAno = idadeDias % 365;

            mes = restoAno / 30;
            restoMes = restoAno % 30;

            dia = restoMes / 1;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");

        }
    }
}
