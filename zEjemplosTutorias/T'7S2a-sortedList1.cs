/* Crea un diccionario castellano-valenciano usando una SortedList. 
 * Añade dos palabras prefijadas y pide otras dos (con su traducción).
 * Luego muestra una de las prefijadas, y después todas ellas usando 
 * un esqueleto como éste:

 for (int i = 0; i < miDiccio.Count; i++)
     Console.WriteLine("{0} = {1}",
        miDiccio.GetKey(i),  miDiccio[ miDiccio.GetKey(i) ]);
*/

using System;
using System.Collections;

class Ejemplo
{
    static void Main()
    {
        SortedList diccionario = new SortedList();
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
            string clave = (string) diccionario.GetKey(i);
            string valor = (string) diccionario[ clave ];
            Console.WriteLine("{0} = {1}",
               clave, valor);
        }
    }
}

// Dime la palabra en castellano 1
// Dime la palabra en valenciano 2
// Dime la palabra en castellano 3
// Dime la palabra en valenciano 4
// adeu
// 1 = 2
// 3 = 4
// adiós = adeu
// casa = casa

