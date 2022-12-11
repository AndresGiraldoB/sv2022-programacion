/*Crea una función "SumaDigitosNo", que devuelva la suma de los dígitos de un 
entero largo que reciba como parámetro (puedes tomar la última cifra cada vez 
con n%10, y luego eliminarla con n = n/10). Pruébala desde Main, para un dato 
introducido por el usuario. Para gestionar los errores de introducción de 
datos, no debes usar "try-catch" sino "TryParse" (apartado 5.7.4 de los 
apuntes).*/

// Fátima Blasco Botía

using System;
class Ejercicio105
{
    static long SumaDigitosNo (long numeroUsuario)
    {
        long suma = 0;

        while (numeroUsuario > 0)
        {
            byte cifra = (byte) (numeroUsuario % 10);
            numeroUsuario /= 10;
            suma += cifra;
        }
        return suma; 
    }
    
    static void Main()
    {
        long numero;

        Console.Write("Dime un número: ");

        if (Int64.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("La suma de los dígitos de {0} es: {1}",
                numero, SumaDigitosNo(numero));
        }
        else
            Console.WriteLine("Error");
    }
}
