/*
Ejercicio 15
Manuel Jesús (...)
Número de días del mes que piden
Usando Switch
*/

using System;
class ejercicio
{
    static void Main()
    {
        int mes;
        
        Console.WriteLine("Introduce el número de mes (1=Enero, 12=Diciembre)");
        mes = Convert.ToInt32( Console.ReadLine() );
        switch(mes)
        {
            case 1: Console.WriteLine("31 días"); break;
            case 2: Console.WriteLine("28 días"); break;
            case 3: goto case 1;
            case 4: Console.WriteLine("30 días"); break;
            case 5: goto case 1;
            case 6: goto case 4;
            case 7: goto case 1;
            case 8: goto case 1;
            case 9: goto case 4;
            case 10: goto case 1;
            case 11: goto case 4;
            case 12: goto case 1;
            default: Console.WriteLine("Número inválido"); break;
        }
    }
}
