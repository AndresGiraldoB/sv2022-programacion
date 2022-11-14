/* 72. Crea un programa que pregunte al usuario cuántos datos 
 * (cadenas de texto) va a introducir, reserve espacio para todos ellos,
 * se los pida al usuario y finamente los muestre en orden contrario.
  
 * Manuel Jesús (...) */

using System;

class ArrayDeCadenas
{
    static void Main()
    {

        Console.WriteLine("¿Cuantos datos vas a introducir?");
        int n = Convert.ToInt32(Console.ReadLine()); 
        string[] cadena = new string[n];
        
        Console.WriteLine("Ahora introduce los datos a almacenar");
        for(int i = 0; i < cadena.Length; i++)
        {
            Console.WriteLine("Introduce el dato {0}", i+1);
            cadena[i] = Convert.ToString(Console.ReadLine());
        }
        
        for(int i = cadena.Length-1; i >= 0; i--)
        {
            Console.Write("{0} ",  cadena[i]);
        }
        Console.WriteLine();
    }
}
