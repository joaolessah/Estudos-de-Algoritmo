using System;

namespace _1066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, impar, par, positivo, negativo;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            impar = 0;
            par = 0;
            negativo = 0;
            positivo = 0;

            if(n1 > 0)
            {
                positivo++;
            }
            if (n2 > 0)
            {
                positivo++;
            }
            if (n3 > 0)
            {
                positivo++;
            }
            if (n4 > 0)
            {
                positivo++;
            }
            if (n5 > 0)
            {
                positivo++;
            }
            if (n1 < 0)
            {
                negativo++;
            }
            if (n2 < 0)
            {
                negativo++;
            }
            if (n3 < 0)
            {
                negativo++;
            }
            if (n4 < 0)
            {
                negativo++;
            }
            if (n5 < 0)
            {
                negativo++;
            }

            if (n1 % 2 == 0)
            {
                par++;
            }
            if (n2 % 2 == 0)
            {
                par++;
            }
            if (n3 % 2 == 0)
            {
                par++;
            }
            if (n4 % 2 == 0)
            {
                par++;
            }
            if (n5 % 2 == 0)
            {
                par++;
            }

            if (n1 % 2 != 0)
            {
                impar++;
            }
            if (n2 % 2 != 0)
            {
                impar++;
            }
            if (n3 % 2 != 0)
            {
                impar++;
            }
            if (n4 % 2 != 0)
            {
                impar++;
            }
            if (n5 % 2 != 0)
            {
                impar++;
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");


        }
    }
}
