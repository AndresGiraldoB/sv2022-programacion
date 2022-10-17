/* 38. Muestra un triángulo decreciente, formado por letras X, alineado 
 * a la derecha, con el tamaño indicado por el usuario, usando "for".

 * Radha (...) */
 
 using System;
 
 class Ejercicio38
 {
     static void Main()
     {
         int tamanyo, fila, columna, espacio;
         
         Console.WriteLine("¿Tamaño?");
         tamanyo = Convert.ToInt32(Console.ReadLine());
         
         for(fila=1; fila<=tamanyo; fila++)
         {
             for(espacio=1; espacio<fila; espacio++)
             {
                 Console.Write(" ");
             }
             for(columna=tamanyo; columna>=fila; columna--)
             {
                 Console.Write("X");
             }
             Console.WriteLine( );
         }
     }
 }
