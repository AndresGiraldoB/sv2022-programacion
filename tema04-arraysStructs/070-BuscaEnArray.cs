/*HÉCTOR (...=

70. Pide al usuario 8 enteros largos sin signo y guárdalos en un array. Luego 
pide uno más y dile si estaba entre esos 8 datos iniciales, de 2 formas 
distintas: primero usando un booleano y luego usando un contador, para, en la 
segunda ocasión, responderle cuántas veces aparecía (ambas respuestas serán 
parte del mismo programa, no dos programas independientes).*/

using System;

class Ejercicio070
{
    static void Main()
    {
        int[] numeros = new int[8];
        int numero;

        // Pedir datos
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numeros[i] = numero;
        }

        Console.Write("Introduzca el número a buscar: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        // Buscar con booleano
        bool encontrado = false;        
        
        for (int i = 0; i < numeros.Length;i++)
            if (numeros[i] == numero)
                encontrado = true;

        if (encontrado)
            Console.WriteLine("El número aparece.");
        else
            Console.WriteLine("El número no aparece.");

        // Buscar con contador
        int contador = 0;
        for (int i = 0; i < numeros.Length;i++)
        {
            if (numero == numeros[i])
                contador++;
        }

        Console.WriteLine("El número de veces que aparece es: {0}", contador);
    }
}
