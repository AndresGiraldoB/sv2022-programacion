// Parámetros de Main 2: leer dos parámetros de línea de comandos

using System;

class SumaDe2b
{
    static void Main(string[] args)
    {
        int n1, n2;

        n1 = Convert.ToInt32( args[0] );
        n2 = Convert.ToInt32( args[1] );

        Console.WriteLine("Su suma es "+ (n1+n2));
    }
}
