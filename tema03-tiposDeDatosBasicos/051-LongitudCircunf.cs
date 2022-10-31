/*
51. Calcula la longitud de un circunferencia, a partir de su radio, que 
introducirá el usuario en una variable real de doble precisión (longitud = 2 * 
pi * radio). Tanto el valor de "pi" como el resultado (la longitud) deben estar 
almacenados en variables, que también serán números reales de doble precisión.
*/

// By: Alejandro (...)
// 23-10-2022

using System;

class Ejercicio51
{
    static void Main()
    {
        double radio, longitud, pi = 3.1415926335;
        
        Console.Write("Radio: ");
        radio = Convert.ToDouble( Console.ReadLine() );
        
        longitud = 2 * pi * radio;
        Console.Write("Longitud: {0}", longitud);
    }
}
