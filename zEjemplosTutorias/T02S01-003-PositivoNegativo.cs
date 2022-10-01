// Ver si un números es positivo o negativo (if + else)

using System;

class PositivoNegativo
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
        else
        {
            Console.WriteLine("Negativo o cero");
        }
    }
}
