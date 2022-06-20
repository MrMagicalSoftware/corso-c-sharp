using System;

namespace EsercizioLezione2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Inserisci 2 numeri");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"i numeri inseriti sono {numero1}  {numero2}");

            if(numero1 == numero2)
            {
                System.Console.WriteLine($"I due numeri sono uguali {numero1}");
            }
            else
            {
                System.Console.WriteLine($"I due numeri sono diversi {numero1}  {numero2}");
            }

        }
    }
}
