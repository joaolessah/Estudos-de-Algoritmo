using System;

namespace _1049
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo1 = Console.ReadLine();
            string tipo2 = Console.ReadLine();
            string tipo3 = Console.ReadLine();

            if (tipo1 == "vertebrado")
            {
                if(tipo2 == "ave")
                {
                    if(tipo3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if(tipo3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if(tipo2 == "inseto")
                {
                    if(tipo3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if(tipo3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
