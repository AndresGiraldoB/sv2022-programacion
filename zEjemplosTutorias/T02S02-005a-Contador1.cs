// Tutorías T2 S2, ejemplo 5a
// Contador, con while (1):
// números del 1 al 5, cada uno en una línea

using System;

class Contador
{
    static void Main()
    {
        int i;
        
        i = 1;
        while ( i <= 5 )
        {
            Console.WriteLine(i);
            i = i+1;
        }
    }
}
