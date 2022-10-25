/* 40. Pide al usuario un número y respóndele cuántas cifras tiene. Lo 
puedes conseguir dividiendo entre 10 tantas veces como sea necesario, 
hasta que el número se convierta en 0.
 */

// Version 2: con while (contando desde cifras = 1)

using System;

class Ejercicio40
{
    static void Main()
    {
        int numero = 345;
        int cifras = 1;

        while (numero > 10)
        {
            numero = numero / 10;
            cifras ++;
        }

        Console.WriteLine(cifras);
    }
}

