/* 38. Muestra un triángulo decreciente, formado por letras X, alineado 
 * a la derecha, con el tamaño indicado por el usuario, usando "for".
 */
 
 using System;
 
 class Ejercicio38bis
 {
     static void Main()
     {
         int tamanyo, fila, columna;
         int espacios, asteriscos;
         
         Console.Write("¿Tamaño? ");
         tamanyo = Convert.ToInt32(Console.ReadLine());
         
         espacios = tamanyo-1;
         asteriscos = 1;
                 
         for(fila=1; fila<=tamanyo; fila++)
         {
             for(columna=1; columna <= espacios; columna++)
             {
                 Console.Write(" ");
             }
             espacios--;
             
             for(columna=1; columna <= asteriscos; columna++)
             {
                 Console.Write("X");
             }
             asteriscos++;
             
             Console.WriteLine( );
         }
     }
 }
