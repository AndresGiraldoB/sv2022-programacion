/* Juan Manuel (...) */

/*
78.Crea un programa que pida al usuario un número entero positivo y muestre su
equivalente en forma binaria, usando un array como paso intermedio para guardar
los resultados temporales. Supondremos que el número cabe en 8 bits (un byte).

El algoritmo es el siguiente: divide el número entre 2 tantas veces como sea
posible hasta que el número se convierta en uno, y toma todos los restos en
orden inverso:

35: 2 = 17, resto 1
17: 2 = 8, resto 1
8: 2 = 4, resto 0
4: 2 = 2, resto 0
2: 2 = 1, resto 0
1, terminado
por lo que el número sería 00100011 (o 100011, sin los 0 iniciales).
Puedes usar ".ToString" para verificar que tu algoritmo funciona bien,
pero no como único método de resolución.
*/

using System;

class Ejercicio78
{
    static void Main()
    {
        byte[] resultadosTemporales = { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte contador = 0;

        Console.Write(" Dame un número entre 0 - 255 y te dire su valor en binario: ");
        byte numero = Convert.ToByte(Console.ReadLine());
        byte numeroAux = numero;

        do
        {
            resultadosTemporales[contador] = (byte)(numeroAux % 2);
            numeroAux /= 2;
            contador++;

        } while (numeroAux > 0);

        Console.Write(" El numero decimal " + numero + " en binario es ");

        for (int i = resultadosTemporales.Length - 1; i >= 0; i--)
        {
            Console.Write(resultadosTemporales[i]);
        }
        Console.WriteLine();
    }
}

