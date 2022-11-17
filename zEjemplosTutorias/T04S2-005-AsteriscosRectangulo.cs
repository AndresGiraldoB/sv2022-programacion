// Repaso de figuras geométricas 2: 
// Rectángulo, 5 filas de 20 asteriscos cada una

using System;

class AsteriscosRectangulo
{
    static void Main()
    {
        for (int fila = 1; fila <= 5; fila++)
        {
            for (int columna = 1; columna < 20; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

