/*91. Ciudades (examen de 2017-2018)

Crea un programa de C# que pueda almacenar hasta 20000 ciudades. Para cada 
ciudad, debe permitir al usuario almacenar la siguiente información:

• Nombre (por ejemplo, Alicante)

• País (por ejemplo, España)

• Población (por ejemplo, 300.000)

El programa debe permitir al usuario realizar las siguientes operaciones:

1 - Añadir una nueva ciudad. El nombre y el país no pueden estar vacíos. Una 
población desconocida (introducida en blanco, pulsando Intro sin teclear nada) 
debe almacenarse como un 0.

2 - Mostrar todas las ciudades, cada ciudad en una línea (número de registro, 
nombre y país, como en "1- Alicante, España"). Si el nombre de la ciudad tiene 
más de 20 caracteres, debe mostrar los primeros 20 caracteres seguidos de 
"...". Si el nombre del país tiene más de 40 caracteres, debe mostrarlo 
truncado a 40 caracteres y sin espacios intermedios. Debes hacer una pausa 
después de cada 24 filas. Si el usuario presiona Intro como respuesta a esa 
pausa y no escribe ningún texto, se mostrarán los siguientes 24 datos, pero si 
teclea "fin" y luego presiona Intro, dejarán de mostrarse datos.

3 - Buscar ciudades que contengan un determinado texto en su nombre o el nombre 
del país (búsqueda parcial, sin distinción de mayúsculas y minúsculas). Debe 
mostrar el número de registro, el nombre, el país y la población, en la misma 
línea, haciendo una pausa después de cada 24 filas. Si no se había introducido 
la población, debe mostrar "Población desconocida" en lugar de 0.

4 - Editar un registro: pide al usuario su número, muestra el valor anterior de 
cada campo y permite que el usuario presione Intro si decide no modificar 
ninguno de los datos. Se le debe volver a pedir si introduce un número de 
registro incorrecto, tantas veces como sea necesario (pero puede escribir 0 
para indicar que no desea modificar ningún registro). Antes de almacenar los 
datos, se deben eliminar los espacios iniciales, los espacios finales y los 
espacios duplicados de cada campo.

5 - Insertar un registro, en la posición indicada por el usuario. Se le debe 
avisar (pero no volver a preguntar) si introduce un número de registro 
incorrecto o si el array está lleno. Valida los datos como en la opción 1.

6 - Eliminar un registro, en la posición detallada por el usuario. Se le debe 
advertir (pero no se le debe volver a pedir) si introduce un número de registro 
incorrecto. El programa debe mostrar el registro que se eliminará y solicitar 
confirmación antes de la eliminación. Además, debe avisar al usuario si se ha 
borrado el último dato que quedaba.

7 - Ordenar los datos. Se le preguntará al usuario si desea ordenar en función 
del nombre de la ciudad o del nombre del país, y el programa actuará en 
consecuencia.

8 - Encontrar posibles errores ortográficos: mostrará los registros que 
contienen dos símbolos de puntuación consecutivos (.. o ,,) o una letra 
repetida tres veces (como Misssissippi).

0 - Salir (como no almacenamos la información, se perderá)
*/

//Noelia (...), retoques por Nacho

using System;

