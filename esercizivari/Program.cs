using System;

namespace esercizivari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Creare un programma che  faccia la conversione di minuti in secondi
            //1 --->. 60 sec

            System.Console.WriteLine("Inserisci numero di minuti");
            int minuti = int.Parse( Console.ReadLine()  );
            int secondi = minuti * 60;
            System.Console.WriteLine($" min  : {minuti}  ==   sec {secondi}");


            /*
            Secondo Esercizio : costruire un programma che stamapa true o false . 
            true se il numero è inferiore o uguale a 100 , altrimenti false.

            */

            int numeroUtente = int.Parse(Console.ReadLine() );
            if(numeroUtente <= 100){
                System.Console.WriteLine(true);
            }
            else
            {
                System.Console.WriteLine(false);
            }

            System.Console.WriteLine(numeroUtente <= 100);

            
            //Esercizio 3 :
            //Esercizio 3 . Costruire un programma che calcoli l'area di un triangolo 

            System.Console.WriteLine("Programma che calcola area triangolo");
            System.Console.WriteLine("Inserisci base e altezza");

            int baseUtente = int.Parse(Console.ReadLine());
            int altezzaUtente = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Area totale " + (baseUtente * altezzaUtente)  / 2 );



            


        }
    }
}
