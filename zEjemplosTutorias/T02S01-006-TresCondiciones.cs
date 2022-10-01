// Tres condiciones encadenadas, con if + else

using System;

class TresCondiciones
{
    static void Main()
    {
        int n;
    
        Console.Write("Dime un número ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if ( n > 0 ) 
            Console.WriteLine("Positivo");
        else if ( n < 0 ) 
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Cero");
    }
}
