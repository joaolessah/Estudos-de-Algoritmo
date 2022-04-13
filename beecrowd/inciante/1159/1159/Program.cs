using System;

namespace _1159
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X = int.Parse(Console.ReadLine());
            int somaImpar, somaPar;
            
            
            while(X != 0)
            {
                if (X % 2 == 0)
                {
                    somaPar = 0;

                    somaPar += X;
                    X += 2;
                    somaPar += X;
                    X += 2;
                    somaPar += X;
                    X += 2;
                    somaPar += X;
                    X += 2;
                    somaPar += X;
                    Console.WriteLine(somaPar);
                }
                else 
                {
                    somaImpar = 0;

                    X++;

                    somaImpar += X;
                    X += 2;
                    somaImpar += X;
                    X += 2;
                    somaImpar += X;
                    X += 2;
                    somaImpar += X;
                    X += 2;
                    somaImpar += X;

                    Console.WriteLine(somaImpar);


                }
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
