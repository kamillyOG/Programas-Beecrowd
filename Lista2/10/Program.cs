using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, x=1;
            N= int.Parse(Console.ReadLine());

            if (N>0){
            for (i=1; x<=N; i+=4){
                Console.WriteLine("{0} {1} {2} PUM", i, i+1, i+2);
                x++;
            }
            }
        }
    }
}
