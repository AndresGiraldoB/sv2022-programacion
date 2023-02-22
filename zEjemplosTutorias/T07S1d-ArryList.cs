/* Crea una versión alternativa del ejercicio 3, usando una lista: el usuario 
introducirá textos hasta que pulse Intro. Después deberás mostrarlos dos veces: 
primero en orden de introducción y luego en orden inverso.
*/

using System;
using System.Collections;

class PruebaDeLista1
{
    static void Main()
    {
        ArrayList textos = new ArrayList();
        string frase;
        do
        {
            frase = Console.ReadLine();
            if (frase != "")
                textos.Add(frase);
        }
        while (frase != "");

        // De principio a fin
        foreach(string s in textos)
            Console.WriteLine(s);

        // De fin a principio
        for (int i = textos.Count - 1  ; i >= 0; i--)
        {
            string dato = (string) textos[i];
            Console.WriteLine(dato);
        }
    }
}

