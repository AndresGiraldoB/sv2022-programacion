/*116. Crea una función ContarMm que obtenga la cantidad de letras mayúsculas (
 * en el rango A-Z) y letras minúsculas (en el rango a-z) que hay en la cadena 
 * que se pasa como parámetro (sin tener en cuenta ñ ni vocales acentuadas, 
 * sólo el alfabeto inglés). Se usaría de manera muy similar a:
 * 
 * ContarMm ("Este es un Texto", mays, mins);
 * Console.WriteLine ("Mayúsculas: " + mays + ", minúsculas: " + mins);
 * // Mostraría "Mayúsculas: 2, minúsculas: 11"
 * 
 * Alumno: Omar (...) */
 
using System;

class Ejercicio116
{
    static void ContarMm(string texto, ref int mayus, ref int minus)
    {
        mayus = minus = 0;
        foreach(char letra in texto)
        {
            if(letra >= 'A' && letra <= 'Z')
                mayus++;
            else if(letra >= 'a' && letra <= 'z')
                minus++;
        }
    }
    static void Main()
    {
        int mayusculas, minusculas;
        mayusculas = minusculas = 0;
        
        ContarMm("Este es un Texto", ref mayusculas, ref minusculas);
        Console.WriteLine("Mayúsculas: " + mayusculas + ", minúsculas: " +
            minusculas);
    }
}
