/* 
 * 95. Crea una función booleana llamada "EsPalindromo", que devolverá true si el parámetro (una cadena de texto)
 * es una palabra palíndroma (que se lee igual de izquierda a derecha que de derecha a izquierda), o falso en caso
 * contrario. Desde Main, pide al usuario un texto y responde si es palíndromo.
 * 
 * Autor: Igor (...)
*/

using System;

class Ej95
{
    static bool EsPalindromo(string p)
    {
        int cont = 0;
        bool loEs = true;
        for (int i = p.Length - 1; i >= 0; i--, cont++)
            if (p[i] != p[cont])
            {
                loEs = false;
            }
        if (loEs)
            return true;
        else
            return false;
    }

    static void Main()
    {
        string palabra;

        try
        {
            Console.Write("Introduce una palabra: ");
            palabra = Console.ReadLine();
                if (EsPalindromo(palabra))
                    Console.WriteLine("\"{0}\" es un palíndromo.", palabra);
                else
                    Console.WriteLine("\"{0}\" NO es un palíndromo.", palabra);
        }
        catch (Exception errorEncontrado)
        {
            Console.WriteLine("\a\nERROR FATAL: {0}", errorEncontrado.Message);
        }
    }
}

