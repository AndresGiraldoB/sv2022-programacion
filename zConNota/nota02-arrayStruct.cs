/*  Ejercicio con nota 2 (tema 4)

Crea un programa en C# que pueda almacenar hasta 10000 tareas. Para 
cada tarea, debe permitir al usuario almacenar la siguiente 
información:

    • Descripción
    • Fecha límite (un texto como 2022-12-21)
    • Prioridad (1 a 5)
    • Completada o no (booleano)

Esta versión mostrará un menú con las opciones:

1. Añadir una tarea.
2. Ver tareas no completadas.
3. Marcar una tarea como completada.
4. Buscar entre las tareas existentes.
5. Modificar los datos de una tarea.
6. Borrar una tarea.
7. Ordenar datos.
S. Salir.



Es decir, debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir un nueva tarea (al final de los datos existentes). Ni la 
descripción ni la fecha deben estar vacías. Si se introduce una cadena 
vacía como respuesta a la prioridad, ésta se guardará como 3. No se 
pedirá si está completada, sino que se dará por sentado que no es así.

2 - Ver tareas no completadas, mirando el correspondiente campo 
booleano. Debe mostrar el número de registro, la descripción, la fecha 
límite y la prioridad, en la misma línea, haciendo una pausa después de 
cada 22 líneas en pantalla.

3 - Marcar una tarea como completada, a partir de su número de 
registro. Se le debe avisar (pero no volver a preguntar) si introduce 
un número de registro incorrecto. Debe mostrar la tarea que se va a 
marcar como completada y solicitar confirmación antes de hacerlo.

4 - Buscar tareas que contengan un determinado texto (búsqueda parcial, 
en las descripción o en la fecha límite, sin distinción de mayúsculas y 
minúsculas). Debe mostrar el número de registro, la descripción, la 
fecha límite y la prioridad, en la misma línea, haciendo una pausa 
después de cada 22 líneas en pantalla.

5 - Modificar un registro: pedirá al usuario su número (por ejemplo, 1 
para la primera ficha), mostrará el valor anterior de cada campo (por 
ejemplo, dirá: "Descripción anterior: Ejercicios de programación") y 
permitirá escribir un nuevo valor para ese campo, o bien pulsar Intro 
para dejarlo sin modificar. Se debe avisar al usuario (pero no volver a 
pedir) si introduce un número de registro incorrecto.

6 - Borrar un registro, en la posición indicada por el usuario. Se le 
debe avisar (pero no volver a preguntar) si introduce un número de 
registro incorrecto. Debe mostrar el registro que se va a eliminar y 
solicitar confirmación antes de la eliminación.

7 - Ordenar los datos alfabéticamente, por fecha, y en caso de 
coincidir la fecha, de mayor a menor prioridad.

S - Salir de la aplicación (como no guardamos la información en 
fichero, los datos se perderán).

El menú deberá repetirse hasta que el usuario escoja la opción "S" (que 
será aceptable tanto en mayúsculas como en minúsculas).

La estructura repetitiva del programa debe ser adecuada, y emplear un 
booleano de control. El fuente debe estar correctamente tabulado y 
resultar fácil de leer.

Debes entregar exclusivamente el fichero ".cs" (no todo el proyecto), 
sin comprimir, que deberá tener un comentario con tu nombre al 
principio. Haz que el nombre del fichero también incluya tu nombre. * * 
* 
*  */

using System;

class EjercicioNota2
{
    struct Tarea
    {
        public string descripcion;
        public string fecha;
        public byte prioridad;
        public bool completada;
    }
    
