/*195. Crea una segunda versión del ejercicio anterior (words.txt y words2.txt),
 * que vuelque el contenido de los ficheros a dos SortedList 
 * (puedes usar cada palabra como clave del diccionario y también como valor) 
 * antes de contar la cantidad de palabras coincidentes.
 
 Radha, retoques por Nacho */

// Nota: tiempo empleado en i7 8565u: 00m 1.04seg

using System;
using System.Collections.Generic;
using System.IO;

class Ejercicio195
{
    static void Main()
    {
        SortedList<string,string> palabras1 = new SortedList<string, string>();
        SortedList<string,string> palabras2 = new SortedList<string, string>();

        Console.WriteLine("Leyendo ficheros...");
        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");


        Console.WriteLine("Volcando a SortedList...");
        for (int i = 0; i< words.Length; i++)
        {
            if (!palabras1.ContainsKey(words[i]))
            {
                palabras1.Add(words[i], words[i]);
            }
        }        
        
        for(int i = 0; i< words2.Length; i++)
        {
            if (!palabras2.ContainsKey(words2[i]))
            {
                palabras2.Add(words2[i], words2[i]);
            }
        }

        Console.WriteLine("Comparando y midiendo tiempos...");
        int contador = 0;
        DateTime comienzo = DateTime.Now;
        foreach (string s in palabras1.Keys)
        {
            if (palabras2.ContainsKey(s))
			{
				contador++;
			}
        }
        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Palabras en ambos ficheros: " + contador);
    }
}

