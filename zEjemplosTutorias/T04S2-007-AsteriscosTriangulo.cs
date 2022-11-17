// Repaso de figuras geométricas 4: 
// Triángulo, 10 filas con 1, 2, 3, ... asteriscos

using System;

class AsteriscosTriangulo
{
    static void Main()
    {
        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columna = 1; columna <= fila; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

