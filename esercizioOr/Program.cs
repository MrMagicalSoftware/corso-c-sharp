using System;

/*
Esecizio : Creare app che stampi a video 
si se il numero è maggiore di 10 oppure il numero è minore di 5
10 11 12 ... si
5 4 3  2 si
6 7 8 9 no
*/


namespace esercizioOr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto inserisci un numero");
            int numero = int.Parse(Console.ReadLine());

            if(   (numero >= 10 || numero <= 5 )  )
                System.Console.WriteLine("si");
            else
                System.Console.WriteLine("no");

        }
    }
}
