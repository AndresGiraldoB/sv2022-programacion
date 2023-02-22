/*
Pide al usuario textos, que guardarás en una pila, hasta que teclee Intro sin 
introducir ningún texto.

En ese momento, extrae todo el contenido de la pila y muéstralo (aparecerá en 
orden inverso).
*/

using System;
using System.Collections;

class PruebaDePila1
{
    static void Main()
    {
        Stack pilaTextos = new Stack();
        string frase;
        do
        {
            frase = Console.ReadLine();
            if (frase != "")
                pilaTextos.Push(frase);
        }
        while (frase != "");

        while(pilaTextos.Count > 0)
        {
            string dato = (string) pilaTextos.Pop();
            Console.WriteLine(dato);
        }

        // Error frecuente:
        // for (int i = 0; i < pilaTextos.Count; i++)
        // {
        //     Console.WriteLine(pilaTextos.Pop());
        // }
    }
}

