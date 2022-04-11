using System;
using System.Globalization;

namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12 km/l 
            //tempo gasto em horas 
            //velocidade média em km/h
            //distancia percorrida e calcular a quantidade de litros
            // resultado com 3 casas decimais

            // Entrada são dois inteiros: tempo gasto na viagem, velocidade média durante a viagem


            int tempoGasto, velocidadeMedia;
            double quantidadeLitros;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            //aqui usei o casting que foi permitir que valores inteiros fossem convertidos a double
            quantidadeLitros = (double) tempoGasto * velocidadeMedia / 12;

            Console.WriteLine(quantidadeLitros.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
            
        }
    }
}
