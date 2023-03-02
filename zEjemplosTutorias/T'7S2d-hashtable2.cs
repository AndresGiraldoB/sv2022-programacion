/* Crea una variante del ejercicio anterior 
 * usando Dictionary<string, string>:
*/

using System;
using System.Collections.Generic;

class Ejemplo
{
    static void Main()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
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

        foreach (string palabra in diccionario.Keys)
        {
            string valor = diccionario[ palabra ];
            Console.WriteLine("{0} = {1}",
               palabra, valor);
        }
    }
}
