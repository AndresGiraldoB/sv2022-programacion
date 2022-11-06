/* 67. Haz un programa que pida al usuario el nombre de un día
 * (por ejemplo "martes") y le responda qué número de día de
 * la semana es (por ejemplo, "el martes es el día 2 de la semana").
 * Debes emplear "switch".
 * 
 * Manuel Jesús (...) */

using System;

class NumeroDia
{
    static void Main()
    {
        string dia;

        Console.WriteLine("Dime un día de la semana");
        dia = Console.ReadLine();
        
        Console.Write("El "+ dia + " es el día ");

        switch(dia)
        {
            case "lunes":     Console.Write("1"); break;
            case "martes":    Console.Write("2"); break;
            case "miércoles": Console.Write("3"); break;
            case "jueves":    Console.Write("4"); break;
            case "viernes":   Console.Write("5"); break;
            case "sábado":    Console.Write("6"); break;
            case "domingo":   Console.Write("7"); break;
            default: Console.Write("más desconcertante"); break;
        }
        Console.WriteLine(" de la semana");
    }
}
