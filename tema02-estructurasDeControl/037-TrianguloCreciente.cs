// Por José Manuel (...)
/*
37. Muestra un triángulo creciente de asteriscos, alineado a la izquierda, 
con el tamaño indicado por el usuario, usando "for":

Tamaño? 5
*
**
***
****
*****
*/


using System;
class Ejercicio_37
{
     static void Main()
     {
         int tamanyo;
         
         Console.Write("Dime un tamaño de triángulo: ");
         tamanyo = Convert.ToInt32(Console.ReadLine());
         
         for( int fila = 1; fila <= tamanyo; fila++)
         {
             for( int columna = 1; columna <= fila; columna++)
             {
                 Console.Write("*");
             }
             Console.WriteLine();
         }
     }
}
