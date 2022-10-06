using System.Collections;

class Program
{
    public static void Mostrar(ArrayList al)
    {
        Console.Write("Mostrar ArrayList: ");
        foreach (object o in al)
        {
            Console.Write(o + " ");
        }
        Console.WriteLine();
    }

    public static ArrayList CopiarQueueParaArrayList(Queue q)
    {
        ArrayList teste = new ArrayList();
        foreach (object o in q)
        {
            teste.Add(o);
        }
        return teste;
    }
    public static void Main (string[] args)
    {
        //Faça o método public ArrayList CopiarQueueParaArrayList(Queue origem) que copia todos os elementos do Queue origem e retorna um novo ArrayList. Neste exercício não é permitido o uso dos métodos Clone() nem CopyTo().

        ArrayList al = new ArrayList();
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        al = CopiarQueueParaArrayList(q);

        Mostrar(al);


    }
}