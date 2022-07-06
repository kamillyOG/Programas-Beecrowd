using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario= double.Parse(Console.ReadLine());
        if (salario >= 0.0 && salario <= 400.00){
            double novo= salario+ (salario*0.15);
            double reajuste= (salario*0.15);
            Console.WriteLine("Novo salario: {0:0.00}", novo);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: 15 %");
        } else if (salario >= 400.01 && salario <= 800.00){
            double novo= salario+ (salario*0.12);
            double reajuste=  (salario*0.12);
            Console.WriteLine("Novo salario: {0:0.00}", novo);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: 12 %");
        } else if (salario >= 800.01 && salario <= 1200.00){
            double novo= salario+ (salario*0.10);
            double reajuste= (salario*0.10);
            Console.WriteLine("Novo salario: {0:0.00}", novo);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: 10 %");
        } else if (salario >= 1200.01 && salario <= 2000.00){
            double novo= salario+ (salario*0.07);
            double reajuste=(salario*0.07);
            Console.WriteLine("Novo salario: {0:0.00}", novo);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: 7 %");
        }else if (salario >= 1200.00){
            double novo= salario+ (salario*0.04);
            double reajuste= (salario*0.04);
            Console.WriteLine("Novo salario: {0:0.00}", novo);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: 4 %");
        }
        }
    }
}
