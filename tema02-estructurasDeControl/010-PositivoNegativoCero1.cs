/* Radha (...)
 * 
 * 10. Crea un programa en C# que pida al usuario un número entero 
 * y responda si es un número positivo, negativo o cero.*/
 
 using System;
 
 class Ejercicio10
{
    static void Main()
    {
        int numero;
       
        Console.WriteLine("Introduce un número");
        numero = Convert.ToInt32 ( Console.ReadLine () );
        
        if ( numero > 0 )
        {
            Console.WriteLine("Es positivo");
        }
        
        if ( numero < 0 )
        {
            Console.WriteLine("Es negativo");
        }
        
        if ( numero == 0)
        {
            Console. WriteLine("Es cero");
        }
    }
}

