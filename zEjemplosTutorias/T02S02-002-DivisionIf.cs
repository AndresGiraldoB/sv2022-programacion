// Tutorías T2 S2, ejemplo 2
// Intento de división repetitiva, con if (puede fallar)

using System;

class DivisionIf
{
    static void Main()
    {
        int n1, n2;
    
        Console.Write("Dime el dividendo: ");
        n1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Dime el divisor: ");
        n2 = Convert.ToInt32( Console.ReadLine() );
        
        if ( n2 == 0 ) 
        {
            Console.WriteLine("No puede ser 0");
            Console.Write("Dime el divisor: ");
            n2 = Convert.ToInt32( Console.ReadLine() );
            Console.Write("La división es: {0}", n1/n2);
        }
        else 
        {
            Console.Write("La división es: {0}", n1/n2);
        }
    }
}
