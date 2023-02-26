//Francis (...) - 1ºDAM Semipresencial

/*

187. Crea una nueva versión del ejercicio 091 (array de struct de ciudades), en 
la que no se utilice un array para los datos, sino una lista con tipo. Debes 
partir de la "solución oficial" y respetar su estructura (seguir usando 
"struct" y no dividir el cuerpo en funciones), aunque la forma de añadir al 
final, insertar y borrar será distinta, al tratarse de una lista.

 */

using System;
using System.Collections.Generic;

class Ejercicio187
{
    struct TipoCiudad
    {
        public string nombre;
        public string pais;
        public int poblacion;
    }

    enum opcionesMenu
    {
        SALIR, ANYADIR, MOSTRAR, BUSCAR,
        EDITAR, INSERTAR, ELIMINAR, ORDENAR, ERRORES
    };

    static void Main()
    {
        List<TipoCiudad> ciudades = new List<TipoCiudad>();
        byte opcion;
        do
        {
            Console.WriteLine((int)opcionesMenu.ANYADIR
                + " Añadir una nueva ciudad");
            Console.WriteLine((int)opcionesMenu.MOSTRAR
                + " Mostrar todas las ciudades");
            Console.WriteLine((int)opcionesMenu.BUSCAR
                + " Buscar ciudades por texto");
            Console.WriteLine((int)opcionesMenu.EDITAR
                + " Editar un registro");
            Console.WriteLine((int)opcionesMenu.INSERTAR
                + " Insertar un registro, en cierta posición");
            Console.WriteLine((int)opcionesMenu.ELIMINAR
                + " Eliminar un registro");
            Console.WriteLine((int)opcionesMenu.ORDENAR
                + " Ordenar los datos");
            Console.WriteLine((int)opcionesMenu.ERRORES
                + " Encontrar posibles errores ortográficos");
            Console.WriteLine((int)opcionesMenu.SALIR
                + " Salir del programa");

            opcion = Convert.ToByte(Console.ReadLine());
            switch (opcion)
            {
                /*
                Añadir una nueva ciudad. El nombre y el país no pueden estar 
                vacíos. Una población desconocida (introducida en blanco, 
                pulsando Intro sin teclear nada) debe almacenarse como un 0.
                */
                case (int)opcionesMenu.ANYADIR:

                    TipoCiudad tc;

                    do
                    {
                        Console.WriteLine("Nombre: ");
                        tc.nombre = Console.ReadLine();
                    }
                    while (tc.nombre == "");

                    do
                    {
                        Console.WriteLine("País: ");
                        tc.pais = Console.ReadLine();
                    }
                    while (tc.pais == "");

                    Console.WriteLine("Población: ");
                    string respuesta = (Console.ReadLine());
                    if (respuesta == "")
                    {
                        tc.poblacion = 0;
                    }
                    else
                    {
                        tc.poblacion = Convert.ToInt32(respuesta);
                    }

                    ciudades.Add(tc);
                    break;

                /*
                Mostrar todas las ciudades, cada ciudad en una línea (número de 
                registro, nombre y país, como en "1- Alicante, España"). Si el 
                nombre de la ciudad tiene más de 20 caracteres, debe mostrar 
                los primeros 20 caracteres seguidos de "...". Si el nombre del 
                país tiene más de 40 caracteres, debe mostrarlo truncado a 40 
                caracteres y sin espacios intermedios. Debes hacer una pausa 
                después de cada 24 filas.Si el usuario presiona Intro como 
                respuesta a esa pausa y no escribe ningún texto, se mostrarán 
                los siguientes 24 datos, pero si teclea "fin" y luego presiona 
                Intro, dejarán de mostrarse datos.
                */
                case (int)opcionesMenu.MOSTRAR:

                    int tope = 24;
                    bool seguir = true;
                    int pos = 0;
                    while (pos < ciudades.Count && seguir)
                    {
                        string nombre = ciudades[pos].nombre;
                        if (nombre.Length > 20)
                            nombre = nombre.Substring(0, 20) + "...";

                        string pais = ciudades[pos].pais;
                        if (pais.Length > 40)
                            pais = pais.Substring(0, 40).Replace(" ", "");

                        Console.WriteLine("{0}- {1}, {2}", pos + 1, nombre, pais);

                        if (pos % tope == tope - 1)
                        {
                            respuesta = Console.ReadLine();
                            if (respuesta != "fin")
                            {
                                seguir = false;
                            }
                        }
                        pos++;
                    }
                    break;


                /*
                Buscar ciudades que contengan un determinado texto en su nombre 
                o el nombre del país (búsqueda parcial, sin distinción de 
                mayúsculas y minúsculas). Debe mostrar el número de registro, 
                el nombre, el país y la población, en la misma línea, haciendo 
                una pausa después de cada 24 filas. Si no se había introducido 
                la población, debe mostrar "Población desconocida" en lugar de 
                0.
                */
                case (int)opcionesMenu.BUSCAR:

                    Console.WriteLine("Buscar ciudades. Introduce el texto: ");
                    string textoBuscar = Console.ReadLine();
                    for (int i = 0; i < ciudades.Count; i++)
                    {
                        if ((ciudades[i].nombre.ToLower().Contains(textoBuscar.ToLower()))
                            || (ciudades[i].pais.ToLower().Contains(textoBuscar.ToLower())))
                        {
                            Console.Write("{0}- {1}, {2},",
                                i + 1, ciudades[i].nombre, ciudades[i].pais);
                            if (ciudades[i].poblacion == 0)
                            {
                                Console.WriteLine("población: desconocida");
                            }
                            else
                            {
                                Console.WriteLine("población: {0}", ciudades[i].poblacion);
                            }

                        }
                        if (i % 24 == 23)
                        {
                            Console.ReadLine();
                        }
                    }
                    break;

                /*
                Editar un registro: pide al usuario su número, muestra el valor 
                anterior de cada campo y permite que el usuario presione Intro 
                si decide no modificar ninguno de los datos. Se le debe volver 
                a pedir si introduce un número de registro incorrecto, tantas 
                veces como sea necesario(pero puede escribir 0 para indicar que 
                no desea modificar ningún registro). Antes de almacenar los 
                datos, se deben eliminar los espacios iniciales, los espacios 
                finales y los espacios duplicados de cada campo.
                */
                case (int)opcionesMenu.EDITAR:

                    int posicionEditar;

                    do
                    {
                        Console.WriteLine("Editar. Número de registro (0 para cancelar): ");
                        posicionEditar = Convert.ToInt32(Console.ReadLine());
                    }
                    while (posicionEditar < 0 || posicionEditar > ciudades.Count);

                    if (posicionEditar == 0)
                    {
                        Console.WriteLine("Cancelado");
                    }
                    else
                    {
                        posicionEditar = posicionEditar - 1;

                        TipoCiudad tc2 = ciudades[posicionEditar];

                        Console.WriteLine("Nombre: " + tc2.nombre);
                        string cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            cambio = cambio.Trim();
                            while (cambio.Contains("  "))
                            {
                                cambio = cambio.Replace("  ", " ");
                            }
                            tc2.nombre = cambio;
                        }

                        Console.WriteLine("País: " + tc2.pais);
                        cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            cambio = cambio.Trim();
                            while (cambio.Contains("  "))
                            {
                                cambio = cambio.Replace("  ", " ");
                            }
                            tc2.pais = cambio;
                        }

                        Console.WriteLine("Población: " + tc2.poblacion);
                        cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            tc2.poblacion = Convert.ToInt32(cambio);
                        }

                        ciudades[posicionEditar] = tc2;
                    }

