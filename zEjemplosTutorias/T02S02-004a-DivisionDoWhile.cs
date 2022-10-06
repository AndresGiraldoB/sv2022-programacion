// Tutorías T2 S2, ejemplo 4
// División, con do-while

using System;

class DivisionDoWhile
{
    static void Main()
    {
        int n1, n2;
    
        Console.Write("Dime el dividendo: ");
        n1 = Convert.ToInt32( Console.ReadLine() );
        
        do
        {
            Console.Write("Dime el divisor: ");
            n2 = Convert.ToInt32( Console.ReadLine() );
        }
        while ( n2 == 0 );
        
        Console.Write("La división es: {0}", n1/n2);

    }
}
