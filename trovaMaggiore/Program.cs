using System;

namespace trovaMaggiore
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            //1 -prendi in input 2 numeri
            System.Console.WriteLine("Ciao Inserisci 2 numeri");
            int numero1 = int.Parse(  Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            // 10  > 10 ? False
            if(numero1 > numero2){
                System.Console.WriteLine("Numero piu' grande " + numero1);
            }
            else
            {
                System.Console.WriteLine("numero piu' grande " + numero2);
            }
            */

                    // OPERATORE DI RESTO     % (MODULO)

            // + - / *

            //L'operatore di resto di restitusce il resto della divisione tra due numeri

            //System.Console.WriteLine(     (10  % 2 )               );
            //QUANTO VALE IL RESTO 10 / 2 ?? ------> 0

            // 10 : 2 = 5 RESTO 0

            //Determinare se un numero se è pari  ?

            // numero % 2 == 0

      
            //Creare un programma
            //che prenda in input 2 
            // numeri e stampi a video
            // se la loro somma è un numero multiplo di 5


            /*
            System.Console.WriteLine("Dammi 2 numeri");
            int numero1 = int.Parse(  Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            if( (numero1 + numero2) % 5 == 0  )
            {
                System.Console.WriteLine("OK LA SOMMA E' UN MULTIPLO di 5 E VALE" +  (numero1 + numero2));
            }
            else
            {
                System.Console.WriteLine("No");
            }
            */


            //Prendere in input 3 numeri
            //calcolare la loro media...
            //   (10 + 2 + 4)    / 3

            //Prossimo esercizio calcolare la media di 3 numeri

            System.Console.WriteLine("Dammi 3 numeri in input");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());
        
            double media = (numero1 + numero2 + numero3) / 3;  //  (10 +2 + 4 )  / 3 --> 5.xxxxx

            System.Console.WriteLine($"La Media finale vale {media}  !!  ");
            
            System.Console.WriteLine("La Media finale vale " + media + " !!  " );



            //Virgola mobile
            //double float decimal


        }
    }
}
