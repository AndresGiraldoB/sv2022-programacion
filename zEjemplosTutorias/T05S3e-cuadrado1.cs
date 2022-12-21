// Ejemplo de parámetros con valor por defecto

using System;

class Cuadrado
{
    static void DibujarCuadrado(int lado, char caracter='@')
    {
        for (int fila = 0; fila < lado; fila++)
        {
            for (int columna = 0; columna < lado; columna++)
            {
                Console.Write(caracter);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        DibujarCuadrado(8, 'M');
        Console.WriteLine();

        DibujarCuadrado(6);
    }
}
