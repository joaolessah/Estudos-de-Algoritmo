using System;

namespace _1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int restoCem, resto50, resto20, resto10, resto5, resto2;
            int cem, cinquenta, vinte, dez, cinco, dois, um;

            cem = N / 100;
            restoCem = N % 100;

            cinquenta = restoCem / 50;
            resto50 = restoCem % 50;

            vinte = resto50 / 20;
            resto20 = resto50 % 20;

            dez = resto20 / 10;
            resto10 = resto20 % 10;

            cinco = resto10 / 5;
            resto5 = resto10 % 5;

            dois = resto5 / 2;
            resto2 = resto5 % 2;

            um = resto2 / 1;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");




        }
    }
}
