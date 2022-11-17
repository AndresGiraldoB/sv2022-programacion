// Repaso de figuras geométricas 3: 
// Cuadrado, 10 filas de 10 asteriscos cada una

using System;

class AsteriscosCuadrado
{
    static void Main()
    {
        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columna = 1; columna < 10; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
