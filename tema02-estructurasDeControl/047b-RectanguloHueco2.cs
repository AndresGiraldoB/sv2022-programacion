/* Juan Manuel (...) */

/*
Ejercicio 47.Muestra un rectángulo hueco, con el ancho y el alto que elija
el usuario, y usando como símbolo el número que escoja el usuario,
como en este ejemplo:

Ancho ? 5
Alto ? 3
Número ? 1
11111
1   1
11111
*/


using System;

class Ejercicio47
{
    static void Main()
    {
        Console.Write(" Ancho ? ");
        int ancho = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Alto ? ");
        int alto = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Número ? ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        // primera fila
        for (int columna = 1; columna <= ancho; columna++)
        {
            Console.Write(numero);
        }
        Console.WriteLine();

        // las filas centrales
        for (int fila = 1; fila <= alto - 2; fila++)
        {
            Console.Write(numero);
            for (int columna = 1; columna <= ancho - 2; columna++)
            {
                Console.Write(" ");
            }
            Console.Write(numero);
            Console.WriteLine();
        }

        // última fila
        for (int columna = 1; columna <= ancho; columna++)
        {
            Console.Write(numero);
        }
        Console.WriteLine();

    }
}

