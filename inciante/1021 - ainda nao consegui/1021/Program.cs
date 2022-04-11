using System;
using System.Globalization;
namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

       

            int cem, cinquenta, vinte, dez, cinco, dois, resto100, resto50, resto20, resto10, resto5, resto2;

            double um, resto1, cinqCent, restcinqCent, vinteCent, restvintCent, dezCent, restdezCent, cincoCent, restcincoCent, umCent;

             

            //NOTAS 

            cem = (int)N / 100;
            resto100 = (int)N % 100;

            cinquenta = (int)resto100 / 50;
            resto50 = (int)resto100 % 50;

            vinte = (int)resto50 / 20;
            resto20 = (int)resto50 % 20;

            dez = (int)resto20 / 10;
            resto10 = (int)resto20 % 10;

            cinco = (int)resto10 / 5;
            resto5 = (int)resto10 % 5;

            dois = (int)resto5 / 2;
            resto2 = (int)resto5 % 2;

            // MOEDAS

            um = (int)resto2 / 1;
            resto1 = (int)resto2 % 1;

            cinqCent = (int)resto1 /0.5;
            restcinqCent = (int)resto1 % 0.5;

           /* vinteCent = (int) restcinqCent/ 2.5;
            restvintCent = (int)restcinqCent % 2.5;

            dezCent = (int)restvintCent / 2;
            restdezCent = (int)restvintCent % 2;

            cincoCent = (int)restdezCent / 2;
            restcincoCent = (int)restdezCent % 2;

            umCent = (int)restcincoCent / 1.0;
           */






            Console.WriteLine("NOTAS:");
            Console.WriteLine(cem + " nota(s) de R$ 100.00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50.00");
            Console.WriteLine(vinte + " nota(s) de R$ 20.00");
            Console.WriteLine(dez + " nota(s) de R$ 10.00");
            Console.WriteLine(cinco + " nota(s) de R$ 5.00");
            Console.WriteLine(dois + " nota(s) de R$ 2.00");


            Console.WriteLine("MOEDAS:");
            Console.WriteLine(um + " moeda(s) de R$ 1.00");
            Console.WriteLine(cinqCent + " moeda(s) de R$ 0.50");
            //Console.WriteLine(vinteCent + " moeda(s) de R$ 0.20");
            //Console.WriteLine(dezCent + " moeda(s) de R$ 0.10");
            //Console.WriteLine(cincoCent + " moeda(s) de R$ 0.05");
            //Console.WriteLine(umCent + " moeda(s) de R$ 0.01");



        }
    }
}
