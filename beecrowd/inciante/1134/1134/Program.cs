using System;

namespace _1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, alcool, gasolina, diesel;

            numero = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            diesel = 0;


            while (numero != 4)
            {
                switch (numero)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                }
                numero = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