class Ejercicio91
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
        const int CANTIDAD_MAX = 20000;
        TipoCiudad[] ciudades = new TipoCiudad[CANTIDAD_MAX];
        int cantidad = 0;
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
                    if (cantidad >= CANTIDAD_MAX)
                    {
                        Console.WriteLine("Biblioteca llena");
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Nombre: ");
                            ciudades[cantidad].nombre = Console.ReadLine();
                        }
                        while (ciudades[cantidad].nombre == "");

                        do
                        {
                            Console.WriteLine("País: ");
                            ciudades[cantidad].pais = Console.ReadLine();
                        }
                        while (ciudades[cantidad].pais == "");

                        Console.WriteLine("Población: ");
                        string respuesta = (Console.ReadLine());
                        if (respuesta == "")
                        {
                            ciudades[cantidad].poblacion = 0;
                        }
                        else
                        {
                            ciudades[cantidad].poblacion = Convert.ToInt32(respuesta);
                        }
                        cantidad++;
                    }
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
                    while (pos < cantidad && seguir)
                    {
                        string nombre = ciudades[pos].nombre;
                        if (nombre.Length > 20)
                            nombre = nombre.Substring(0, 20) + "...";

                        string pais = ciudades[pos].pais;
                        if (pais.Length > 40)
                            pais = pais.Substring(0, 40).Replace(" ", "");

                        Console.WriteLine("{0}- {1}, {2}", pos+1, nombre, pais);

                        if (pos % tope == tope-1)
                        {
                            string respuesta = Console.ReadLine();
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
                    for (int i = 0; i < cantidad; i++)
                    {
                        if ((ciudades[i].nombre.ToLower().Contains(textoBuscar.ToLower()))
                            || (ciudades[i].pais.ToLower().Contains(textoBuscar.ToLower())))
                        {
                            Console.Write("{0}- {1}, {2},", 
                                i+1, ciudades[i].nombre, ciudades[i].pais);
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
                    while (posicionEditar < 0 || posicionEditar > cantidad);
                    
                    posicionEditar = posicionEditar - 1;
                    if (posicionEditar == 0)
                    {
                        Console.WriteLine("Cancelado");
                    }
                    else
                    {
                        Console.WriteLine("Nombre: " + ciudades[posicionEditar].nombre);
                        string cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            cambio = cambio.Trim();
                            while (cambio.Contains("  "))
                            {
                                cambio = cambio.Replace("  ", " ");
                            }
                            ciudades[posicionEditar].nombre = cambio;
                        }

                        Console.WriteLine("País: " + ciudades[posicionEditar].pais);
                        cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            cambio = cambio.Trim();
                            while (cambio.Contains("  "))
                            {
                                cambio = cambio.Replace("  ", " ");
                            }
                            ciudades[posicionEditar].pais = cambio;
                        }

                        Console.WriteLine("Población: " + ciudades[posicionEditar].poblacion);
                        cambio = Console.ReadLine();
                        if (cambio != "")
                        {
                            ciudades[posicionEditar].poblacion = Convert.ToInt32(cambio);
                        }
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
                    if (posicionInsertar > cantidad)
                    {
                        Console.WriteLine("Número de registro no válido");
                    }
                    if (posicionInsertar > CANTIDAD_MAX)
                    {
                        Console.WriteLine("No puede almacenar más datos.Array lleno");
                    }
                    else
                    {
                        for (int i = cantidad; i < posicionInsertar; i++)
                        {
                            ciudades[i] = ciudades[i - 1];
                        }
                        cantidad++;

                        do
                        {
                            Console.WriteLine("Nombre: ");
                            ciudades[posicionInsertar].nombre = Console.ReadLine();

                        }
                        while (ciudades[posicionInsertar].nombre == "");

                        do
                        {
                            Console.WriteLine("País: ");
                            ciudades[posicionInsertar].pais = Console.ReadLine();
                        }
                        while (ciudades[posicionInsertar].pais == "");

                        Console.WriteLine("Población: ");
                        string leer1 = (Console.ReadLine());
                        if (leer1 == "")
                        {
                            ciudades[posicionInsertar].poblacion = 0;
                        }
                        else
                        {
                            ciudades[posicionInsertar].poblacion = Convert.ToInt32(
                                Console.ReadLine());
                        }
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
                    if ((posicionEliminar < 0) || (posicionEliminar > cantidad - 1))
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
                            for (int i = posicionEliminar; i < cantidad; i++)
                            {
                                ciudades[i] = ciudades[i + 1];
                            }
                            cantidad--;
                            if (cantidad == 0)
                            {
                                Console.WriteLine("Se ha borrado el último dato que quedaba");
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
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = i + 1; j < cantidad; j++)
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
                        for (int i = 0; i < cantidad - 1; i++)
                        {
                            for (int j = 0; j < cantidad; j++)
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
                    for (int i = 0; i < cantidad; i++)
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

