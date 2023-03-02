/* Pide palabras al usuario, y guárdalas 
 * (sin duplicados) en un Conjunto. Cuando 
 * pulse Intro para terminar, muestra todas 
 * las palabras.
*/

using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        string palabra;
        HashSet<string> conjunto = new HashSet<string>();
        conjunto.Add("adiós");

        do
        {
            palabra = Console.ReadLine();
            if (palabra != "")
                conjunto.Add(palabra);
        }
        while (palabra != "");

        foreach(string s in conjunto)
        {
            Console.WriteLine(s);
        }
    }
}

// 1
// 2
// 3
// 1
// 
// adiós
// 1
// 2
// 3
