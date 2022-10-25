/* HÉCTOR (...)
 * 48. Depuración Crea un programa que muestre ciertos valores de la función y = x^2 - 4x + 4 
 * (probando x con valores desde -5 hasta +5, avanzando de 1 en 1). 
 * Añade un punto de interrupción en el momento en que calculas el valor de y, 
 * y comprueba cuáles son en ese momento los valores de x^2 y de 4x. */

using System;

class Ejercicio_048
{
    static void Main()
    {
        int x, y;


        for (x = -5; x <= 5; x++)
        {
            y = x * x - 4 * x + 4; ;

            Console.WriteLine(" x^2 = {0}", x * x);
            Console.WriteLine(" 4x = {0}", 4 * x);
        }
    }
}
