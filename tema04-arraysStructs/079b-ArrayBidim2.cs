/*79. Crea un programa que pida al usuario 10 números reales de doble precisión,
 * los guarde en una matriz bidimensional de 2x5 datos,
 * y luego muestre el promedio de los valores que hay guardados en la primera mitad de la matriz, 
 * luego el promedio de los valores en la segunda mitad de la matriz
 * y finalmente el promedio global.*/
 
//Noelia (...)

using System;

class Ejercicio79
{
    static void Main()
    {
        double[,] numeros = new double[2, 5];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Escribe un número ({0}, {1}): ", i+1, j+1);
                numeros[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        for (int i = 0; i < numeros.GetLength(0); i++)
        {
            double suma = 0;
            for (int j = 0; j < numeros.GetLength(1); j++)
            {
                suma += numeros[i, j];

            }
            Console.WriteLine("El promedio de la mitad " + (i+1) +
                " de la matriz es " + suma / numeros.GetLength(1));
        }
        
        double sumaTotal = 0;
        foreach (float f in numeros)
        {
            sumaTotal += f;
        }
        Console.WriteLine("El promedio global es {0}", sumaTotal / numeros.Length);
    }

}