    static void Main()
    {
        const int MAXIMO = 10000, TAM_PAGINA=22;
        int cantidad = 0;
        bool terminado = false;
        const string ANYADIR = "1", VER = "2", MARCAR = "3", BUSCAR = "4",
            MODIFICAR = "5", BORRAR = "6", ORDENAR = "7", SALIR = "S";
        string opcion;
            
        Tarea[] tareas = new Tarea[MAXIMO];  
        
        do
        {
            Console.WriteLine();
            Console.WriteLine(ANYADIR +
                ". Añadir una tarea.");
            Console.WriteLine(VER +
                ". Ver tareas no completadas.");
            Console.WriteLine(MARCAR +
                ". Marcar una tarea como completada.");
            Console.WriteLine(BUSCAR +
                ". Buscar entre las tareas existentes.");
            Console.WriteLine(MODIFICAR +
                ". Modificar los datos de una tarea.");
            Console.WriteLine(BORRAR +
                ". Borrar una tarea.");
            Console.WriteLine(ORDENAR +
                ". Ordenar datos.");
            Console.WriteLine(SALIR +". Salir.");
            
            Console.Write("Escoja una opción:");
            opcion = Console.ReadLine().ToUpper();
            
            switch(opcion)
            {
                case ANYADIR:
                    
                    if (cantidad >= MAXIMO)
                    {
                        Console.WriteLine("Base de datos llena");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("¿Descripción? ");
                            tareas[cantidad].descripcion = 
                                Console.ReadLine();
                        }
                        while (tareas[cantidad].descripcion == "");
                        
                        do
                        {
                            Console.Write("¿Fecha límite (AAAA-MM-DD)? ");
                            tareas[cantidad].fecha = Console.ReadLine();
                        }
                        while (tareas[cantidad].fecha == "");
                        
                        Console.Write("¿Prioridad (1 a 5)? ");
                        string auxiliarPrioridad = Console.ReadLine();
                        if (auxiliarPrioridad != "")
                        {
                            tareas[cantidad].prioridad = 
                                Convert.ToByte(auxiliarPrioridad);
                        }
                        else
                        {
                            tareas[cantidad].prioridad = 3;
                        }
                        tareas[cantidad].completada = false;
                        cantidad++;
                    }
                    break;

                case VER:
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay datos para mostrar");
                    }
                    else
                    {
                        int contador = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if ( ! tareas[i].completada )
                            {
                                Console.Write(
                                    "{0}. Descripción: {1}, Fecha Límite: {2}",
                                    i+1, tareas[i].descripcion, tareas[i].fecha); 
                                Console.WriteLine(", Prioridad: {0}", 
                                    tareas[i].prioridad);
                                contador++;
                            }
                            
                            if ( contador == TAM_PAGINA)
                            {
                                Console.ReadLine();
                                contador = 0;
                            }
                        }
                    }
                    break;

                case MARCAR:
                    Console.Write("¿Registro a marcar como completado? ");
                    int numRegistro = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    if (numRegistro < 0 || numRegistro >= cantidad)
                    {
                        Console.WriteLine("Número de registro incorrecto");
                    }
                    else
                    {
                        Console.Write(
                            "{0}. Descripción: {1}, Fecha Límite: {2}",
                            numRegistro,tareas[numRegistro].descripcion, 
                            tareas[numRegistro].fecha); 
                        Console.WriteLine(", Prioridad: {0}", 
                            tareas[numRegistro].prioridad);
                        
                        Console.Write(
                            "¿Desea marcarla como completada? (s/n) ");
                        string eleccion = Console.ReadLine().ToUpper();
                        
                        if (eleccion == "S")
                        {
                            tareas[numRegistro].completada = true;
                            Console.WriteLine(
                                "Tarea marcada como completada");
                        }
                        else
                        {
                            Console.WriteLine(
                                "La tarea no ha sido marcada como completada");
                        }
                    }
                    break;

                case BUSCAR:
                    Console.Write("¿Texto a buscar? ");
                    string textoBuscar = Console.ReadLine().ToUpper();
                    bool encontrado = false;
                    int contadorBusqueda = 0;
                    
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (tareas[i].descripcion.ToUpper().Contains(textoBuscar)
                            || tareas[i].fecha.ToUpper().Contains(textoBuscar))
                        {
                            Console.Write(
                                "{0}. Descripción: {1}, Fecha Límite: {2}",
                                i+1, tareas[i].descripcion, tareas[i].fecha); 
                            Console.Write(", Prioridad: {0}", 
                                tareas[i].prioridad);
                            if (tareas[i].completada)
                                Console.Write(" (completada)");
                            Console.WriteLine();
                            encontrado = true;
                            contadorBusqueda ++;
                        }
                        
