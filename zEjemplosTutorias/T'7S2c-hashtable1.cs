/* Crea un nueva versión del diccionario castellano-valenciano usando una HashTable.
 * En esta ocasión, para mostrar los datos, recorre el array de claves, así:

 foreach (string palabra in miDiccio.Keys)
    Console.WriteLine(palabra + " - " + miDiccio[palabra]);
*/

using System;
using System.Collections;

class Ejemplo
{
    static void Main()
    {
        Hashtable diccionario = new Hashtable();
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
            string valor = (string) diccionario[ palabra ];
            Console.WriteLine("{0} = {1}",
               palabra, valor);
        }
    }
}

// Dime la palabra en castellano 1
// Dime la palabra en valenciano 2
// Dime la palabra en castellano 3
// Dime la palabra en valenciano 4
// adeu
// 3 = 4
// 1 = 2
// casa = casa
// adiós = adeu
