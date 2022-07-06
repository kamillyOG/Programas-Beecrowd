using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, i;
            N=double.Parse(Console.ReadLine());

            for(i=2; i<= N; i++){
                if( i % 2 ==0){
                Console.WriteLine("{0} ^ 2 = {1}", i, Math.Pow(i,2));
                }
            }
        }
    }
}
