/*34. Crea un programa que pida al usuario dos números enteros 
* y muestre su potencia (el primero elevado al segundo), 
* empleando multiplicaciones repetitivas. Recuerda que 
* 3 ^ 4 = 3 * 3 * 3 * 3 (es decir, 4 multiplicandos) = 81*/

// Franscisco de Borja (...)
        
using System;

public class Ejercicio34
{
    public static void Main()
    {
        int potencia, numerador;
        int resultado = 1;

        Console.WriteLine("Escribe el numero, por favor: ");
        numerador = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("escribe la potencia");
        potencia = Convert.ToInt32(Console.ReadLine());

        for (int i =1; i<=potencia; i++)
        {
            resultado = resultado * numerador;   
        }
        Console.WriteLine(resultado);
    }
}
