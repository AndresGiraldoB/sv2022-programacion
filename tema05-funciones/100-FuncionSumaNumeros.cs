// Daniel (...)

/* 
100. Crea una función llamada "SumaDeNumeros", que reciba una cadena formada 
por números enteros largos y espacios intermedios, quizá redundantes, 
como "23 45  67 89 " y devuelva la suma de esos números (en este caso, 224). 
Pruébala desde Main, con una cadena prefijada.
*/

using System;

class Ejercicio100
{
    static void Main()
    {
        string textoNumeros = " 23 45      67 89";

        Console.WriteLine(SumaDeNumeros(textoNumeros));
    }

    static int SumaDeNumeros(string textoNumeros)
    {
        int suma = 0;

        while (textoNumeros.Contains("  "))
        {
            textoNumeros = textoNumeros.Replace("  ", " ");
        }

        string[] trozosNumeros = textoNumeros.Trim().Split();

        for (int i = 0; i < trozosNumeros.Length; i++)
        {
            suma += Convert.ToInt32(trozosNumeros[i]);
        }

        return suma;
    }
}
