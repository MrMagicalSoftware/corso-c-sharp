using System;

namespace compresoTra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci 3 numeri");

            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            
            //  numero1<= numero2 <= numero3

            if(numero1<= numero2)
            {
                if(numero2 <= numero3)
                    System.Console.WriteLine("Ok numero compreso");
            }

            // && ----------> AND

            // ESPRESSIONE1  && EXP2  && EXP3 && EXP4 .... ...

            // &         && ---> Lazy evaluation (valutazione pigra)


            /*
                if(1 >= 10  &  10 > 1  & 2 >=2  & fuoriPiove)

                    False & True & True & True

            */


            /*

                if(isEngineOk  & isBreakOk & isLuciOk  )

            */





            if(numero1<= numero2 && numero2 <= 3){
                System.Console.WriteLine("ok");
            }
            else
                System.Console.WriteLine("no");


            // OR ------->
            //l'EXPRESS E' VERA SE ALMENO UNA CONDIZIONE E' VERA

            // CONDIZIONE1 || CONDIZIONE2 || CONDIZIONE3 || CONDIZIONE4 .... ....
            //   T     ||   F  || F ||  

            //      !(1 == 1)  ========>    !  ( TRUE) ==> FALSE

            

        }
    }
}
