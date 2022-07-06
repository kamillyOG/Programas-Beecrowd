using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] linha = Console.ReadLine().Split(' ');
        int A=int.Parse(linha[0]);
        int B=int.Parse(linha[1]);
        int C=int.Parse(linha[2]);

        if (A> B && B>C){
            Console.WriteLine("{0}", C);
            Console.WriteLine("{0}", B);
            Console.WriteLine("{0}", A);
        } else if (A>C && C> B) {
            Console.WriteLine("{0}", B );
            Console.WriteLine("{0}", C);
            Console.WriteLine("{0}", A);
        }else if (B> A && A> C) {
            Console.WriteLine("{0}", C);
            Console.WriteLine("{0}", A);
            Console.WriteLine("{0}", B);
        } else if (B> C && C> A) {
            Console.WriteLine("{0}", A);
            Console.WriteLine("{0}", C);
            Console.WriteLine("{0}",B);
        } else if (C> A && A> B) {
            Console.WriteLine("{0}", B);
            Console.WriteLine("{0}", A);
            Console.WriteLine("{0}",C);
        } else if (C> B && B> A) {
            Console.WriteLine("{0}", A);
            Console.WriteLine("{0}", B);
            Console.WriteLine("{0}", C);
        } 
        
        Console.WriteLine();
        Console.WriteLine("{0}",A );
        Console.WriteLine("{0}",B );
        Console.WriteLine("{0}",C );
        }
    }
}
