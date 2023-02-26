
/*184. Crea un programa parecido al anterior,
 * pero que no guarde frases individuales,
 * sino capitales de países del mundo 
 * (para cada capital se guardarán dos datos: el nombre de la capital y 
 * el nombre del país).
 * Mostrará un menú que permita al usuario introducir una capital,
 * ver todas ellas, buscar las que contengan un cierto texto
 * (en el nombre de la ciudad o en el país), modificar una de ellas
 * (indicando su posición) o borrar una de ellas (a partir de su posición).*/

// Noelia (...), retoques por Nacho

using System;
using System.Collections.Generic;

class Ejercicio184
{
    struct TipoCapital
    {
        public string nombre;
        public string pais;
    }
    static void Main()
    {
        List<TipoCapital> capitales = new List<TipoCapital>();
        const int ANYADIR = 1, VER = 2, BUSCAR = 3, MODIFICAR = 4,
            BORRAR = 5, SALIR = 0;
        int opcion;
        do
        {
            Console.WriteLine(ANYADIR + " Introducir una capital");
            Console.WriteLine(VER + " Ver todas las capitales");
            Console.WriteLine(BUSCAR + " Buscar una capital");
            Console.WriteLine(MODIFICAR + " Modificar una capital");
            Console.WriteLine(BORRAR + " Borrar una capital");
            Console.WriteLine(SALIR + " Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case ANYADIR:
                    TipoCapital nuevaCapital;
                    Console.Write("Nombre: ");
                    nuevaCapital.nombre = Console.ReadLine();
                    Console.Write("País: ");
                    nuevaCapital.pais = Console.ReadLine();
                    if ((nuevaCapital.nombre != "") && (nuevaCapital.pais != ""))
                    {
                        capitales.Add(nuevaCapital);
                    }
                    break;

                case VER:
                    foreach (TipoCapital c in capitales)
                    {
                        Console.WriteLine(c.nombre + " - " + c.pais);
                    }
                    break;

                case BUSCAR:
                    Console.WriteLine("Texto a buscar: ");
                    string textoBuscar = Console.ReadLine().ToLower();
                    for (int i = 0; i < capitales.Count; i++)
                    {
                        if ((capitales[i].nombre.ToLower().Contains(textoBuscar)) || (
                                capitales[i].pais.ToLower().Contains(textoBuscar)))
                        {
                            Console.WriteLine( (i+1) + ": " + 
                                capitales[i].nombre + " - " + capitales[i].pais);
                        }
                    }
                    break;

                case MODIFICAR:
                    TipoCapital capitalModificar;
                    Console.Write("¿Que capital quieres modificar?: ");
                    int numeroModificar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nuevo nombre de la ciudad: ");
                    capitalModificar.nombre = Console.ReadLine();
                    Console.Write("Nuevo nombre del país: ");
                    capitalModificar.pais = Console.ReadLine();
                    capitales[numeroModificar - 1] = capitalModificar;
                    break;

                case BORRAR:
                    Console.Write("¿Que frase quieres borrar?: ");
                    int numeroBorrar = Convert.ToInt32(Console.ReadLine());
                    capitales.RemoveAt(numeroBorrar - 1);
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
