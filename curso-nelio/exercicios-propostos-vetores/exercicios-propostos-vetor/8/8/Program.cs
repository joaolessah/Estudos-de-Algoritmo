using System;
using System.Globalization;
namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double [] altura = new double[N];
            char [] genero = new char[N];
            int contHomem = 0;
            int contMulher = 0;
            double media, menor, maior, soma;
            soma = 0;
            menor = 2.0;
            maior = 0;

            // Leitura de dados

            for (int i = 0; i < N; i++)
            {
                string [] s = Console.ReadLine().Split(' ');
                altura [i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                genero [i] = char.Parse(s[1]);

            }
            // Menor altura 

            for (int i = 0; i < N; i++)
            {
                if (menor > altura[i])
                {
                   menor = altura[i];
                }
            }

            // Maior altura

            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maior)
                {
                    maior = altura[i];
                }
            }

            // Media alturas mulheres

            for (int i = 0; i < N; i++)
            {
                if (genero[i] == 'F')
                {
                    soma += altura[i];
                    contMulher++;
                }
            }

            media = soma / contMulher;


            // Contar homens

            for (int i = 0; i < N; i++)
            {
                if (genero[i] == 'M')
                {
                    contHomem++;
                }
            }


            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contHomem);

        }
    }
}
