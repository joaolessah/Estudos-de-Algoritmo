using System.Collections;
using System.Runtime;

class Program
{
    public static void Mostrar(Queue q)
    {
        Console.Write("Mostrar Queue: ");
        foreach (object o in q)
        {
            Console.Write(o + " ");
        }
        Console.WriteLine();
    }

    public static void InverterQueue(Queue q)
    {
        Stack teste = new Stack();
        foreach(object o in q)
        {
            teste.Push(o);
        }
        q.Clear();
        foreach(object o in teste)
        {
            q.Enqueue(o);
        }
    }

    public static void Main(string[] args)
    {
        //Faça o método public void InverterQueue(Queue q) que inverte a ordem dos elementos do Queue q, no próprio Queue. Neste exercício, se necessário, utilize estruturas auxiliares (array, ArrayList, Stack ou mesmo outro Queue). Contudo, não é permitido o uso do método Reverse().

        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(50);

        Mostrar(q);
        
        InverterQueue(q);

        Mostrar(q);



    }
}