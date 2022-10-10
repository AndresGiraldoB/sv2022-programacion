/*Crea un programa que le pida al usuario un número y responda si es primo.
Debes hacerlo contando cuántos divisores tiene. Será primo si y solo si tiene
exactamente dos divisores. Debes emplear "do-while".
 
Fátima (...) */

using System;

class NumeroPrimo
{   
    static void Main()
    {
        int posibleDivisor = 1;
        int divisoresEncontrados = 0;
        int n;

        Console.Write("Introduce un número, veamos si es primo: ");
        n = Convert.ToInt32(Console.ReadLine());

        do
        {
            
            if (n % posibleDivisor == 0)
            {
                divisoresEncontrados ++;
            }
            posibleDivisor ++;
            
        }

        while (posibleDivisor <= n);


        if (divisoresEncontrados == 2)
            Console.WriteLine("Es primo, tiene 2 divisores");
        else
            Console.WriteLine("No es número primo, tiene {0} divisores",
                divisoresEncontrados);
    }
}
