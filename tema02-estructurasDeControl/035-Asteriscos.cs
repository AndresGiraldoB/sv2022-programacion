// Jorge (...)
// Asteriscos en línea, ejercicio 35

using System;

class Asteriscos
{
    static void Main()
    {
        Console.Write("Introduzca cuántos asteriscos quiere ");
        int n = Convert.ToInt32( Console.ReadLine() );
        
        for (int i = 1; i <= n ; i++)
        {
            Console.Write("*");
        
        }
        Console.WriteLine();
    }
}
