// Ej 97

using System;

class EjemploEjercicio97
{
    static void Main()
    {
        int[] numeros = { 3, 5, 7 };
        Console.WriteLine( Promedio(numeros) );
    }

    static double Promedio(int[] datos )
    {
        int suma = 0;
        foreach (int d in datos)
        {
            suma += d;
        }
        return (double) suma / datos.Length;
        
        // Recuerda: la división de 2 enteros es un número entero
        // (sin decimales); al menos uno de los datos debe ser real
    }
}
