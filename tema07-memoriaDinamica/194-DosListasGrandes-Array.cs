/*194. Como ya descubriste en el ejercicio 190, y como verás con más detalle
 * en el tema 8, una forma rápida de leer todo el contenido de un fichero de
 * texto es emplear "string[] lineas = File.ReadAllLines("nombreDeFichero.ext");"
 * (necesitarás añadir también "using System.IO;"). Crea un programa que lea
 * el contenido del fichero words.txt (cerca de 355.000 palabras, que tienes
 * compartido en Aules comprimido, como fichero words.zip) y el contenido del
 * fichero words2.txt (cerca de 235.000 palabras, que tienes compartido
 * en Aules comprimido, como fichero words2.zip). Deberá mostrar en pantalla
 * la cantidad de palabras que aparecen a la vez en ambos ficheros.
 * Esta primera versión trabajará directamente con los datos de los
 * arrays que obtienes al leer ambos ficheros. Si tienes curiosidad
 * por medir el tiempo que tarda, puedes emplear esta estructura:


DateTime comienzo = DateTime.Now;

// Aquí va lo que se quiere medir

Console.WriteLine("Tiempo transcurrido: "+  (DateTime.Now-comienzo));

 Radha*/

// Nota: tiempo empleado en i7 8565u: 09m 44.72seg

using System;
using System.IO;

class Ejercicio194
{
    static void Main()
    {
		Console.WriteLine("Leyendo ficheros...");
        string[] words = File.ReadAllLines("words.txt");
        string[] words2 = File.ReadAllLines("words2.txt");
        
        Console.WriteLine("Comparando y midiendo tiempos...");
        DateTime comienzo = DateTime.Now;

        int contador = 0;
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j < words2.Length; j++)
            {
                if (words[i] == words2[j])
                {
                    contador++;
                }
            }
        }
        Console.WriteLine("Tiempo transcurrido: " + (DateTime.Now - comienzo));
        Console.WriteLine("Palabras en ambos ficheros: " + contador);
    }
}

