/* Crea una variante del ejercicio anterior 
 * usando SortedList<string, string>

*/

using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        SortedList<string, string> diccionario = new SortedList<string, string>();
        diccionario.Add("adiós", "adeu");
        diccionario["casa"] = "casa";

        for (int i = 0; i < 2; i++)
        {
            Console.Write("Dime la palabra en castellano ", (i+1), ": ");
            string cast = Console.ReadLine();
            Console.Write("Dime la palabra en valenciano ", (i + 1), ": ");
            string valenc = Console.ReadLine();

            //diccionario.Add(cast, valenc);
            diccionario[cast] = valenc;
        }

        Console.WriteLine(diccionario["adiós"]);

        for (int i = 0; i < diccionario.Count; i++)
        {
            string clave = diccionario.Keys[i];
            string valor = diccionario[ clave ];
            Console.WriteLine("{0} = {1}",
               clave, valor);
        }
    }
}
