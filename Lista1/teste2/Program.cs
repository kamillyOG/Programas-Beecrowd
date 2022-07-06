using System;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {

        double A= double.Parse(Console.ReadLine());
        double B= double.Parse(Console.ReadLine());
        double C= double.Parse(Console.ReadLine());
        double delta=(B*B) - 4*A*C;
        double raiz=Math.Sqrt(delta);
        if (delta<=0 || (2*A)==0){
            Console.WriteLine("Impossivel calcular");
        } else {
            double R1=(((-B) + raiz) / (2 * A));
            double R2=(((-B) - raiz) / (2 * A));
            Console.WriteLine("R1 = {0:0.00000}", R1);
            Console.WriteLine("R2 = {0:0.00000}", R2);
        }    
       
        }
    }
}
