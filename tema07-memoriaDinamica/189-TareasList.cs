/* 
 * Alumno: Omar (...)
 * 
 * 189. Crea un gestor básico de tareas, usando una lista de objetos de clase 
 * "Tarea" (con los atributos o propiedades: descripción -texto-, prioridad -1 a 
 * 5-, completada -verdadero o falso-). Esa clase "Tarea" implementará la interfaz 
 * IComparable, lo que te obligará a crear un método "CompareTo", que permita 
 * comparar dos tareas, para poder utilizar "Array.Sort" en vez de algoritmos 
 * lentos como la "burbuja". En esta primera versión, el criterio de comparación 
 * será la descripción, de modo que las tareas se muestren ordenadas de la A a la 
 * Z. El programa principal mostrará un menú al usuario, mediante el cual pueda:
 * 
 * 1 - Añadir una nueva tarea.
 * 
 * 2 - Ver todas las tareas pendientes.
 * 
 * 3 - Marcar una tarea como completada, a partir de su posición en el array (1 
 * para la primera, 2 para la segunda, etc).
 * 
 * 4 - Modificar una tarea (también a partir de su posición).
 * 
 * 5 - Buscar entre todas las tareas que contengan un cierto texto (estén 
 * completadas o no).
 * 
 * 6 - Ordenar las tareas alfabéticamente.
 * 
 * S - Salir.
*/

using System;
using System.Collections.Generic;

class Tarea : IComparable<Tarea>
{
    public Tarea(string descripcion, byte prioridad)
    {
        Descripcion = descripcion;
        Prioridad = prioridad;
        Completada = false;
    }

    public string Descripcion { get; set; }
    public byte Prioridad { get; set; }
    public bool Completada { get; set; }

    public int CompareTo(Tarea otro)
    {
        return Descripcion.CompareTo(otro.Descripcion);
    }
    
    public override string ToString()
    {
        string mostrarTarea = Descripcion + ". Prioridad: " + Prioridad;

        if (Completada)
            return mostrarTarea + " - Completada";
        else
            return mostrarTarea + " - Pendiente";
    }
}


class Ejercicio189
{
    enum MENU { ANADIR = '1', VERTODO, MARCAR, MODIFICAR, BUSCAR, ORDENAR,
        SALIR='S' };
    const int POS_INCORRECTA = -1;
    static void Main()
    {
        Ejecutar();
    }

    // --------------------------------------------------
    static Tarea PedirTarea()
    {
        string descripcion = Pedir("Descripcion?: ");
        byte prioridad = Convert.ToByte(Pedir("Prioridad? (1-5): "));

        return new Tarea(descripcion, prioridad);
    }

    // --------------------------------------------------
    static void MostrarMenu()
    {
        Console.WriteLine( (char)MENU.ANADIR + "- Añadir una nueva tarea.");
        Console.WriteLine( (char)MENU.VERTODO + "- Ver todas las tareas pendientes.");
        Console.WriteLine( (char)MENU.MARCAR + "- Marcar una tarea como completada");
        Console.WriteLine( (char)MENU.MODIFICAR + "- Modificar una tarea");
        Console.WriteLine( (char)MENU.BUSCAR + "- Buscar entre todas las tareas que "+
            "contengan un cierto texto (completadas o no).");
        Console.WriteLine( (char)MENU.ORDENAR + "- Ordenar las tareas alfabéticamente.");
        Console.WriteLine( (char)MENU.SALIR + "- Salir.");
    }

    // --------------------------------------------------
    static bool ElegirOpciones(List<Tarea> tareas)
    {
        bool salir = false;

        char opcion = Pedir("Opcion?: ").ToUpper()[0];

        switch (opcion)
        {
            case (char) MENU.ANADIR: tareas.Add(PedirTarea()); break;
            case (char) MENU.VERTODO: VerTareas(tareas); break;
            case (char) MENU.MARCAR: MarcarComoCompletada(tareas); break;
            case (char) MENU.MODIFICAR: tareas = ModificarTarea(tareas); break;
            case (char) MENU.BUSCAR: BuscarQueContenga(tareas); break;
            case (char) MENU.ORDENAR: tareas = OrdenarTareas(tareas); break;
            case (char) MENU.SALIR: salir = true; break;
            default:
                Console.WriteLine("Opcion no válida");
                break;
        }

        return salir;
    }
    
    // --------------------------------------------------
    static void Ejecutar()
    {
        List<Tarea> tareas = new List<Tarea>();
        do
        {
            MostrarMenu();
        } while (!ElegirOpciones(tareas));
    }
    
    // --------------------------------------------------
    static List<Tarea> OrdenarTareas(List<Tarea> tareas)
    {
        tareas.Sort();
        return tareas;
    }

    // --------------------------------------------------
    static void BuscarQueContenga(List<Tarea> tareas)
    {
        bool encontrado = false;
        string texto = Pedir("Texto a buscar?: ");

        foreach(Tarea t in tareas)
        {
            if (t.Descripcion.ToUpper().Contains(texto.ToUpper()))
            {
                Console.WriteLine(t);
                encontrado = true;
            }
        }
        
        if (! encontrado)
            Console.WriteLine("No encontrado");
    }

    // --------------------------------------------------
    static void VerTareas(List<Tarea> tareas)
    {
        for (int i = 0; i < tareas.Count; i++)
        {
            if( ! tareas[i].Completada)
                Console.WriteLine((i+1) + ". " + tareas[i]);
        }
    }

    // --------------------------------------------------
    static void MarcarComoCompletada(List<Tarea> tareas)
    {
        string opcion = Pedir("Posicion?: ");
        int posicion = Convert.ToInt32(opcion);

        if (posicion >= 1 && posicion <= tareas.Count)
        {
            Console.WriteLine(posicion + " -" + tareas[posicion - 1]);
            opcion = Pedir("Completar? s/n").ToUpper();

            if (opcion == "S")
            {
                tareas[posicion - 1].Completada = true;
                Console.WriteLine(tareas[posicion - 1]);
            }
        }
    }

    // --------------------------------------------------
    static List<Tarea> ModificarTarea(List<Tarea> tareas)
    {
        string opcion = Pedir("Posicion?: ");
        int posicion = Convert.ToInt32(opcion);
        
        if (posicion >= 1 && posicion <= tareas.Count)
        {
            tareas[posicion - 1] = PedirTarea();
        }
        return tareas;
    }

    // --------------------------------------------------
    static string Pedir(string dato)
    {
        Console.Write(dato);
        return Console.ReadLine();
    }
}

