/* 8. Muestra la tabla de multiplicar del número escogido por el 
usuario, usando las estructuras que consideres más adecuadas... de las 
que conoces por ahora. El programa será MUY repetitivo, pero en el 
próximo tema veremos cómo hacerlo más eficiente, usando lo que 
llamaremos "bucles". */

/*Alumno: Víctor Raúl (...)
Tabla de multiplicar*/

using System;

class Ejercicio8
{
    
    static void Main() 
    {
        
        int multiplicando;
        
        Console.WriteLine("Introduzca que tabla de multiplicar quiere mostrar:");
        multiplicando = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} x 0 = {1}", multiplicando, multiplicando*0);
        Console.WriteLine("{0} x 1 = {1}", multiplicando, multiplicando*1);
        Console.WriteLine("{0} x 2 = {1}", multiplicando, multiplicando*2);
        Console.WriteLine("{0} x 3 = {1}", multiplicando, multiplicando*3);
        Console.WriteLine("{0} x 4 = {1}", multiplicando, multiplicando*4);
        Console.WriteLine("{0} x 5 = {1}", multiplicando, multiplicando*5);
        Console.WriteLine("{0} x 6 = {1}", multiplicando, multiplicando*6);
        Console.WriteLine("{0} x 7 = {1}", multiplicando, multiplicando*7);
        Console.WriteLine("{0} x 8 = {1}", multiplicando, multiplicando*8);
        Console.WriteLine("{0} x 9 = {1}", multiplicando, multiplicando*9);
        Console.WriteLine("{0} x 10 = {1}", multiplicando, multiplicando*10);
    }
}
