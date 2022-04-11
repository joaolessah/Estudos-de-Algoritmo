using System;
using System.Globalization;
namespace _1035
{

    internal class Program
    {
        static void Main(string[] args)
        {

            int somaCD, somaAB;
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            int C = int.Parse(vet[2], CultureInfo.InvariantCulture);
            int D = int.Parse(vet[3], CultureInfo.InvariantCulture);

            somaCD = C + D;
            somaAB = A + B;


            if (B > C && 
                D > A && 
                somaCD > somaAB && 
                C > 0 && 
                D > 0 && 
                A % 2 == 0)
            // Todas as condições devem ser true para que entre no if
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }

}