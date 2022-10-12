// Tutorías T2 S3, ejemplo 2
// Continue, break, goto

using System;

class T02S03ab
{
    static void Main()
    {
        int i;
        
        // Alternativa mala con "break"
        for (i = 20; i <= 30; i++)
        {
            if ( i == 25 )
            {
                break;
            }
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        
        // Alternativa razonable a "break"
        for (i = 20; i < 25; i++)
        {
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        
        // Alternativa mala con "continue"
        for (i = 20; i <= 30; i++)
        {
            if ( i == 25 )
            {
                continue;
            }
            Console.Write("{0} ",i);
        }
        Console.WriteLine();
        
        
        // Alternativa buena a "continue"
        for (i = 20; i <= 30; i++)
        {
            if ( i != 25 )
            {
                Console.Write("{0} ",i);
            }
        }
        Console.WriteLine();
        
        
        // Alternativa mala con "goto"
        for (i = 20; i <= 30; i++)
        {
            if ( i == 25 )
            {
                goto fin;
            }
            Console.Write("{0} ",i);
        }
        fin:
        Console.WriteLine();
        
        // Contador con "goto" (No repetir, peligro de suspenso)
        i = 20;
        repetir:
        Console.Write("{0} ",i);
        i ++;
        if (i <= 30)
          goto repetir;
    }
}
