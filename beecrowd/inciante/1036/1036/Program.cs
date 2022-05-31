using System;
using System.Globalization;
namespace _1036
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string [] x = Console.ReadLine().Split(' ');

            double A,B,C; 

            A = double.Parse(x[0], CultureInfo.InvariantCulture);
            B = double.Parse(x[1], CultureInfo.InvariantCulture);
            C = double.Parse(x[2], CultureInfo.InvariantCulture);

            double delta, R1, R2;

            delta = Math.Pow(B, 2) - (4*A*C);
            
            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                R1 = (- B + Math.Sqrt(delta)) / (2 * A);
                R2 = (- B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));


                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
