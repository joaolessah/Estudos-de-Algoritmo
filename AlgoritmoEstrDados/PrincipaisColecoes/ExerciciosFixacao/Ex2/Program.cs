using System.Collections;
using System.Reflection;

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

    public static Queue CopiarQueue(Queue q)
    {
        Queue copia = new Queue(q);
        copia = (Queue)q.Clone();
        return copia;
    }

    public static void Main (string[] args)
    {
        //Faça o método public Queue CopiarQueue(Queue origem) que retorna uma cópia da Queue origem passada como parâmetro. Os elementos da Queue origem devem permanecer na mesma ordem original. Neste exercício é permitido o uso dos métodos Clone() e CopyTo() da classe Queue.

        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);

        Queue teste = new Queue();

        teste = CopiarQueue(q);

        Mostrar(q);
        Mostrar(teste);

    }
}