using System.Collections;

class Program
{

    public static void Mostrar(Queue e)
    {
        Console.Write("Mostrar Queue: ");
        foreach (object o in e)
        {
            Console.Write(o + " ");
        }
        Console.WriteLine();
    }

    static void Main (string [] args)
    {

 
        Queue fila = new Queue();
        for(int i = 1; i <= 5; i++)
        {
            fila.Enqueue(i);
        }
        Mostrar(fila);

        Console.WriteLine("CONTANDO ELEMENTOS =============");

        Console.WriteLine(fila.Count);

        fila.Dequeue();

        Console.WriteLine("VERIFICANDO O 1 =============");

        if (fila.Contains(1))
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
        }

        Console.WriteLine("VERIFICANDO O 5 =============");


        if (fila.Contains(5))
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
        }

        Console.WriteLine("PROXIMO ELEMENTO =============");
        Console.WriteLine(fila.Peek());

        for (int i = 6; i <= 10; i++)
        {
            fila.Enqueue(i);
        }


        Console.WriteLine("REMOVER 2 =============");
        fila.Dequeue();
        fila.Dequeue();

        Mostrar(fila);

        Console.WriteLine("DEPOIS DE LIMPAR =============");
        fila.Clear();
        Console.WriteLine(fila.Count);



    }
}