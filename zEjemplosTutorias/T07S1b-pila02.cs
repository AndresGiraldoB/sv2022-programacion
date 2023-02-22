/* Crea una versión alternativa del ejercicio anterior, usando Generics:

Pide al usuario textos, que guardarás en una pila de "string", hasta que teclee 
Intro sin introducir ningún texto.

En ese momento, extrae todo el contenido de la pila y muéstralo (aparecerá en 
orden inverso).

*/
using System;
using System.Collections.Generic;

class PruebaDePila2
{
    static void Main()
    {
        Stack<string> pilaTextos = new Stack<string>();
        string frase;
        do
        {
            frase = Console.ReadLine();
            if (frase != "")
                pilaTextos.Push(frase);
        }
        while (frase != "");

        while (pilaTextos.Count > 0)
        {
            string dato = pilaTextos.Pop();
            Console.WriteLine(dato);
        }
    }
}