                    break;

                /*
                Insertar un registro, en la posición indicada por el usuario. 
                Se le debe avisar (pero no volver a preguntar) si introduce un 
                número de registro incorrecto o si el array está lleno. Valida 
                los datos como en la opción 1.
                */
                case (int)opcionesMenu.INSERTAR:

                    Console.WriteLine("Insertar un registro. Posición: ");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine());
                    if (posicionInsertar > ciudades.Count)
                    {
                        Console.WriteLine("Número de registro no válido");
                    }

                    else
                    {
                        TipoCiudad tc3 = ciudades[posicionInsertar];

                        do
                        {
                            Console.WriteLine("Nombre: ");
                            tc3.nombre = Console.ReadLine();
                        }
                        while (ciudades[posicionInsertar].nombre == "");

                        do
                        {
                            Console.WriteLine("País: ");
                            tc3.pais = Console.ReadLine();
                        }
                        while (ciudades[posicionInsertar].pais == "");

                        Console.WriteLine("Población: ");
                        string leer1 = Console.ReadLine();
                        if (leer1 == "")
                        {
                            tc3.poblacion = 0;
                        }
                        else
                        {
                            tc3.poblacion = Convert.ToInt32(
                                Console.ReadLine());
                        }

                        ciudades.Insert(posicionInsertar, tc3);
                    }
                    break;

                /*
                Eliminar un registro, en la posición detallada por el usuario. 
                Se le debe advertir (pero no se le debe volver a pedir) si 
                introduce un número de registro incorrecto. El programa debe 
                mostrar el registro que se eliminará y solicitar confirmación 
                antes de la eliminación. Además, debe avisar al usuario si se 
                ha borrado el último dato que quedaba.
                */
                case (int)opcionesMenu.ELIMINAR:

                    Console.WriteLine("Eliminar registro.Número de registro: ");
                    int posicionEliminar = Convert.ToInt32(Console.ReadLine());
                    posicionEliminar = posicionEliminar - 1;
                    if ((posicionEliminar < 0) || (posicionEliminar > ciudades.Count - 1))
                    {
                        Console.WriteLine("Número de registro no válido");
                    }
                    else
                    {
                        Console.WriteLine("{0}-{1},{2}",
                            posicionEliminar,
                            ciudades[posicionEliminar].nombre,
                            ciudades[posicionEliminar].pais);
                        Console.WriteLine("¿Seguro que quieres eliminar este registro de forma permanente (s/n)?");
                        string contestacion = Console.ReadLine();
                        if (contestacion.ToLower() == "s")
                        {
                            if (ciudades.Count == 0)
                            {
                                Console.WriteLine("Se ha borrado el último dato que quedaba");
                            }
                            else
                            {
                                ciudades.RemoveAt(posicionEliminar);
                            }
                        }
                    }

                    break;

                /*
                Ordenar los datos. Se le preguntará al usuario si desea ordenar 
                en función del nombre de la ciudad o del nombre del país, y el 
                programa actuará en consecuencia.
                */
                case (int)opcionesMenu.ORDENAR:

                    Console.WriteLine("¿Ordenar por nombre o país (n/p)?");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1.ToLower() == "n")
                    {
                        for (int i = 0; i < ciudades.Count - 1; i++)
                        {
                            for (int j = i + 1; j < ciudades.Count; j++)
                            {
                                if (String.Compare(ciudades[i].nombre,
                                    ciudades[j].nombre, true) > 0)
                                {
                                    TipoCiudad datotemporal = ciudades[i];
                                    ciudades[i] = ciudades[j];
                                    ciudades[j] = datotemporal;
                                }
                            }
                        }
                    }
                    else if (respuesta1.ToLower() == "p")
                    {
                        for (int i = 0; i < ciudades.Count - 1; i++)
                        {
                            for (int j = 0; j < ciudades.Count; j++)
                            {
                                if (String.Compare(ciudades[i].pais, ciudades[j].pais, true) > 0)
                                {
                                    TipoCiudad datotemporal = ciudades[i];
                                    ciudades[i] = ciudades[j];
                                    ciudades[j] = datotemporal;
                                }
                            }
                        }
                    }
                    break;

                /*
                Encontrar posibles errores ortográficos: mostrará los registros 
                que contienen dos símbolos de puntuación consecutivos (.. o ,,) 
                o una letra repetida tres veces (como Misssissippi).
                */
                case (int)opcionesMenu.ERRORES:
                    bool problemaEncontrado = false;
                    for (int i = 0; i < ciudades.Count; i++)
                    {
                        if (ciudades[i].nombre.Contains(".."))
                            problemaEncontrado = true;

                        if (ciudades[i].nombre.Contains(",,"))
                            problemaEncontrado = true;

                        for (int j = 0; j < ciudades[i].nombre.Length - 2; j++)
                        {
                            if ((ciudades[i].nombre[j] == ciudades[i].nombre[j + 1])
                               && (ciudades[i].nombre[j] == ciudades[i].nombre[j + 2]))
                            {
                                problemaEncontrado = true;
                            }
                        }

                        if (problemaEncontrado)
                        {
                            Console.WriteLine("Posibles errores encontrados: "
                                + ciudades[i].nombre);
                            problemaEncontrado = false;
                        }
                    }
                    break;

                case (int)opcionesMenu.SALIR:
                    Console.WriteLine("Fin del programa");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        while (opcion != (int)opcionesMenu.SALIR);
    }
}
