// Ejemplo de contacto con la recursividad
// Función "Potencia": versión iterativa y versión recursiva
using System;

class PruebaRecursividad1
{
    static int Potencia(int numero, int exponente)
    {
        // 3 ^ 4 = 3 * 3 * 3 * 3
        // 3 ^ 5 = 3 * 3 * 3 * 3 * 3

        int resultado = 1;

        for (int i = 1; i <= exponente; i++)
        {
            resultado *= numero;
        }

        return resultado;
    }

    static int PotenciaR(int numero, int exponente)
    {
        // Caso base
        if (exponente == 0)
            return 1;

        // Caso general (solución de n a partir de la de n-1)
        return numero * PotenciaR(numero, exponente - 1);
    }

    static void Main()
    {
        Console.WriteLine( Potencia(2, 5) );
        Console.WriteLine( PotenciaR(2, 5) );

        // Ejemplo de cómo se comporta la llamada recursiva:

        // 2 ^ 5
        // 2 * 2 ^ 4
        // 2 * ( 2 * 2 ^3 )
        // 2 * ( 2 * ( 2 * 2^2 ))
        // 2 * ( 2 * ( 2 * (2 * 2^1 )))
        // 2 * ( 2 * ( 2 * (2 * (2 * 2^0 ))))

        // 2 * ( 2 * ( 2 * (2 * (2 * 1 ))))
        // 2 * ( 2 * ( 2 * (2 * 2 )))
        // 2 * ( 2 * ( 2 * 4))
        // 2 * ( 2 * 8)
        // 2 * 16
        // 32
    }
}

