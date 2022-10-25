/*
    Luis(...). 
    Ejercicio 43. Crea un programa en C# que pida al usuario el número de un mes (por ejemplo, 3 para marzo) y el número de un día (por ejemplo, 10)
    y muestre de qué número de día dentro del año se trata, en un año no bisiesto. 
    Por ejemplo: como enero tiene 31 días y febrero tiene 28, el 10 de marzo sería el día número 69 del año (31+28+10).
*/

// Version 1: sólo con un switch

using System;

class Ejer43
{
    static void Main()
    {
        int mes,dia;
        mes=0;
        dia=0;  

        Console.Write("Escribe un número de mes: ");
        mes=Convert.ToInt32(Console.ReadLine());

        Console.Write("Escribe un número de día: ");
        dia=Convert.ToInt32(Console.ReadLine());

        switch(mes)
        {
            case 1:
                Console.Write(dia);
                break;
            case 2:
                dia=31+dia;
                break;
            case 3:
                dia=59+dia;
                break;
            case 4:
                dia=90+dia;
                break;
            case 5:
                dia=120+dia;
                break;
            case 6:
                dia=151+dia;
                break;
            case 7:
                dia=181+dia;
                break;
            case 8:
                dia=212+dia;
                break;
            case 9:
                dia=243+dia;
                break;
            case 10:
                dia=273+dia;
                break;
            case 11:
                dia=304+dia;
                break;
            case 12:
                dia=334+dia;
                break;
        }
        Console.Write("El día del año es el {0}", dia);
    }

}




