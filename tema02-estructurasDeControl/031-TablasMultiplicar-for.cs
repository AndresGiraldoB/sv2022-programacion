// Daniel (...)
using System;

// 31. Muestra las tablas de multiplicar de los números del 0 al 10,
// utilizando "for". Debe haber una línea en blanco separando cada tabla de
// multiplicar de la siguiente.

class Ejercicio
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
            Console.WriteLine();
        }
    }
}
