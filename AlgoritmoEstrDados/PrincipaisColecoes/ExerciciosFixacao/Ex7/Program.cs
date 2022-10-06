using System.Collections;
using System.Runtime;

class Program
{
    public static void Mostrar(Hashtable s)
    {
        Console.Write("Mostrar HashTable: ");
        foreach (DictionaryEntry o in s)
        {
            Console.Write(o.Key + "  -  " + o.Value +  "/ ");
        }
        Console.WriteLine();
    }

    public static Hashtable ConcatenarHashTable(Hashtable ht1, Hashtable ht2)
    {
        Hashtable novoHash = new Hashtable();

        foreach (DictionaryEntry o in ht1)
        {
            novoHash.Add(o.Key, o.Value);
        }
        foreach (DictionaryEntry o in ht2)
        {
            novoHash.Add(o.Key, o.Value);
        }

        return novoHash;
    }

    public static void Main(string[] args)
    {
        //Faça o método public Hashtable ConcatenarHashtable(Hashtable ht1, Hashtable th2) que retorna um novo Hashtable contendo todos os elementos de ht1 e ht2.

        Hashtable ht1 = new Hashtable();
        ht1.Add(1, 10);
        ht1.Add(2, 10);
        ht1.Add(3, 10);
       
        Mostrar(ht1);

        Hashtable ht2 = new Hashtable();
        
        ht2.Add(4, 20);
        ht2.Add(5, 20);
        ht2.Add(6, 20);
        Mostrar(ht2);
        Hashtable ht3 = new Hashtable();
        ht3 = ConcatenarHashTable((Hashtable)ht1, (Hashtable)ht2);

        Mostrar(ht3);
    }
}