using System;

namespace _1046
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, duracaoH, duracaoS;
            string[] vet = Console.ReadLine().Split(' ');

            A = (int.Parse(vet[0]));
            B = (int.Parse(vet[1]));


            if (A == 0 && B == 0)
            {
                A = 1;
                B = 1;
                A += 12 * 3600;
                B += 12 * 3600;
                duracaoH = (A + B) / 3600;

                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S)");

            }
            else if (A < 12 && B < 12)
            {
                A *= 3600;
                B *= 3600;
                B += 12 * 7200;
                A += 12 * 7200;

                duracaoS = Math.Abs(B - A);
                duracaoH = duracaoS / 3600;

                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S)");

            }

            //
            else if (A < 12)
            {
                A = (A * 3600) + (12 * 7200);
                B *= -3600;

                duracaoH = Math.Abs(B - A) / 10800;
                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S)");

            }
            //
            else if (A > 12 || B < 12)
            {
                B *= 3600;
                B += 12 * 7200;
                A *= 3600;

                duracaoH = Math.Abs(B - A) / 3600;

                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S)");

            }

            ///
            else
            {
                A *= 3600;
                B *= 3600;
                duracaoS = Math.Abs(B - A);
                duracaoH = duracaoS / 3600;

                Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S)");


            }
        }
    }
}
