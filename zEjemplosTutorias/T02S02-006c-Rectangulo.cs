// Tutorías T2 S2, ejemplo 6
// Rectángulo, con while (5 filas de 20 asteriscos cada una)

using System;

class Rectangulo
{
    static void Main()
    {
        int fila, columna;
        
        fila = 1;
        while ( fila <= 5 )
        {
            
            columna = 1;
            while ( columna <= 20 )
            {
                Console.Write("*");
                columna ++;
            }
            Console.WriteLine();
            
            fila ++;
        }
    }
}
