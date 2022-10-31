/* Juan Manuel (...) */

/*
Ejercicio 55.Pide un número entero al usuario y calcula su raíz cuadrada
con una cifra decimal por aproximación, tanteando los valores que sea
necesario. Por ejemplo, si el usuario introduce 84, el resultado debería
ser 9,1, porque 9,1 al cuadrado es menor que 84, pero 9,2 al cuadrado es
mayor que 84.
*/

using System;

class Ejercicio55
{
    static void Main()
    {
        Console.Write(" Dame un número entero: ");
        int numeroEntero = Convert.ToInt32(Console.ReadLine());
        
        float contador = 1;
        while (numeroEntero > contador * contador)
        {
            contador += 0.1f;
        }

        contador -= 0.1f;

        Console.WriteLine(contador.ToString("#.#"));


    }
}
