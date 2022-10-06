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

    public static void VaiProFundo(Stack origem, Object elemento)
    {
        ArrayList teste = new ArrayList();
        foreach(object o in origem)
        {
            teste.Add(o);
        }
        teste.Add(elemento);
        teste.Reverse();

        origem.Clear();

        foreach(object o in teste)
        {
            origem.Push(o);
        }


    }

    public static void Main(string[] args)
    {
        //Faça o método public void VaiProFundo(Stack origem, Object elemento) que empilha o elemento passado como parâmetro no fundo da Stack, ao invés de no topo.


        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
      
        int teste = 9;

        VaiProFundo(s, teste);

        Mostrar(s);
        s.Push(3);
        Mostrar(s);
    }
}