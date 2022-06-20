using System;

namespace trovaMaggiore3Numeri
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci 3 numeri");

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n\n\n\n");

            if(numero1 == numero2 && numero2 == numero3)
                System.Console.WriteLine("Numeri uguali " + numero1);
            else if(numero1 >= numero2 && numero1 >= numero3)
                System.Console.WriteLine(numero1);
            else if(numero2 >= numero1 && numero2 >= numero3)
                System.Console.WriteLine(numero2);
            else
                System.Console.WriteLine(numero3);

        }
    }
}
