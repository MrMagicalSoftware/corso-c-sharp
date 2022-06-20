using System;

namespace esercizioRipasso
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Creare un semplice programma
            //che prenda in input una stringa
            //con il vostro nome e la stampi a video
            //usando $

            System.Console.WriteLine("Ciao a tutti e benvenuti alla seconda lezione");
            
            System.Console.WriteLine("Scrivi il tuo nome");
            //Devo creare una variabile di tipo stringa
            string myName =  Console.ReadLine();
            System.Console.WriteLine($"Ciao e benvenuto {myName}");



        }
    }
}
