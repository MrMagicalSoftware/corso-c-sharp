using System;

namespace stampaMaggioreStringa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //1-Prendere in input 2 stringhe
            //2-controllo sulle stringhe

            string parola1 = Console.ReadLine();
            string parola2 = Console.ReadLine();

            System.Console.WriteLine("\n\n\n");
           
            if(parola1.Length == parola2.Length){
                System.Console.WriteLine($"Hanno la stessa lunghezza {parola1} {parola2}");
            }
            else if(parola1.Length > parola2.Length){
                System.Console.WriteLine(parola1);
            }
            else
            {
                System.Console.WriteLine(parola2);
            }


            System.Console.WriteLine("Fine");

        }
    }
}
