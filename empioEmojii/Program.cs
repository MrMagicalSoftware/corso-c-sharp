using System;

namespace empioEmojii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //char example = '\u0062';

            //NUOVO TIPO DI VARIABILE CHAR
            //CHAR ---> SINGOLO CARATTERE

            //Differenza singoli apici vs doppi apici ..

            char lettera = 'r';
            char lettera1 = 'o';

            char example = '\u0062';
            //char exampleMo ='\u1F60A';
         
            //char e = 😀;  TO DO FIX IT!!

            System.Console.WriteLine(example);
            //System.Console.WriteLine(exampleMo);

            System.Console.WriteLine( (char) 255);


            string s = "\u1F600";
            System.Console.WriteLine(s);


ì
        }
    }
}
