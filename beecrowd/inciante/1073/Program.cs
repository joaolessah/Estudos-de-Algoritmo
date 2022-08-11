using System; 

class Program {

    static void Main(string[] args) { 

        int n1 = int.Parse(Console.ReadLine());
        for(int i = 1; i<= n1; i++){
            if(i % 2 == 0){
                int quadrado = (int)Math.Pow(i, 2);
                Console.WriteLine($"{i}^2 = {quadrado}");
            }
        }
    }

}