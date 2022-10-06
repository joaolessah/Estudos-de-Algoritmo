using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();


        // Métodos de adição

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);



        arrayList.Insert(2, 5);

       

        // Métodos de remoção

        arrayList.Remove(2);
        arrayList.RemoveAt(2);
        arrayList.RemoveRange(1, 2);

        //Console.WriteLine(arrayList);

        arrayList.Clear();

  

        ////

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);



        //// Busca

        Console.WriteLine(arrayList.Contains(3));
        Console.WriteLine(arrayList.IndexOf(4));
        Console.WriteLine(arrayList.LastIndexOf(1));



        //// Reverse

        arrayList.Reverse();


        //// Sort

        arrayList.Sort();
        foreach (int i in arrayList)
        {
            Console.WriteLine(i);
        }

        //// ToArray

        Object[] teste = arrayList.ToArray();

        foreach(int i in teste)
        {
            Console.WriteLine(i);
        }

        //// BinarySearch

        Console.WriteLine(arrayList.BinarySearch(4));



    }
}