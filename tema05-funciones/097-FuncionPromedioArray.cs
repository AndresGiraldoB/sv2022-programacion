/*HÉCTOR (...)
97. Crea una función llamada "Promedio", que devolverá el promedio de los elementos 
de un array de enteros que se pasará como parámetro. Pruébala con un array prefijado. 
La función deberá aparecer antes de "Main".*/

using System;

class Ejercicio097
{
    static float Promedio(int[] numeros)
    {
        float sumaNumeros = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            sumaNumeros+= numeros[i];
        }

        float promedio = sumaNumeros / numeros.Length;

        return promedio;
    }
    
    static void Main()
    {
        int [] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("{0}", Promedio(numeros));
    }
}