                        if (contadorBusqueda == TAM_PAGINA)
                        {
                            Console.ReadLine();
                            contadorBusqueda = 0;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("Texto no encontrado");
                    }
                    break;

                case MODIFICAR:
                    Console.WriteLine("¿Número de registro a modificar? ");
                    int numero = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    if (numero < 0 || numero >= cantidad)
                    {
                        Console.WriteLine("Número de registro incorrecto");
                    }
                    else
                    {
                        string datoAuxiliar;
                        Console.WriteLine("Descripción anterior: {0}",
                            tareas[numero].descripcion);
                        Console.Write("¿Nueva descripción? ");
                        datoAuxiliar = Console.ReadLine();
                        
                        if (datoAuxiliar != "")
                        {
                            tareas[numero].descripcion = datoAuxiliar;
                        }
                       
                        Console.WriteLine("Fecha límite anterior: {0}",
                            tareas[numero].fecha);
                        Console.Write("¿Nueva fecha? ");
                        datoAuxiliar = Console.ReadLine();
                        
                        if (datoAuxiliar != "")
                        {
                            tareas[numero].fecha = datoAuxiliar;
                        }
                        
                        Console.WriteLine("Prioridad anterior: {0}",
                            tareas[numero].prioridad);
                        Console.Write("¿Nueva prioridad? ");
                        datoAuxiliar = Console.ReadLine();
                        
                        if (datoAuxiliar != "")
                        {
                            tareas[numero].prioridad = 
                                Convert.ToByte(datoAuxiliar);
                        }
                    }
                    break;

                case BORRAR:
                    if (cantidad == 0)
                    {
                        Console.WriteLine("No hay ningún dato para borrar");
                    }
                    else
                    {
                        Console.Write("¿Número de registro a borrar? ");
                        int regBorrar = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                        if (regBorrar < 0 || regBorrar >= cantidad)
                        {
                            Console.WriteLine("Registro incorrecto");
                        }
                        else
                        {
                            Console.Write(
                                "{0}. Descripción: {1}, Fecha Límite: {2}",
                                regBorrar,tareas[regBorrar].descripcion, 
                                tareas[regBorrar].fecha); 
                            Console.WriteLine(", Prioridad: {0}", 
                                tareas[regBorrar].prioridad);
                            
                            Console.Write("¿Desea eliminarlo? (s/n) ");
                            string eleccion = Console.ReadLine().ToUpper();
                            
                            if (eleccion == "S")
                            {
                                for (int i=regBorrar; i < cantidad; i++)
                                {
                                    tareas[i] = tareas[i+1];
                                }
                                cantidad--;
                                Console.WriteLine("Registro borrado");
                            }
                            else
                            {
                                Console.WriteLine("Registro no borrado");
                            }
                        }
                    }
                    break;

                case ORDENAR:
                    for (int i=0; i < cantidad-1; i++)
                    {
                        for (int j=i+1; j < cantidad; j++)
                        {
                            if ((tareas[i].fecha.CompareTo(tareas[j].fecha) > 0) ||
                                ((tareas[i].fecha.CompareTo(tareas[j].fecha) == 0 )&& 
                                (tareas[i].prioridad < tareas[j].prioridad)))
                            {
                                Tarea datoTemporal = tareas[i];
                                tareas[i] = tareas[j];
                                tareas[j] = datoTemporal;
                            }
                        }
                    }
                    Console.WriteLine("Datos ordenados");
                    break;
                
                case SALIR:
                    terminado = true;
                    break;
                
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while ( ! terminado );
        Console.WriteLine("¡Hasta la vista!");
    }
}
