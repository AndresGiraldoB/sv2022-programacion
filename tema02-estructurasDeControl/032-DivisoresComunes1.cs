//Ejercicio 32. Escribe un programa que le pida al usuario dos números y muestre sus divisores comunes.

// Edgar (...)

using System;

class DivisoresComunes1
{
    static void Main()
    {
        int n1, n2, menor, i;
        
        Console.WriteLine("Buscador de divisores comunes");
        Console.Write("Introduce el primer número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        menor = n1 > n2 ? n1 : n2;

        Console.Write("Sus divisores comunes son: ");
        for (i = 1; i < menor; i++)
        {
            if((n1%i == 0) && (n2%i == 0))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}

