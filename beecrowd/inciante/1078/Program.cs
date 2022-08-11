using System; 

class Program {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= 10; i++){
            int mult = i * n;
            Console.WriteLine($"{i} x {n} = {mult}");
        }

    }

}