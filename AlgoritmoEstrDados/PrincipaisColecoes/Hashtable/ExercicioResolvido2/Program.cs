using System.Collections;
using System.Reflection;

class Program
{

    public static void Main(string[] args)
    {
        Hashtable h = new Hashtable();

        for(int i = 1; i <=5; i++)
        {
            h.Add(i, i * 10);
        }

        Console.WriteLine(h.Count);

        h.Remove(1);

        if (h.ContainsKey(1))
        {
            Console.WriteLine("Sim, existe um objeto com chave 1");
        }
        else
        {
            Console.WriteLine("Não, não existe um objeto com chave 1");
        }

        if (h.ContainsKey(5))
        {
            Console.WriteLine("Sim, existe um objeto com chave 5");
        }
        else
        {
            Console.WriteLine("Não, não existe um objeto com chave 5");
        }

        for (int i = 6; i <= 10; i++)
        {
            h.Add(i, i * 10);
        }
       

        h.Remove(5);
        h.Remove(8);

     

        h.Clear();

        Console.WriteLine(h.Count);
    }
}