/* Crea un programa en C# que pida al usuario una cadena y la muestre 
encriptada de dos maneras diferentes: primero restando 1 a cada carácter, luego 
con la operación XOR 1.

Fátima (...)*/

using System;
class Ejercicio68
{
    static void Main()
    {
        string cadena;

        Console.Write("Escribe algo: ");
        cadena = Console.ReadLine();

        Console.Write("Si encriptamos restando 1: ");
        foreach ( char letra in cadena)
        {
            Console.Write((char) (letra - 1));
        }
        
        Console.WriteLine();
        Console.Write("Si encriptamos con XOR: ");
        foreach (char letra in cadena)
        {
            Console.Write((char)(letra ^ 1));
        }
    }
}
