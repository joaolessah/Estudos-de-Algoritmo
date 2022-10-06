/*
 
Queue (primeiro que entra é o primeiro que sai)
    1- Enqueue
    2- Dequeue
 Stack (o primeiro que entra é o ultimo a sair)
    1- Push
    2- Pop
Clear
Contains
Peek
Count - Quantidade de elementos na estrutura
 */

/*
 Exercicio 1

Fila

- Adiciono 1,2,3 na fila
- Imprimo true, 3, 1
- Imprimo false, 2, 2

Pilha

- Imprimo true, 3, 3
- Imprimo true, 2, 2
 
 
 */


using System.Collections;

public class Program
{
    private static void Main(string[] args)
    {
        Queue f = new Queue();
        f.Enqueue(1); f.Enqueue(2); f.Enqueue(3);
        Console.Write("Fila: ({0}) / ({1}) / ({2})\n", f.Contains(1), f.Count, f.Peek());
        Console.WriteLine(f.Dequeue());
        Console.Write("Fila: ({0}) / ({1}) / ({2})\n", f.Contains(1), f.Count, f.Peek());
        Stack p = new Stack();
        p.Push(1); p.Push(2); p.Push(3);
        Console.Write("Pilha: ({0}) / ({1}) / ({2})\n", p.Contains(1), p.Count, p.Peek());
        Console.WriteLine(p.Pop());
        Console.Write("Pilha: ({0}) / ({1}) / ({2})\n", p.Contains(1), p.Count, p.Peek());
    }
}