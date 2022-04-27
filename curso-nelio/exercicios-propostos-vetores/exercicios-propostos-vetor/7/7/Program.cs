using System;
using System.Globalization;
namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string [] nome = new string[N];
            double [] nota1 = new double[N];
            double [] nota2 = new double[N];

            // Leitura de dados

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');   
                nome [i] = s[0];
                nota1 [i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2 [i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            // Validação da aprovação media >= 6

            
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < N; i++)
            {
                
                double media, soma;

                soma = nota1 [i] + nota2[i];

                media = soma / 2;

                if (media >= 6)
                {
                    Console.WriteLine(nome[i]);
                }

            }
           
        }
    }
}
