using System;

namespace EsercizioValoreAssoluto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //Creare un programma che prenda
            //in input un valore intero
            //stampi a video il suo valore ASSOLUTO

            //ES    5  ---------> (VALORE ASSOLUTO) ----> 5
            //     -5  --------->   5

            //    -8   ----------------> 8 
            //     8 -------------------> 8 

            System.Console.WriteLine("Inserisci un numero");
            int numeroInputUtente = int.Parse(Console.ReadLine());

            if(numeroInputUtente > 0)
            {
                System.Console.WriteLine(numeroInputUtente);
                System.Console.WriteLine("adasdasda");
            }
            else
                System.Console.WriteLine(-numeroInputUtente);
            



        }
    }
}
