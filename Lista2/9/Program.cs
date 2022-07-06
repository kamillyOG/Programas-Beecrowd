using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int X,Y,soma=0,maior=0, menor=0, i;
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
            

            for(i=menor; i<=maior; i++){
                if(i % 13 !=0){
                    soma+=i;
                }
                
            }
                Console.WriteLine("{0}", soma);
            
        }
    }
}
