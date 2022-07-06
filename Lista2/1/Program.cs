using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i,num, soma=0;

            for (i=1; i<=6; i++){
                num=double.Parse(Console.ReadLine());
                if(num>0){
                    soma++;
                }
            }

            Console.WriteLine("{0} valores positivos", soma);
        }
    }
}
