/* Crea una versión alternativa del ejercicio 4, usando una lista con tipo 
(string): el usuario introducirá textos hasta que pulse Intro. Después deberás 
mostrarlos dos veces: primero en orden de introducción y luego en orden 
inverso.
*/

using System;
using System.Collections.Generic;

class PruebaDeLista2
{
    static void Main()
    {
        List<string> textos = new List<string>();
        string frase;
        do
        {
            frase = Console.ReadLine();
            if (frase != "")
                textos.Add(frase);
        }
        while (frase != "");

        // De principio a fin
        foreach (string s in textos)
            Console.WriteLine(s);

        // De fin a principio
        for (int i = textos.Count - 1; i >= 0; i--)
        {
            string dato = textos[i];
            Console.WriteLine(dato);
        }
    }
}

