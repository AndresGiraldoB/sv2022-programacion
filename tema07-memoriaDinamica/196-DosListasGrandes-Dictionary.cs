/*195. Crea una tercera versión del ejercicio de words.txt y
 * words2.txt, que vuelque el contenido de los ficheros a dos
 * tablas hash o bien a dos Dictionary<string,lo_que_tu_quieras>
 * antes de contar la cantidad de palabras coincidentes.
 */

// Nota: tiempo empleado en i7 8565u: 00m 00.07seg

using System;
using System.Collections.Generic;
using System.IO;

class Ejercicio195
{
    static void Main()
    {
        Dictionary<string,string> palabras1 = new Dictionary<string, string>();
        Dictionary<string,string> palabras2 = new Dictionary<string, string>();

        Console.WriteLine("Leyendo ficheros...");
        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");

        Console.WriteLine("Volcando a Dictionary...");
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

