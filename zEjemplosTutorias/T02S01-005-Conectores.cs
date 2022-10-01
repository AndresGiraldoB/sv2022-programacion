// Prueba de los "conectores" (y, o, no)

using System;

class Conectores
{
    static void Main()
    {
        int n;
    
        Console.Write("Dime un número ");
        n = Convert.ToInt32( Console.ReadLine() );
        
        
        if ( n >= 0 ) Console.WriteLine("Positivo o quizá cero");
        
        if ( (n > 0)  ||  (n == 0) )
            Console.WriteLine("Positivo o quizá cero");
        
        // ---
        
        if ( n <= 0 ) Console.WriteLine("Negativo o quizá cero");
        
        if ( ! (n > 0)  )
            Console.WriteLine("Negativo o quizá cero");
            
        // ---
        
        if ( (n > 0)  &&  (n == 0) )
            Console.WriteLine("???????");
    }
}
