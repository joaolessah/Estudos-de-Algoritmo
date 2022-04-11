using System;

namespace _1042
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2, n3, A, B, C;

            string [ ] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);
            n3 = int.Parse(vet[2]);

            if (n1 < n2 && n1 < n3)
            {
                A = n1;
                if (n2 < n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }

            }
            else if (n2 < n3)
            {
                A = n2;
                if(n1 < n3)
                {
                    B = n1;
                    C = n3; 
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if(n1 < n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine();
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
