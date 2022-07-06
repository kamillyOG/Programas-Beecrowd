using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, m;
            N= int.Parse(Console.ReadLine());

            for (i=1; i<=10; i++){
                m= i* N;
                Console.WriteLine("{0} x {1} = {2}", i, N, m);
            }
        }
    }
}
