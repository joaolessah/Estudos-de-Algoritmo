/*
 
 Fazer pesquisa de forma eficiente
    - Tipo dicionário/ mapa
    - Baseia-se em pares  de chave/valor
    - Função de transofrmação que recebe um valor e retorna uma chave do valor em um array
    - Problemas são as colisões
Add
Remove
Clear
Contains
ContainsKey
ContainsValue
 */


using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Hashtable h = new Hashtable();
        h.Add(1, "João");
        h.Add(2, "Maria");
        h.Add(3, "José");
        Console.WriteLine("({0}) / ({1})", h.Contains(1), h.Count);
        Console.WriteLine(h.ContainsKey(1));
        Console.WriteLine(h.ContainsValue("João"));
        h.Remove("João");
        Console.WriteLine(h.ContainsValue("João"));
    }
}