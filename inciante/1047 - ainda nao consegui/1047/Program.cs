using System;

namespace _1047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);
            int resto;
            int instanteInicial = horaInicial * 3600 + minutoInicial *60;
            int instanteFinal = horaFinal * 3600  + minutoFinal *60;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 3600;
            resto = duracaoHoras % 3600;
            int duracaoMinutos = resto / 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

        }
    }
}

