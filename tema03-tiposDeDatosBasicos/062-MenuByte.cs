/*62. Crea un menú como el siguiente. El usuario deberá escoger la 
opción 0, 1, 2 o 3, y después se le mostrará la opción que ha escogido, 
usando "switch" y datos de tipo "byte":

1. Jugar nueva partida
2. Cargar partida
3. Ver mejores puntuaciones
0. Salir

2
Ha escogido la opción "2": "Cargar partida"

* Radha */

using System;

class Ejercicio62
{
    static void Main()
    {
        byte opcion;
             
        Console.WriteLine("1. Jugar nueva partida");
        Console.WriteLine("2. Cargar partida");
        Console.WriteLine("3. Ver mejores puntuaciones");
        Console.WriteLine("0. Salir");
        
        Console.WriteLine();
        opcion = Convert.ToByte(Console.ReadLine());
        
        Console.Write("Ha escogido la opción ");
        switch(opcion)
        {
            case 1:
                Console.WriteLine("\"1\": \"Jugar nueva partida\"");
                break;
            case 2:
                Console.WriteLine("\"2\": \"Cargar partida\"");
                break;
            case 3:
                Console.WriteLine("\"3\": \"Ver mejores puntuaciones\"");
                break;
            case 0:
                Console.WriteLine("\"0\": \"Salir\"");
                break;
            default:
                Console.WriteLine("No es una opción válida");
                break;
        }
    }
}
