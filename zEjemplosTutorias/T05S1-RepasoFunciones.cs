
using System;

class Ejercicio91
{

    static void Main()
    {
        MostrarBienvenida();
        EscribirGuiones(10);
        
        Console.WriteLine( Pedir("Dime tu edad") );
        int numero1 = Pedir("Dime un número del 1 al 10");
        int numero2 = Pedir("Dime otro número del 1 al 10");
        EscribirSuma( numero1, numero2 );
    }
    
    static void MostrarBienvenida()
    {
        Console.WriteLine("Bienvenido");
    }
    
    static void EscribirGuiones(int n)
    {
        int i;
        for (i = 0; i < n; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
    
    static void EscribirSuma(int n1, int n2)
    {
        Console.Write( n1 + n2);
    }
    
    static int Pedir(string mensaje)
    {
        int respuesta;
        Console.WriteLine(mensaje);
        respuesta = Convert.ToInt32( Console.ReadLine() );
        return respuesta;
    }
}

