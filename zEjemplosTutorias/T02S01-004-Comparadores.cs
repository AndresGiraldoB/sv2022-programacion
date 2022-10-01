// Prueba de los "operadores de comparación"

using System;

class Comparadores
{
    static void Main()
    {
        int n;
    
        Console.Write("Dime un número ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        if ( n > 0 )  Console.WriteLine("Positivo");
        if ( n >= 0 ) Console.WriteLine("Positivo o quizá cero");
        if ( n < 0 )  Console.WriteLine("Negativo");
        if ( n <= 0 ) Console.WriteLine("Negativo o quizá cero");
        if ( n != 0 ) Console.WriteLine("Distinto de cero");
        if ( n == 0 ) Console.WriteLine("Cero");
    }
}
