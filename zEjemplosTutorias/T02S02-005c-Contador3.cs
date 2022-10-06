// Tutorías T2 S2, ejemplo 5c
// Contador, con while (3):
// 5 asteriscos en la misma línea, salto de línea tras ellos

using System;

class Contador
{
    static void Main()
    {
        int i;
        
        i = 1;
        while ( i <= 5 )
        {
            Console.Write("*");
            i++;
        }
        Console.WriteLine();
    }
}
