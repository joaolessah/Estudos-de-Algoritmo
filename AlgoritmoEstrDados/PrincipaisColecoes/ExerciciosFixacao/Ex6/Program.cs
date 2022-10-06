using System.Collections;
using System.Runtime;

class Program
{
    public static void Mostrar(Stack s)
    {
        Console.Write("Mostrar Queue: ");
        foreach (object o in s)
        {
            Console.Write(o + " ");
        }
        Console.WriteLine();
    }

    public static void InverterStack(Stack s)
    {
        Queue teste = new Queue();
        foreach (object o in s)
        {
            teste.Enqueue(o);
        }
        s.Clear();
        foreach (object o in teste)
        {
            s.Push(o);
        }
    }

    public static void Main(string[] args)
    {
        //Faça o método public void InverterStack(Stack s) que inverte a ordem dos elementos do Stack s, no próprio Stack.. Neste exercício, se necessário, utilize estruturas auxiliares (array, ArrayList, Stack ou Queue). Contudo, não é permitido o uso do método Reverse().

        Stack q = new Stack();
        q.Push(1);
        q.Push(2);
        q.Push(50);

        Mostrar(q);
        q.Pop();
        InverterStack(q);

        Mostrar(q);



    }
}