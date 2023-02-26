
/*183. Crea un programa que muestre un menú que permita al usuario introducir frases 
 * (de una en una, y se guardarán en una lista de strings), ver todas ellas,
 * buscar las que contengan un cierto texto, modificar una de ellas
 * (indicando su posición) o borrar una de ellas (a partir de su posición).*/

// Noelia (...), retoques por Nacho

using System;
using System.Collections.Generic;

class Ejercicio183
{
    static void Main()
    {
        List<string> frases = new List<string>();
        const int ANYADIR = 1, VER = 2, BUSCAR = 3, MODIFICAR = 4, 
            BORRAR = 5, SALIR = 0;
        int opcion;
        do
        {
            Console.WriteLine(ANYADIR + " Introducir frase");
            Console.WriteLine(VER + " Ver todas las frases");
            Console.WriteLine(BUSCAR + " Buscar una frase");
            Console.WriteLine(MODIFICAR + " Modificar una frase");
            Console.WriteLine(BORRAR + " Borrar una frase");
            Console.WriteLine(SALIR + " Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            string frase;
            switch (opcion)
            {
                case ANYADIR:
                    Console.Write("Frase: ");
                    frase = Console.ReadLine();
                    if (frase != "")
                    {
                        frases.Add(frase);
                    }
                    break;

                case VER:
                    foreach (string f in frases)
                    {
                        Console.WriteLine(f);
                    }
                    break;

                case BUSCAR:
                    Console.WriteLine("Texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();
                    foreach (string f in frases)
                    {
                        if (f.ToLower().Contains(textoBuscar))
                        {
                            Console.WriteLine(f);
                        }
                    }
                    break;

                case MODIFICAR:
                    Console.WriteLine("¿Que frase quieres modificar?: ");
                    int numeroModificar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nuevo contenido: ");
                    string fraseNueva = Console.ReadLine();
                    frases[numeroModificar - 1] = fraseNueva;
                    break;

                case BORRAR:
                    Console.WriteLine("¿Que frase quieres borrar?: ");
                    int numeroBorrar = Convert.ToInt32(Console.ReadLine());
                    frases.RemoveAt(numeroBorrar - 1);
                    Console.WriteLine("Borrado con éxito");
                    break;

                case SALIR:
                    Console.WriteLine("Fin del programa");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion != 0);
    }
}
