using System.Collections;

class Program
{

    public static void Mostrar(Stack e)
    {
        Console.Write("Mostrar Stack: ");
        foreach (object o in e)
        {
            Console.Write(o + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {


        Stack pilha = new Stack();
        for (int i = 1; i <= 5; i++)
        {
            pilha.Push(i);
        }
        Mostrar(pilha);

        Console.WriteLine("CONTANDO ELEMENTOS =============");

        Console.WriteLine(pilha.Count);

        pilha.Pop();

        Console.WriteLine("VERIFICANDO O 1 =============");

        if (pilha.Contains(1))
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
        }

        Console.WriteLine("VERIFICANDO O 5 =============");


        if (pilha.Contains(5))
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
        }

        Console.WriteLine("PROXIMO ELEMENTO =============");
        Console.WriteLine(pilha.Peek());

        for (int i = 6; i <= 10; i++)
        {
            pilha.Push(i);
        }


        Console.WriteLine("REMOVER 2 =============");
        pilha.Pop();
        pilha.Pop();

        Mostrar(pilha);

        Console.WriteLine("DEPOIS DE LIMPAR =============");
        pilha.Clear();
        Console.WriteLine(pilha.Count);



    }
}