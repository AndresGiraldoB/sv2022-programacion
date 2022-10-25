/* Juan Manuel (...) */

/*
Ejercicio 43.Crea un programa en C# que pida al usuario el número de un
mes (por ejemplo, 3 para marzo) y el número de un día (por ejemplo, 10)
y muestre de qué número de día dentro del año se trata, en un año no
bisiesto. 
Por ejemplo: como enero tiene 31 días y febrero tiene 28, el 10 de marzo
sería el día número 69 del año (31+28+10).
*/

// Version 2: switch + bucle

using System;


class Ejercicio43
{
    static void Main()
    {
        Console.Write(" Número de mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.Write(" Número de día: ");
        int dia = Convert.ToInt32(Console.ReadLine());
        
        int diasTotales = 0;

        for (int mesActual = 1; mesActual < mes; mesActual++)
        {
            switch (mesActual)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    diasTotales += 31;
                    break;


                case 2:
                    diasTotales += 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    diasTotales += 30;
                    break;

                default:
                    break;
            }
        }
        
        diasTotales += dia;
        Console.WriteLine(" {0}", diasTotales);
    }
}

