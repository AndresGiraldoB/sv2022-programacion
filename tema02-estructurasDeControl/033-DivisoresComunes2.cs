// Ejercicio 33. Crea una variante mejorada del ejercicio anterior: un programa 
// que le pida al usuario dos números y muestre sus divisores comunes (excepto el 
// 1), o el texto "Ninguno" , en caso de no encontrar ningún divisor común 
// (distinto del 1).

// Edgar (...)

using System;

class Program
{
    static void Main()
    {
        int n1, n2, menor, i, contador;
        contador = 0;
        
        Console.WriteLine("Buscador de divisores comunes");
        Console.Write("Introduce el primer número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        menor = n1 > n2 ? n1 : n2;

        Console.Write("Sus divisores comunes son: ");
        
        for(i = 2; i < menor; i++)
        {
            if ((n1 % i == 0) && (n2 % i == 0))
            {
                Console.Write("{0} ", i);
                contador++;
            }
        }

        if(contador == 0)
        {
            Console.Write("Ninguno.");
        }
    }
}

