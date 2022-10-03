// 16. Pide tres números y di cuál es el mayor de ellos. Por ejemplo, si el 
// usuario introduce 5, 7 y 7, la respuesta será 7. Como ocurre con esos datos,
// es posible que existan números repetidos, y tu programa deberá comportarse 
// correctamente también en ese caso.

// Por José Manuel (...)

using System;

class Ejercicio_16
{
    static void Main()
    {
        int numero1, numero2, numero3;
        
        Console.WriteLine("Escribe un número:");
        numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe otro número:");
        numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el último número:");
        numero3 = Convert.ToInt32(Console.ReadLine());
        
        if (numero1 >= numero2 && numero1 >= numero3)
        {
            Console.WriteLine("{0} es el mayor de los 3 números", numero1);
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            Console.WriteLine("{0} es el mayor de los 3 números", numero2);
        }
        else
        {
            Console.WriteLine("{0} es el mayor de los 3 números", numero3);
        }
    }
}
