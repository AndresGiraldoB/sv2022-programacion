/*63. Crea una nueva versión del programa anterior, que no utilice 
"números mágicos" en la orden "switch", sino constantes.
 
* Radha */

using System;

class Ejercicio63
{
    static void Main()
    {
        byte opcion;
        const byte JUGAR = 1,  CARGAR = 2,  VER_PUNTUACION=3;
        const byte SALIR = 0;

        Console.WriteLine(JUGAR+". Jugar nueva partida");
        Console.WriteLine(CARGAR +". Cargar partida");
        Console.WriteLine(VER_PUNTUACION +". Ver mejores puntuaciones");
        Console.WriteLine(SALIR +". Salir");
        
        Console.WriteLine();
        opcion = Convert.ToByte(Console.ReadLine());
        Console.Write("Ha escogido la opción ");
        switch(opcion)
        {
            case JUGAR:
                Console.WriteLine("\""+JUGAR+"\": \"Jugar nueva partida\"");
                break;
            case CARGAR:
                Console.WriteLine("\""+CARGAR+"\": \"Cargar partida\"");
                break;
            case VER_PUNTUACION:
                Console.WriteLine("\""+VER_PUNTUACION+
                    "\": \"Ver mejores puntuaciones\"");
                break;
            case SALIR:
                Console.WriteLine("\""+SALIR+"\": \"Salir\"");
                break;
            default:
                Console.WriteLine("No es una opción válida");
                break;
        }
    }
}

