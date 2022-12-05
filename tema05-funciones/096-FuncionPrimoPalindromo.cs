// Juan Manuel (...)

/*
96.Crea una función booleana llamada "EsPalindromoPrimo", que devolverá "true"
si el parámetro, un número entero largo, es un número primo que también es
palíndromo, o "false" en caso contrario. En vez de que esta función tenga toda
la carga lógica, apóyate en las funciones "EsPrimo" y "EsPalindromo" que has 
creado anteriormente. El "Main" de prueba deberá mostrar los números
palíndromos primos que hay entre 500 y 1000.
*/


using System;

class Ejercicio96
{

    static bool EsPalindromo(string cadena)
    {
        bool palindroma = true;
        int posicion = 0;
        do
        {
            if (cadena[posicion] != cadena[cadena.Length - 1 - posicion])
            {
                palindroma = false;
            }
            posicion++;
        }
        while (palindroma && posicion < cadena.Length);

        return palindroma;
    }

    static bool EsPrimo(long numero)
    {
        
        int contadorPrimo = 1;
        int divisores = 0;

        do 
        {
            if (numero % contadorPrimo == 0)
            {
                divisores++;
            }
            contadorPrimo++;
        }
        while (contadorPrimo <= numero);

        return divisores == 2;
    }

    static bool EsPalindromoPrimo(long numero)
    {
        bool palindromoPrimo = false;

        if (EsPalindromo(Convert.ToString(numero)) && EsPrimo(numero))
        {
            palindromoPrimo = true;
        }
        return palindromoPrimo;
    }

    static void Main()
    {
        const long MINIMO = 500, MAXIMO = 1000;
        

        Console.Write("Primos palíndromos entre 500 y 1000: ");
        for (long numero = MINIMO; numero <= MAXIMO; numero++)
        {
            if (EsPalindromoPrimo(numero))
            {
                Console.Write(numero + " ");
            }
        }
    }
}

