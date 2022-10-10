// Por José Manuel (...)

/*  Escribe un programa en C# que pida al usuario una contraseña numérica. 
 * Se le dirá "Acceso concedido" cuando acierte la contraseña correcta, 1234. 
 * Si no la acierta, se le volverá a pedir tantas veces como sea necesario. 
 * Hazlo empleando "while".
 */

using System;
class Ejercicio_22
{
    static void Main()
    {
        int numero;
        int contrasenya = 1234;
        
        Console.Write("Introduce la contraseña: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        while(numero != contrasenya)
        {
            Console.WriteLine("Contraseña incorrecta, introduce la contraseña");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        
        Console.WriteLine("Acceso concedido.");
    }
} 


