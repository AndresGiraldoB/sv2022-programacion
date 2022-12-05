// Noelia (...)

/* 95. Crea una función booleana llamada "EsPalindromo", que devolverá true si 
el parámetro (una cadena de texto) es una palabra palíndroma (que se lee igual 
de izquierda a derecha que de derecha a izquierda), o falso en caso contrario. 
Desde Main, pide al usuario un texto y responde si es palíndromo.*/


using System;

class Ejercicio95
{
    static bool EsPalindromo(string texto)
    {
        bool palindromo = false;
        string textoReves = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            char letra = texto[i];
            textoReves += letra;
        }
        if (texto == textoReves)
            palindromo = true;

        return palindromo;
    }

    static void Main()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine();

        if (EsPalindromo(texto))
        Console.WriteLine("Es palíndromo.");
        
        else
        Console.WriteLine("No es palíndromo.");
    }

}

