using System;

class EjemploEjercicio95
{
    static bool EsPalindromo( string texto )
    {
        string textoInvertido = "";
        for (int i = texto.Length-1; i >= 0; i--)
        {
            textoInvertido += texto[i];
        }

        if (texto == textoInvertido)
            return true;
        else
            return false;
    }

    static void Main()
    {
        if (EsPalindromo("ada")) 
            Console.WriteLine("ada es palíndromo");
        else
            Console.WriteLine("ada no es palíndromo");

        if (EsPalindromo("anda"))
            Console.WriteLine("anda es palíndromo");
        else
            Console.WriteLine("anda no es palíndromo");
    }

}
