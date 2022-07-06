using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, i, a=0, b=0;
            N= int.Parse(Console.ReadLine());

            for (i=0 ; i<N; i++){
                X=int.Parse(Console.ReadLine());
                if ( X>=10 && X<=20){
                    a+=1;
                }else{
                    b+=1;
                }

            }

            Console.WriteLine("{0} in", a );
            Console.WriteLine("{0} out", b);
        }
    }
}
