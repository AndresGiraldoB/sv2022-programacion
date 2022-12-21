// Ejemplo de parámetros en orden distinto al de definicion

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
        DibujarCuadrado(caracter: '=', lado:5); 
    }
}
