/* 
 * Programa que pregunta al usuario una palabra y muestra las vocales 
 * (sin acentuar) que contenga.
 * 
 * Autor: Igor (...)
*/

using System;

class Ej59
{
    static void Main()
    {
        string palabra;

        Console.Write("Introduce una palabra: ");
        palabra = Console.ReadLine();

        foreach (char letra in palabra)
            if (letra == 'a' || letra == 'e' || letra == 'i' 
                    || letra == 'o' || letra == 'u')
                Console.Write(letra);
    }
}

