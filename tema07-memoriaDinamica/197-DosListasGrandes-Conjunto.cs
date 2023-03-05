/*197. En realidad, no necesitamos una clave y un valor para las palabras
 * de los 3 ejercicios anteriores. Haz una nueva versión que emplee dos conjuntos.

 Radha, retoques por Nacho */

// Nota: tiempo empleado en i7 8565u: 00m 00.08seg

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Ejercicio196
{
    static void Main()
    {
        HashSet<string> palabras1 = new HashSet<string>();
        HashSet<string> palabras2 = new HashSet<string>();

        Console.WriteLine("Leyendo ficheros...");
        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Volcando a Conjunto...");
        for (int i = 0; i< words.Length; i++)
        {
            if (!palabras1.Contains(words[i]))
            {
                palabras1.Add(words[i]);
            }           
        }        
        
        for(int i = 0; i< words2.Length; i++)
        {
            if (!palabras2.Contains(words2[i]))
            {
                palabras2.Add(words2[i]);
            }
        }

        Console.WriteLine("Comparando y midiendo tiempos...");
        int contador = 0;
        DateTime comienzo = DateTime.Now;
        foreach (string s in palabras1)
        {
            if (palabras2.Contains(s))
			{
				contador++;
			}
        }
        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Palabras en ambos ficheros: " + contador);
    }
}

