/* Recorre el Dictionary del ejercicio 4 
 * usando "foreach".
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
            Console.Write("Dime la palabra en castellano ", (i + 1), ": ");
            string cast = Console.ReadLine();
            Console.Write("Dime la palabra en valenciano ", (i + 1), ": ");
            string valenc = Console.ReadLine();

            //diccionario.Add(cast, valenc);
            diccionario[cast] = valenc;
        }
        
        if (diccionario.ContainsKey("adiós"))
            Console.WriteLine(diccionario["adiós"]);

        foreach (KeyValuePair<string, string> dato in diccionario)
        {
            Console.WriteLine("{0} = {1}",
               dato.Key, dato.Value);
        }
    }
}
