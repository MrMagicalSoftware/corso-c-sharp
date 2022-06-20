using System;

namespace sommaTraDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Inserisci 2 numeri");

            //double float decimal
            //Virgola mobile.

            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"la somma dei due numeri {numero1} {numero2} vale "
                                 + (numero1 + numero2));

        }
    }
}
