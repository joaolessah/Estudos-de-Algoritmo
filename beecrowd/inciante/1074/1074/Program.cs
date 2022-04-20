using System;

namespace _1074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());


            for (int i = 0; i < N; i++)
            {

                int valorLido = int.Parse(Console.ReadLine());

                if (valorLido % 2 == 0 && valorLido > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valorLido % 2 == 0 && valorLido < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valorLido % 2 != 0 && valorLido > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (valorLido % 2 != 0 && valorLido < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
