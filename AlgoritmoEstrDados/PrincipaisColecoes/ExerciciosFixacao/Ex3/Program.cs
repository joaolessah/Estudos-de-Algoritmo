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

    public static Stack CopiarStack(Stack s)
    {
        Stack copia = new Stack();
        ArrayList teste = new ArrayList();

        foreach(object o in s)
        {
            teste.Add(o);
        }

        teste.Reverse();

        foreach (object t in teste)
        {
            copia.Push(t);
        }

 
        return copia;
    }

    public static void Main(string[] args)
    {
        //Faça o método public Stack CopiarStack (Stack origem) que retorna uma cópia da Stack origem passada como parâmetro. Os elementos da Stack origem devem permanecer na mesma ordem original. Neste exercício não é permitido o uso dos métodos Clone() e CopyTo() da classe Stack.


        Stack s = new Stack();
        s.Push(1);
        s.Push(2);

        Mostrar(s);
        Stack copia = new Stack();
        copia = CopiarStack(s);
        Mostrar(copia);

    }
}