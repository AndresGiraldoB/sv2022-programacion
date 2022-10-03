/* Juan Manuel (...) 1º DAM Semipresencial */

/* Ejercicio 15.Crea una variante del ejercicio anterior, que emplee
 * "switch" en vez de "if". Al igual que en aquella ocasión, debes agrupar
 * los casos en la medida de lo posible.*/

using System;

class Ejercicio15
{
    static void Main()
    {
        Console.Write(" Deme el número del mes y le dire cuantos días tiene : ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine(" 31 días");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine(" 30 días");
                break;
            case 2:
                Console.WriteLine(" 28 diás");
                break;
            default:
                Console.WriteLine(" No conozco el mes {0}.",mes);
                break;
        }
    }
}
