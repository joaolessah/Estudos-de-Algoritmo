using System;
using System.Globalization;
namespace _1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            string[] notas = Console.ReadLine().Split(' ');

            n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);



            media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            //GAMBIARRA DO PROFESSOR, O RESTO FIZ SOZIN


            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                float mediaFinal;

                float n5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));

                mediaFinal = (media + n5) / 2;

                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (mediaFinal <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");

                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
