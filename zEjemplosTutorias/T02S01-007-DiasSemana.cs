// Días de la semana (lunes a miércoles), con "if" y con "switch"

using System;

class DiasSemana
{
    static void Main()
    {
        int dia;
    
        Console.Write("Dime un número de día de la semana (1 a 3): ");
        dia = Convert.ToInt32( Console.ReadLine() );
        
        if ( dia == 1 ) 
            Console.WriteLine("Lunes");
        else if ( dia == 2 ) 
            Console.WriteLine("Martes");
        else if ( dia == 3 ) 
            Console.WriteLine("Miércoles");
        else
            Console.WriteLine("No sé tantos días");
            
        
        switch(dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            
            case 2:
                Console.WriteLine("Martes");
                break;
                
            case 3:
                Console.WriteLine("Miércoles");
                break;
                
            default:
                Console.WriteLine("No sé tantos días");
                break;
        }
    }
}
