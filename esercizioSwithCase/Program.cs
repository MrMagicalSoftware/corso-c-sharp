using System;

/**

    Programma che prende in input un numero
    e ritorna il corrispondente mese
    nota : 1 -12

**/


namespace esercizioSwithCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INSERISCI VALORE");
            int valore = int.Parse(Console.ReadLine());


            switch(valore){
                
                case 12 :      // if(valore == 12)
                    System.Console.WriteLine("dicembre");
                    System.Console.WriteLine("Buon natale");
                    break;
                case 1 :
                    System.Console.WriteLine("Genna");
                    break;
                case 2 :
                    System.Console.WriteLine("Febb");
                    break;
                case 3 :
                    System.Console.WriteLine("Marzo");
                    break;

                default:
                    System.Console.WriteLine("Nessun valore");
                    break;
            }


            /*
            if(valore > 12 || valore < 1)
                System.Console.WriteLine("Non trovata alcuna corrispondenza");
            else{

                if(valore == 1)
                    System.Console.WriteLine("Gennaio");
                else if(valore == 2)
                    System.Console.WriteLine("febb");
                else if(valore == 3)
                    System.Console.WriteLine("marzo");
                else if(valore == 4)
                    System.Console.WriteLine("aprile");
            }
            */



        }
    }
}
