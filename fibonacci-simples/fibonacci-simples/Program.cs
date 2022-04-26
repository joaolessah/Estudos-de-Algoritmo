using System;

namespace fibonacci_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant_num, contador, anterior, atual, proximo;

            anterior = 0;
            atual = 1;
            proximo = 1;

            Console.WriteLine("Digite a quantidade de números desejados: ");
            quant_num = int.Parse(Console.ReadLine());

            for (contador = 1; contador <= quant_num; contador++)
            {
                Console.WriteLine(proximo);
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }
        }
    }
}
