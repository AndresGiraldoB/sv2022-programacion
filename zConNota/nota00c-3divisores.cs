/*
Simulacro de ejercicio con nota

Crea un programa que pida al usuario dos números enteros (por ejemplo, el 1 y 
el 100) y muestre en pantalla todos los números que hay entre ellos (ambos 
incluidos) y que tienen exactamente tres divisores (como por ejemplo el número 
4, cuyos divisores son 1,2,4). Los números encontrados deben aparecer en una 
misma línea, separados por un espacio. Debes emplear bucles "for".
*/

// Aproximación 3: Ver los números entre 2 datos, que tengan 3 divisores

// Nacho

using System;

class Ver3divisores2
{   
    static void Main()
    {
        int divisores, primero, ultimo;
        
        Console.Write("Dime desde donde empezamos a buscar: ");
        primero = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Dime hasta donde debemos buscar: ");
        ultimo = Convert.ToInt32(Console.ReadLine());

        for (int numero = primero; numero <= ultimo; numero++)
        {
            divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores ++;
                }
            }

            if (divisores == 3)
            {
                Console.Write("{0} ",numero);
            }
        }
    }
}
