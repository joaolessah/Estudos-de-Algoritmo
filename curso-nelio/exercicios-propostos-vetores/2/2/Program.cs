using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, cont;
            N = int.Parse(Console.ReadLine());
            cont = 0;
            int [] numeros  = new int[N];

            string [] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(s[i]);
            }

            for(int i = 0; i < N; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);
            
        }
    }
}
