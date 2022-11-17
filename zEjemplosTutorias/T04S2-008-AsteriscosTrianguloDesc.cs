// Repaso de figuras geométricas 5: 
// Triángulo decreciente, 10 filas con 10, 9, 8  ... asteriscos

using System;

class AsteriscosTrianguloDec
{
    static void Main()
    {
        int asteriscos = 10;
        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columna = 1; columna <= asteriscos; columna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            asteriscos--;
        }
    }
}
