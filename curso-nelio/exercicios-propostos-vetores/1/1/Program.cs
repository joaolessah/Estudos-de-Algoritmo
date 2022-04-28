using System;
using System.Globalization;
namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double [] valores = new double[N];

            string [] x = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                valores[i] = double.Parse(x[i], CultureInfo.InvariantCulture);
            }

            double maior;
            maior = 0;
            foreach (int i in valores)
            {
                if(i > maior)
                {
                    maior = i;
                }
            }

            // como maior recebe I que é o apelido do elemento, eu procurei o maior, dentro do array valores, utilizando o index OF, mas ainda não entendi muito bem o que eu fiz
            int indice = Array.IndexOf(valores, maior);


            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(indice);
        }
    }
}
