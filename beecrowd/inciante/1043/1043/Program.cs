﻿using System;
using System.Globalization;
namespace _1043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, area, perimetro;
            string [ ] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < C + A && C < B + A)
            {
                perimetro = A + B + C; 
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
