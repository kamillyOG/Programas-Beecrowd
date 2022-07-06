using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double i,num, positivo=0, soma=0, media;

            for (i=1; i<=6; i++){
                num=double.Parse(Console.ReadLine());
                if(num>0){
                    positivo++; 
                    soma+=num; 
                }  
                
            }
            
            media= soma/positivo;
            Console.WriteLine("{0} valores positivos", positivo);
            Console.WriteLine("{0:0.0}", media);
        }
    }
}
