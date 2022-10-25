/* 40. Pide al usuario un número y respóndele cuántas cifras tiene. Lo 
puedes conseguir dividiendo entre 10 tantas veces como sea necesario, 
hasta que el número se convierta en 0.
*/

// Version 1: con do-while

using System;

class Ejercicio40
{
    static void Main()
    {
        int numero, cifras;

        Console.Write("¿Numero? ");
        numero = Convert.ToInt32(Console.ReadLine());
        cifras = 0;

        // 534
        // 53 cifras: 1
        // 5 cifras: 2
        // 0 cifras: 3

        do
        {
            numero = numero / 10;
            cifras++;
        }
        while (numero > 0);

        Console.WriteLine(cifras);


        
    }
}
