// Tutorías T2 S2, ejemplo 4b
// División, con do-while, versión más amigable

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
            if (n2 == 0)
            {
                Console.WriteLine("No debe ser 0");
            }
        }
        while ( n2 == 0 );
        
        Console.Write("La división es: {0}", n1/n2);
    }
}
