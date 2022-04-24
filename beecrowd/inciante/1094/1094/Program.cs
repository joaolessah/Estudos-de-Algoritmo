using System;
using System.Globalization;
namespace _1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, totalCoelhos, totalRatos, totalSapos, total; 
            double percentRatos, percentCoelhos, percentSapos;




            totalCoelhos = 0;
            totalRatos = 0;
            totalSapos = 0;

           

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string[] vet = Console.ReadLine().Split(' ');
                int quantia = int.Parse(vet[0]);
                char animal = char.Parse(vet[1]);

                if (animal == 'C')
                {
               
                    totalCoelhos += quantia;
                }
                else if (animal == 'S')
                {
                   
                    totalSapos += quantia;
                }
                else 
                {
                 
                    totalRatos += quantia;
                }
            }

            

            total = totalCoelhos + totalRatos + totalSapos;
            percentCoelhos = (double) (totalCoelhos * 100.00) / total;
            percentRatos = (double) (totalRatos * 100.00)/ total;
            percentSapos = (double) (totalSapos * 100.00)/ total;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelhos);
            Console.WriteLine("Total de ratos: " + totalRatos);
            Console.WriteLine("Total de sapos: " + totalSapos);

            Console.WriteLine("Percentual de coelhos: " + percentCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
