// Multiplo de 3 y de 5
// Omar (...)

using System;

class Multiplo3y5
{
    static void Main()
    {
        int n, multiploDe5yDe3;
        
        Console.Write("Introduce un numero: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        // Versión con "if"
        if(n % 3 == 0 && n % 5 == 0)
            multiploDe5yDe3 = 1;
        else
            multiploDe5yDe3 = 0;
        
        if(multiploDe5yDe3 == 1)
            Console.WriteLine("El numero es multiplo de 3 y de 5");
        else
            Console.WriteLine("El numero no es multiplo de 3 y de 5");
            
        // Versión con "operador ternario"
        multiploDe5yDe3 = n % 3 == 0 && n % 5 == 0 ? 1 : 0;
        
        if(multiploDe5yDe3 == 1)
            Console.WriteLine("El numero es multiplo de 3 y de 5");
        else
            Console.WriteLine("El numero no es multiplo de 3 y de 5");

    }
}
