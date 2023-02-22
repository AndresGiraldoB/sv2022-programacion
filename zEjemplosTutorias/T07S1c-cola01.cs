/* Crea una versión alternativa del ejercicio 2, usando una cola (los datos 
aparecerán en el mismo orden en que se introdujeron).
*/

using System;
using System.Collections.Generic;

class PruebaDeCola
{
    static void Main()
    {
        Queue<string> colaTextos = new Queue<string>();
        string frase;
        do
        {
            frase = Console.ReadLine();
            if (frase != "")
                colaTextos.Enqueue(frase);
        }
        while (frase != "");

        while (colaTextos.Count > 0)
        {
            string dato = colaTextos.Dequeue();
            Console.WriteLine(dato);
        }
    }
}

