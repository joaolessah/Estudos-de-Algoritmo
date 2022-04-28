using System;
using System.Globalization;
namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomeMercadoria;
            double[] precoCompra;
            double[] precoVenda;

            nomeMercadoria = new string[N];
            precoCompra = new double[N];
            precoVenda = new double[N];

            // Leitura de dados

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomeMercadoria[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            // Calculo do lucro 

            double diferenca, lucro;
            int cont10, contMeio, cont20;
            cont10 = 0;
            cont20 = 0;
            contMeio = 0;
            
            for (int i = 0; i < N; i++)
            {
                diferenca = precoVenda[i] - precoCompra[i];
                lucro = (diferenca * 100) / precoCompra[i];

                if(lucro < 10)
                {
                    cont10++;
                }
                else if(lucro >= 10 && lucro <= 20)
                {
                    contMeio++;
                }
                else{
                    cont20++;
                }
            }

            // Calculo total compra

            double somaCompra;
            somaCompra = 0;

            for (int i = 0; i < N; i++)
            {
                somaCompra += precoCompra[i];
            }


            // Calculo total venda

            double somaVenda;
            somaVenda = 0;

            for (int i = 0; i < N; i++)
            {
                somaVenda += precoVenda[i];
            }
            // Lucro total

            double lucro_total = somaVenda - somaCompra;

            // Apresentação de resultados

            Console.WriteLine("Lucro abaixo de 10%: " + cont10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contMeio);
            Console.WriteLine("Lucro acima de 20%: " + cont10);
            Console.WriteLine("Valor total de compra: " + somaCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somaVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro_total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
