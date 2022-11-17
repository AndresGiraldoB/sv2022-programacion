// Repaso de figuras geométricas 6: 
// Triángulo decreciente a la derecha, 10 filas con 10, 9, 8  ... asteriscos

using System;

class AsteriscosTrianguloDecDerecha
{
    static void Main()
    {
        int asteriscos = 10;
        int espacios = 0;

        for (int fila = 1; fila <= 10; fila++)
        {
            for (int columnaEspacios = 1; columnaEspacios <= espacios; columnaEspacios++)
            {
                Console.Write(" ");
            }
            espacios++;

            for (int columnaAsteriscos = 1; columnaAsteriscos <= asteriscos; columnaAsteriscos++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            asteriscos--;
        }
    }
}

