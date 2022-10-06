using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite um caracter {i}/10: ");

            char caracter = Console.ReadLine()[0];

            if (caracter >= 'A' && caracter <= 'Z')
            {
                Console.WriteLine("Adicionado na pilha!");
                stack.Push(caracter);
            }
            else if (caracter >= 'a' && caracter <= 'z')
            {
                Console.WriteLine("Removendo da pilha: " + stack.Pop());
            }
            else
            {
                Console.WriteLine("O próximo elemento a ser removido será o " + stack.Peek());
            }
        }
    }
}