/*57. Pide al usuario un número binario (por ejemplo 1101) y muestra su
equivalente en decimal. Debes hacerlo de la siguiente forma:  leerás un número
entero largo n, e irás extrayendo cada vez su última cifra (con "cifra = n %
10") y eliminando esa cifra (con "n = n / 10"); si esa cifra es 1, deberás
sumar la correspondiente potencia de 2 (que será 1 para la primera cifra que
elimines, luego 2 para la siguiente, después 4, a continuación 8, luego 16 y
así sucesivamente). Finalmente, muestra el equivalente en binario de ese número
que has obtenido, pero esta vez usando "Convert.ToString(n, 2)" (si todo ha ido
bien, debería coincidir con el dato inicial).*/

//Sole (...)

using System;

class Ejercicio57
{
    static void Main()
    {
        long numeroBinario;
        long numeroDecimal = 0;
        long potenciade2 = 1;

        Console.WriteLine("Introduce un número Binario");
        numeroBinario = Convert.ToInt32(Console.ReadLine());
        
        while (numeroBinario > 0)
        {
            long ultimaCifra = numeroBinario % 10;
            numeroDecimal += ultimaCifra * potenciade2;

            //Siguiente paso
            numeroBinario /= 10;
            potenciade2 *= 2;
        }
        Console.WriteLine("En decimal: {0}", numeroDecimal);
         
        Console.WriteLine("Que debería venir de {0}",
            Convert.ToString(numeroDecimal, 2));
    }
}
