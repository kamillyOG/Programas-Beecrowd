using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num, par=0;

            for (i=1; i<=5; i++){
                num=int.Parse(Console.ReadLine());
                if(num%2==0){
                    par++;
                }
            }

            Console.WriteLine("{0} valores pares", par);
        }
    }
}
