// Ver si un números es positivo (versión 2: dos órdenes, con llaves)

using System;

class Positivo2
{
    static void Main()
    {
        int n;
    
        Console.Write("Dime un número ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if ( n > 0 )
        {
            Console.WriteLine("Positivo");
            Console.WriteLine("Puedes usar negativos");
        }
    }
}
