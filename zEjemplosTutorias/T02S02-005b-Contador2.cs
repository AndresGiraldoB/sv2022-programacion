// Tutorías T2 S2, ejemplo 5b
// Contador, con while (2):
// números del 1 al 5, en la misma línea, separados por un espacio
// (y con un salto de línea tras terminar)

using System;

class Contador
{
    static void Main()
    {
        int i;
        
        i = 1;
        while ( i <= 5 )
        {
            Console.Write("{0} ", i);
            i = i+1;
        }
        Console.WriteLine();
    }
}
