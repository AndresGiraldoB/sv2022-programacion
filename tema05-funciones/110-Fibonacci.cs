/* 110. Crea una función recursiva que calcule un cierto elemento de 
 * la serie de Fibonacci, en la que los dos primeros elementos son 0, 
 * y cada elemento posterior es la suma de los dos que le preceden 
 * (n[0] = 0, n[1] = 1,  n[i] = n[i-1] + n[i-2])..
 * 
 * Radha */

using System;

class Ejercicio110
{
    static int Fibonacci(int n)
    {
        if((n == 1) || (n == 2))
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.WriteLine("Introduce un número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(numero));
    }
}
