using System;
using System.Globalization;
namespace _1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, count;
            double media, soma;

            idade = int.Parse(Console.ReadLine());

            count = 0;
            soma = 0;

            while(idade > 0)
            {
                soma += idade; 
                count++;
                idade = int.Parse(Console.ReadLine());
            }
            media = soma / count;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
