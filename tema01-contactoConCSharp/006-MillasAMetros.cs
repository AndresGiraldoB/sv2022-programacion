// 6. Radha (...)
// Conversor de millas a metros

/*
6. Crea un programa que pida al usuario una cantidad de millas y 
muestre su equivalencia en metros (1 milla terrrestre = 1609 metros). 
Debe emplear tres variables: millas, metros, metrosPorMilla. Debe 
mostrar toda la información en una línea, algo como "2 millas son 3218 
m", usando "Write" en vez de "WriteLine". Debe utilizar "using 
System;". Debe contener dos comentarios de una línea al principio: uno 
con tu nombre y otro con el cometido del programa (p.ej: Conversor de 
millas a metros).
*/

using System;

class Ejercicio6
{
    static void Main()
    {
        int millas, metros, metrosPorMilla;
        
        metrosPorMilla = 1609;
    
        Console.Write("Introduce las millas que quieras convertir: ");
        millas = Convert.ToInt32(Console.ReadLine());
        metros = millas*metrosPorMilla;
        
        Console.Write(millas);
        Console.Write(" millas son ");
        Console.Write(metros);
        Console.Write(" metros");
    }
}
            
