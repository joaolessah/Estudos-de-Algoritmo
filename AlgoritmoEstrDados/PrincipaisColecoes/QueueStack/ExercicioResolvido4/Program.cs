using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite um caracter {i}/10: ");

            char caracter = Console.ReadLine()[0];

            if(caracter >= 'A' && caracter<= 'Z')
            {
                Console.WriteLine("Adicionado na fila!");
                queue.Enqueue(caracter);
            }
            else if(caracter >= 'a' && caracter<= 'z')
            {
                Console.WriteLine("Removndo da fila: " + queue.Dequeue());
            }
            else
            {
                Console.WriteLine("O próximo elemento a ser removido será o " + queue.Peek());
            }
        }
    }
}