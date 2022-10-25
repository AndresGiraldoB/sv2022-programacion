/* 42. Prepara un programa que le pida al usuario un número entero y 
 * muestre sus factores primos, usando la estructura repetitiva que 
 * consideres más adecuada. Por ejemplo, para 15 deberá responder "3 5",
 * para 24 responderá "2 2 2 3" y para 60 deberá escribir "2 2 3 5".
 * 
 * Radha 
 */
 
using System;

class Ejercicio42
{
    static void Main()
    {
        int numero, divisor=2;
        
        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32(Console.ReadLine());
        
        while( numero > 1)
        {
            if(numero % divisor == 0)
            {
                Console.Write("{0} ", divisor);
                numero = numero/divisor;
            }
            else
            {
                divisor++;
            }
        }
    }
}
