using System;
/*Haz un programa que diga al usuario "Introduce un múltiplo de 7",
 y se lo pida tantas veces como sea necesario,
repitiendo en caso de que introduzca un número no válido. */

// Noelia (...)

class MultiploDe7
{
    static void Main()
    {
         int  n ;

        Console.WriteLine("Escribe un múltiplo de 7: ");
        n=Convert.ToInt32(Console.ReadLine());

        while (n % 7 != 0)
        {
            Console.WriteLine("Ese no. Escribe un múltiplo de 7: ");
            n=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("El número {0} es múltiplo de 7", n);
    }
}
