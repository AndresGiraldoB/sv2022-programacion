// Tutorías T2 S2, ejemplo 3
// División, con while

using System;

class DivisionWhile
{
    static void Main()
    {
        int n1, n2;
    
        Console.Write("Dime el dividendo: ");
        n1 = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Dime el divisor: ");
        n2 = Convert.ToInt32( Console.ReadLine() );
        
        while ( n2 == 0 ) 
        {
            Console.WriteLine("No puede ser 0");
            Console.Write("Dime el divisor: ");
            n2 = Convert.ToInt32( Console.ReadLine() );
        }

        Console.Write("La división es: {0}", n1/n2);
    }
}
