using System;

namespace _1065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, pares;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            pares = 0;

            if (n1 % 2 == 0)
            {
                pares++;
            }
            if (n2 % 2 == 0)
            {
                pares++;
            }
            if (n3 % 2 == 0)
            {
                pares++;
            }
            if (n4 % 2 == 0)
            {
                pares++;
            }
            if (n5 % 2 == 0)
            {
                pares++;
            }

            Console.WriteLine(pares + " valores pares");
        }
    }
}
