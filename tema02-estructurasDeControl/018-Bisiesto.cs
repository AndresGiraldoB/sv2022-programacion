/*Un año es bisiesto si es múltiplo de 4 pero no múltiplo de 100, a excepción de
los múltiplos de 400, que siempre son bisiestos. Crea un programa que pida al
usuario el número de un año y le diga si es bisiesto. Como datos de prueba:
1992 fue bisiesto, 2000 también, pero no lo fueron 1900 ni 1993.

Fátima (...) */

using System;

class Ejercicio18
{
    static void Main()
    {
        int ano;
        
        Console.Write("Dime un año: ");
        ano = Convert.ToInt32(Console.ReadLine());
        
        if (ano % 400 == 0)
            Console.WriteLine("Es bisiesto");
            
        else if ((ano % 4 == 0) && (ano % 100 != 0))
            Console.WriteLine("Es bisiesto");
            
        else
            Console.WriteLine("No es bisiesto");

    }
}
