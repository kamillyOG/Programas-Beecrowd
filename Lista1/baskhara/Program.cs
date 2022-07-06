using System;

namespace baskhara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A= double.Parse(Console.ReadLine());
            double B= double.Parse(Console.ReadLine());
            double C= double.Parse(Console.ReadLine());
       
            double D= (B*B) *-4*A*C;
            double R = Math.Sqrt(D);
       
                if (R<0) {
                    Console.WriteLine("Impossivel calcular");
                } else {
                   double R1= (-B + R)/ (2* A);
                   double R2= (-B - R) / (2* A);
                     Console.WriteLine(" R1 = {0:0.00000}", R1);
                     Console.WriteLine(" R2 = {0:0.00000}", R2);
                }
        }
    }
}
