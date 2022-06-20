using System;

namespace EserciziCicli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            */

            int index = 1;

            while( index <= 20 ){

                if(index >= 10)
                    System.Console.WriteLine("\t\t\t Il mattino ... ... ..");
                else 
                    System.Console.WriteLine("Il mattino ... ... ..");
                
                
                index++;
            }

            System.Console.WriteLine("Fine");

        }



    }
}
