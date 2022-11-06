/*64. Crea una tercera versión del programa 62, que no emplee 
constantes convencionales sino una enumeración.

* Radha */

using System;

class Ejercicio62
{
    enum opciones{SALIR, JUGAR, CARGAR, VER};
    static void Main()
    {
        byte opcion;
        
        Console.WriteLine( (byte)opciones.JUGAR+". Jugar nueva partida");
        Console.WriteLine( (byte)opciones.CARGAR+". Cargar partida");
        Console.WriteLine( (byte)opciones.VER+". Ver mejores puntuaciones");
        Console.WriteLine( (byte)opciones.SALIR+". Salir");
        
        Console.WriteLine();
        opcion = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Ha escogido la opción ");
        switch(opcion)
        {
            case (byte) opciones.JUGAR:
                Console.WriteLine("\""+(byte)opciones.JUGAR+
                    "\": \"Jugar nueva partida\"");
                break;
            case (byte) opciones.CARGAR:
                Console.WriteLine("\""+(byte)opciones.CARGAR+
                    "\": \"Cargar partida\"");
                break;
            case (byte) opciones.VER:
                Console.WriteLine("\""+(byte)opciones.VER+
                    "\": \"Ver mejores puntuaciones\"");
                break;
            case (byte) opciones.SALIR:
                Console.WriteLine("\""+(byte)opciones.SALIR+"\": \"Salir\"");
                break;
            default:
                Console.WriteLine("No es una opción válida");
                break;
        }
    }
}

