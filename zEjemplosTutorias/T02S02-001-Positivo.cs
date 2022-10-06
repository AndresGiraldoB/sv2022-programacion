// Tutorías T2 S2, ejemplo 1
// Ver si un numero es positivo (if + ternario)

using System;

class EsPositivo
{
    static void Main()
    {
        int n, positivo;
    
        Console.Write("Dime un número: ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if ( n > 0 ) 
            positivo = 1;
        else 
            positivo = 0;
        
        Console.WriteLine("Positivo: {0}", positivo);
        
        positivo =  n > 0 ? 1 : 0;
        
        Console.WriteLine("Positivo (intento 2): {0}", positivo);
    }
}
