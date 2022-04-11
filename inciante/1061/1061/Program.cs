using System;

namespace _1061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaIni, diaFin, totalEvento, totalDias, restoD, totalHoras, restoH, totalMinutos, restoM, segundos, diasTotais;

            /* ENTRADAS DE DADOS + CONVERSÃO DE TUDO PARA SEGUNDOS */



            //Aqui eu recebo o dia e recorto o número dele armazenando em uma variável e também converto para segundos
            string[] dia1 = Console.ReadLine().Split(' ');
            diaIni = (int.Parse(dia1[1]))*86400;

            //Console.WriteLine(diaIni);


            //Aqui é onde ocorre a entrada dos dados
            string[] horaInicio = Console.ReadLine().Split(':');

            //Dados que já entram convertidos
            int hh1 = int.Parse(horaInicio[0]) * 3600;
            int mm1 = int.Parse(horaInicio[1]) * 60;
            int ss1 = int.Parse(horaInicio[2]);


            //Console.WriteLine(hh1 + " " + mm1 + " " + ss1);


            //Mesma coisa da primeira entrada de dia
            string[] dia2 = Console.ReadLine().Split(' ');
            diaFin = (int.Parse(dia2[1])*86400);

            //Console.WriteLine(diaFin);


            //Entrada dos segundos valores
            string[] horaFim = Console.ReadLine().Split(':');

            int hh2 = int.Parse(horaFim[0]) * 3600;
            int mm2 = int.Parse(horaFim[1]) * 60;
            int ss2 = int.Parse(horaFim[2]);

            //Console.WriteLine(hh2 + " " + mm2 + " " + ss2);

            // Aqui eu pego o valor inteiro dos dias, subtraio para saber quantos segundos tem entre os dois dias


            /* TRABALHOS COM OS DADOS COLETADOS + CONVERSÕES */ 


            diasTotais= (diaFin - diaIni);

            // Aqui eu quero saber quantos segundos teve todo o evento com tudo pronto
            totalEvento = diasTotais + (( hh2 + mm2 + ss2) - ( + hh1 + mm1 + ss1));

            //Console.WriteLine(totalEvento);

            // Aqui começa a divisão para encontrar os numeros solicitados

            totalDias = totalEvento / 86400;
            restoD = totalEvento % 86400;

            //Console.WriteLine(totalDias + " " + restoD);

            totalHoras = restoD / 3600;
            restoH = restoD % 3600;

            //Console.WriteLine(totalHoras + " " + restoH);

            totalMinutos = restoH / 60;
            restoM = restoH % 60;

            segundos = restoM / 1;


            
            Console.WriteLine(totalDias + " dia(s)");
            Console.WriteLine(totalHoras + " hora(s)");
            Console.WriteLine(totalMinutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");

            
        }
    }
}