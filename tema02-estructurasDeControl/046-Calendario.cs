/*
 *46. Muestra un calendario, pidiendo al usuario la cantidad de días del mes 
 *(por ejemplo, 31) y el número dentro de la semana que ocupa el primer día 
 * (por ejemplo, 2 para el martes).
 */

 //Noelia (...)


using System;

class Calendario
{
    static void Main()
    {
        int diaMes, inicio, dia, i;
        int diaSemana = 1 ;
        
    
        Console.Write("Introduce cantidad de días de un mes: ");
        diaMes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce un número de día de la primera semana: ");
        inicio = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(" L   M   X   J   V   S   D ");
        
        for(i = 1; i < inicio; i++)
            Console.Write("    ");
        diaSemana = inicio;

        for (dia = 1 ; dia <= diaMes ; dia++)
        {
            if (dia < 10) 
                Console.Write(" {0}  ", dia);
            else 
                Console.Write("{0}  ", dia);

            diaSemana++;
            if(diaSemana > 7)
            {
                diaSemana = 1;
                Console.WriteLine();
            }
        }
    }
}
