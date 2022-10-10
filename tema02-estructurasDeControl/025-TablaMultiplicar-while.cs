/* Juan Manuel (...) */

/* Ejercicio 25.Escribe un programa en C# que pida al usuario un número
 * entero y muestre su tabla de multiplicar, usando "while". */


using System;

class Ejercicio25
{
    static void Main()
    {
        int numero, contador = 0;
        Console.Write(" Dame un número y te daré su tabla de multiplicar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (contador <= 10)
        {
            Console.WriteLine(" {0} x {1} = {2}", 
                numero, contador, numero * contador);
            contador++;
        }
    }
}

