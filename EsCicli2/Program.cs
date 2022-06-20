using System;

namespace EsCicli2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            int index = 2;
            while(index <= 100){

                if(index % 2 ==  0)
                    System.Console.WriteLine(index);

                index++;
            }
            */


            /*
            int index = 2;
            while(index <= 100){
                System.Console.WriteLine(index);
                index +=2 ;     // index = index + 2
            }
            */

            /*
            int index = 0;
            while(index <= 10){
                System.Console.WriteLine($"2 * {index} ====> {index * 2}");
                index++;
            }*/


            // 10  ----> 1 + 2 + 3 ...... 10

            int numeroUtente = int.Parse(Console.ReadLine());
            int somma = 0 ;

            int index = 1;
            while(index <= numeroUtente){      
                somma = somma + index;  //somma +=index
                index++;
            }
            
            // 1 <= 3
            // somma = 0 + 1

            // 2 <= 3
            // somma = 1+ 2

            // 3 <= 3
            // somma = 3 + 3

            // 4 <= 3 FALSE

            System.Console.WriteLine($"Sommatoria vale {somma}");

            //     10
            // 1 + 2 + 3 + ....... 10

        }
    }
}
