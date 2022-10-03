/* Radha (...)
 *
 * 11. Crea un programa en C# que pida al usuario un número entero
 * y responda si es un número positivo, negativo o cero.
 * En esta segunda versión debes emplear "else". */

using System;

class Ejercicio11
{
    static void Main()
    {
        int numero;

        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32 ( Console.ReadLine () );

        if ( numero > 0)
        {
            Console.WriteLine("Es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Es negativo");
        }
        else
        {
            Console.WriteLine("Es cero");
        }

        /* Considero que esta versión es más eficiente que la anterior ya que
         * valora todos los casos dentro de un mismo condicional, procesándola
         * más rápidamente que si analizase un if tras otro */
    }
}
