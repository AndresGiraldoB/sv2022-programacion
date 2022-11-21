// Daniel (..)

/* 
79. Crea un programa que pida al usuario 10 números reales de doble precisión, 
los guarde en una matriz bidimensional de 2x5 datos, y luego muestre el promedio 
de los valores que hay guardados en la primera mitad de la matriz, luego el promedio 
de los valores en la segunda mitad de la matriz y finalmente el promedio global.
 */


using System;

class Ejercicios
{
    static void Main()
    {
        double[,] numeros = new double[2, 5];
        double totalPrimera = 0;
        double totalSegunda = 0;
        double totalGlobal = 0;

        Console.WriteLine("Escribe 10 números reales de doble precisión." +
            " (5 para la primera línea. 5 para la segunda.)");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                numeros[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (i == 0)
                    totalPrimera += numeros[i, j];

                if (i == 1)
                    totalSegunda += numeros[i, j];

                totalGlobal += numeros[i, j];
            }
        }

        Console.WriteLine("El promedio de la primera mitad es: {0}", totalPrimera/5);
        Console.WriteLine("El promedio de la segunda mitad es: {0}", totalSegunda/5);
        Console.WriteLine("El promedio global es: {0}", totalGlobal/10);
    }
}
