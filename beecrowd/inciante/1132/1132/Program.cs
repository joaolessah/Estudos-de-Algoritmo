using System;

namespace _1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma, maior,menor;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            soma = 0;

           /* if (X < Y)
            {
                for (int i = X; i < Y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }

            else if (X > Y)
            {
                for (int i = Y; i < X; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }

            */


            if (X < Y)
            {
                menor = X;
                maior = Y;
            }
            else
            {
                menor = Y;
                maior = X;
            }

            soma = 0;

            for (int i = menor; i < maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;

                }
            }
            
            /*if (Y % 13 != 0)
            {
                soma += Y;
            }

            else if (X % 13 != 0)
            {

                soma += X;
            }
            else
            {
                soma += X + Y;
            }*/
            
            Console.WriteLine(soma);
        }
    }
}