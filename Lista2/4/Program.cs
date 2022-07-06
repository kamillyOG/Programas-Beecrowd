using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma=0;
            int X, Y, i, maior=0, menor=0; 
            X=int.Parse(Console.ReadLine());
            Y=int.Parse(Console.ReadLine());


            if(X<Y){
                menor=X;
            } else{
                menor=Y;
            }

            if(Y<X){
                maior= X;
            } else{
                maior=Y;
            }
            

            for(i=menor+1; i<maior; i++){
                if(i % 2 !=0){
                    soma+=i;
                }
            }

            Console.WriteLine("{0}", soma);
            
        }
    }
}
