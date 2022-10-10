/* 24. Muestra 70 asteriscos en la misma línea, usando "while",
 * y avanza de línea tras escribirlos.
 * 
 * Radha (...)
 * 
 */
 
 using System;
 
 class Ejercicio24
 {
     static void Main()
     {
         int n=1;
         
         while(n <= 70)
         {
             Console.Write("*");
             n = n+1;
         }
         
         Console.WriteLine( );
     }
 }

