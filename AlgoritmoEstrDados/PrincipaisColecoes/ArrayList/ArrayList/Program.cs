using System.Collections;


class Program
{
    public static void Main (string[] args)
    {
        // Ex resolvido 1
        /* ArrayList arrayList = new ArrayList(20);

        Console.WriteLine(arrayList.Capacity);
        Console.WriteLine(arrayList.Count);

        arrayList.Add(5);
        arrayList.Add("João");

        Console.WriteLine(arrayList.Capacity);
        Console.WriteLine(arrayList.Count);*/

        // Foreach - Ex resolvido 2

        ArrayList arrayList = new ArrayList();
        double soma, media;
        soma = 0;


        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());
            arrayList.Add(num);
            soma += num;
        }

        media = soma / arrayList.Count;

        foreach(int i in arrayList)
        {
            if(i > media)
            {
                Console.WriteLine(i);
            }
        }

    }
}

// Propriedade Capacity -> Manipular a capacidade de um ArrayList
// Propriedade Count -> Quantidade de elementos no ArrayList

// Declaração: ArrayList al1 = new ArrayList() - capacidade 0
// ArrayList al2 = new ArrayList(10) -> capacidade dobra se chegar no limite

// Inserir um elemento é com ADD

/*
 * Comandos ArrayList
    - Add -> Inserve um objeto e retoma sua posição
    - Insert -> Insere numa posiçõ especificada
    - Remove -> Remove a primeira ocorrencia do objeto especificado
    - RemoveAt -> remove um objeto num indice específico
    - RemoveRange -> remove uma determinada quantidade e elementos a partir do indice especificado
    - Clear -> remove todos os elementos sem alterar capacidade
    - Contains -> retorna se a estrutura contem um objeto
    - IndexOf -> retorna o indice da primeira ocorrencia de dado objeto
    - LastIndexOf -> retorna o indice da ultima ocorrencia de dado objeto
    - Reverse: inverte a ordem dos elementos
    - Sort -> ordena os objetos
    - ToArray -> copia os objetos para um array
    - TrimToSize -> Altera a capacity para a quantidade de elementos
    - BinarySearch -> Realiza uma busca binária e retoma a posição do elemento ou um numero negativo se não for encontrado
 */