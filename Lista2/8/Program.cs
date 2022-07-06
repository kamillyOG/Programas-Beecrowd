using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            do{
                string[] linha = Console.ReadLine().Split();
                x = int.Parse(linha[0]);
                y = int.Parse(linha[1]);

                if(x<y){
                    Console.WriteLine("Crescente");
                } else if(x>y) {
                    Console.WriteLine("Decrescente");
                } else {
                    continue;
                }
            } while (x!=y);

        }
    }
}
