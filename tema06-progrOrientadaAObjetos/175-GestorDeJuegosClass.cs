// DAN 1DAW, retoques por Nacho

/*
175. Crea una nueva versión del gestor de juegos de ordenador (ejercicio 090), 
con los siguientes cambios:

- El dato base no debe ser un "struct", sino un "class".

- Debes descomponer el programa en funciones, tanto de cara a 
simplificar Main como de cara a eliminar código repetitivo.

- La opción 7 (ordenar) debe emplear "Array.Sort", para lo que deberás 
implementar la interfaz "IComparable". Recuerda usar el formato 
Array.Sort(array, inicio, cantidad), al tratarse de un array sobredimensionado.
*/

using System;

class Juego : IComparable<Juego>
{
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public string Categoria { get; set; }
    public string Plataforma { get; set; }
    public short Anyo { get; set; }
    public float Calificacion { get; set; }
    public string Comentarios { get; set; }

    public Juego(string titulo, string descripcion,
        string categoria, string plataforma, short anyo,
        float calificacion, string comentarios)
    {
        Titulo = titulo;
        Descripcion = descripcion;
        Categoria = categoria;
        Plataforma = plataforma;
        Anyo = anyo;
        Calificacion = calificacion;
        Comentarios = comentarios;
    }

    public override string ToString()
    {
        return String.Format("Título: {0}, Descripción: {1}," +
            " Categoría: {2}, Plataforma: {3}, Año: {4}," +
            " Calificación: {5}, Comentarios: {6}", Titulo, Descripcion,
             Categoria, Plataforma, Anyo, Calificacion, Comentarios);
    }

    public int CompareTo(Juego other)
    {
        int resultado = Titulo.CompareTo(other.Titulo);

        if (resultado == 0)
        {
            resultado = Plataforma.CompareTo(other.Plataforma);
        }

        return resultado;
    }

    public void Mostrar()
    {
        Console.WriteLine("Título: {0}.", Titulo);
        Console.WriteLine("Año: {0}.", Anyo);
        Console.WriteLine("Calificación: {0}.", Calificacion);
    }

    public bool Contiene(string textoBuscar)
    {
        if (((Titulo.ToLower()).Contains(textoBuscar.ToLower())) ||
                ((Categoria.ToLower()).Contains(textoBuscar.ToLower())) ||
                ((Plataforma.ToLower()).Contains(textoBuscar.ToLower())) ||
                ((Comentarios.ToLower()).Contains(textoBuscar.ToLower())))
            return true;
        else
            return false;

    }

    public void EliminarEspacios()
    {
        Descripcion = Descripcion.Trim();
        Categoria   = Categoria.Trim();
        Plataforma  = Plataforma.Trim();

        while (Descripcion.Contains("  "))
            Descripcion = Descripcion.Replace("  ", " ");

        while (Categoria.Contains("  "))
            Categoria = Categoria.Replace("  ", " ");

        while (Plataforma.Contains("  "))
            Plataforma = Plataforma.Replace("  ", " ");
    }
}

class GestorJuegos
{
    const int TAMANYO = 10000;
    const char ANYADIR = '1', MOSTRARDATOS = '2', MOSTRARJUEGOS = '3',
        BUSCAR = '4', MODIFICAR = '5', ELIMINARDATOS = '6', ORDENAR = '7',
        ELIMINARESPACIOS = '8', SALIR = 'S';

    static void Main()
    {
        int cantidad = 0;
        char opcion;
        bool terminar = false;

        Juego[] juegos = new Juego[TAMANYO];

        do
        {
            Console.WriteLine();
            Console.WriteLine("--- Menú ---");
            Console.WriteLine("{0}. Añadir un nuevo juego.", ANYADIR);
            Console.WriteLine("{0}. Mostrar todos los datos de un juego.", MOSTRARDATOS);
            Console.WriteLine("{0}. Mostrar todos los juegos por plataforma y categoría.", MOSTRARJUEGOS);
            Console.WriteLine("{0}. Buscar juegos que contengan un texto.", BUSCAR);
            Console.WriteLine("{0}. Modificar un registro.", MODIFICAR);
            Console.WriteLine("{0}. Eliminar un registro.", ELIMINARDATOS);
            Console.WriteLine("{0}. Ordenar datos alfabéticamente.", ORDENAR);
            Console.WriteLine("{0}. Eliminar espacios redundantes.", ELIMINARESPACIOS);
            Console.WriteLine("{0}. Salir del programa.", SALIR);
            Console.WriteLine("---      ---");

            opcion = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (opcion)
            {
                case SALIR:
                    terminar = true;
                    Console.WriteLine("Saliendo del programa. Adiós.");
                    break;

                // Añadir un juego nuevo
                case ANYADIR:
                    Anyadir(juegos, ref cantidad);
                    Continuar();
                    break;

                // Mostrar datos de un juego
                case MOSTRARDATOS:
                    MostrarTodosDatos(juegos, cantidad);
                    Continuar();
                    break;

                // Mostrar todos los juegos de una categoría o plataforma
                case MOSTRARJUEGOS:
                    MostrarPlataformaCategoria(juegos, cantidad);
                    Continuar();
                    break;

                // Buscar juegos que contengan un texto en cualquier campo de texto
                case BUSCAR:
                    Buscar(juegos, cantidad);
                    Continuar();
                    break;

                // Modificar un registro
                case MODIFICAR:
                    ModificarRegistro(juegos, cantidad);
                    Continuar();
                    break;

                // Eliminar un registro
                case ELIMINARDATOS:
                    Eliminar(juegos, ref cantidad);
                    Continuar();
                    break;

                // Ordenar un registro
                case ORDENAR:
                    Ordenar(juegos, cantidad);
                    Continuar();
                    break;

                // Eliminar espacios redundantes
                case ELIMINARESPACIOS:
                    EliminarEspacios(juegos, cantidad);
                    Continuar();
                    break;
            }
        }
        while (!terminar);
    }

    static string Pedir(string campo)
    {
        Console.Write("{0}: ", campo);
        return Console.ReadLine();
    }

    static string PedirNoVacio(string aviso)
    {
        string respuesta;
        do
        {
            respuesta = Pedir(aviso);
            if (respuesta == "")
                Console.WriteLine("No debe estar vacío");
        }
        while (respuesta == "");
        return respuesta;
    }

    static string Modificar(string nombreCampo, string valorAnterior)
    {
        string respuesta = Pedir("Dime el nuevo valor para: " +
            nombreCampo + " (antes era: " + valorAnterior + ")");
        return respuesta != "" ? respuesta : valorAnterior;
    }

    static void MostrarDatos(Juego[] juegos, int cantidad, int posicionInicial = 0)
    {
        Console.WriteLine("Mostrando datos:");

        for (int i = posicionInicial; i < cantidad; i++)
        {
            Console.WriteLine((i + 1) + ", " + juegos[i]);
        }
    }

    static void Continuar()
    {
        Console.WriteLine("Pulsa Intro para continuar.");
        Console.ReadLine();
    }

    static void Anyadir(Juego[] juegos, ref int cantidad)
    {
        string tituloTemp, descripcionTemp, categoriaTemp,
            plataformaTemp, comentariosTemp;
        short anyoTemp;
        float calificacionTemp;

        Console.WriteLine("Opción \"Añadir un nuevo juego\" seleccionada.");
        if (cantidad > TAMANYO)
        {
            Console.WriteLine("Error. No hay más espacio libre.");
        }
        else
        {
            tituloTemp = PedirNoVacio("Escribe el título del juego");
            descripcionTemp = PedirNoVacio("Escribe la descripción del juego");
            categoriaTemp = PedirNoVacio("Escribe la categoría del juego");
            plataformaTemp = Pedir("Escribe la plataforma del juego");

            // Añadir año
            do
            {
                anyoTemp = Convert.ToInt16(Pedir("Escribe el año del juego " +
                    "(Debe estar entre 1940 y 2100)"));

                if ((anyoTemp < 1940) || (anyoTemp > 2100))
                {
                    Console.WriteLine("Error. El año debe estar entre " +
                        "1940 y 2100, ambos inclusive.");
                }
            }
            while ((anyoTemp < 1940) || (anyoTemp > 2100));

            // Añadir calificación
            do
            {
                calificacionTemp = Convert.ToSingle(Pedir("Escribe la calificación del juego " +
                    "(Debe estar entre 0 y 10, ambos inclusive.)"));

                if ((calificacionTemp < 0) || (calificacionTemp > 10))
                {
                    Console.WriteLine("Error. La calificación debe ser entre " +
                        "0 y 10, ambos inclusive.");
                }
            }
            while ((calificacionTemp < 0) || (calificacionTemp > 10));

            comentariosTemp = Pedir("Escribe un comentario sobre el juego");

            juegos[cantidad] = new Juego(tituloTemp, descripcionTemp, categoriaTemp,
                plataformaTemp, anyoTemp, calificacionTemp, comentariosTemp);

            Console.WriteLine("Datos del juego guardados con éxito.");
            cantidad++;
        }
    }

    static void MostrarTodosDatos(Juego[] juegos, int cantidad)
    {
        int posicion;
        bool encontrado;

        Console.WriteLine("Opción \"Mostrar todos los datos de un juego\" seleccionada.");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            Console.WriteLine("Puedes buscar un juego de dos maneras distintas:");
            Console.WriteLine("1. A partir de su número de registro.");
            Console.WriteLine("2. A partir de su título exacto.");
            Console.Write("Elige tu opción: ");

            byte opcionMostrar = Convert.ToByte(Console.ReadLine());

            switch (opcionMostrar)
            {
                // Mostrar datos por registro
                case 1:

                    Console.WriteLine("Has elegido la opción \"A partir de " +
                        "su número de registro\".");
                    Console.Write("Escribe el número de registro: ");
                    posicion = Convert.ToInt32(Console.ReadLine());

                    if (posicion <= 0 || posicion > cantidad)
                    {
                        Console.WriteLine("Error. Número de registro incorrecto.");
                    }
                    else
                    {
                        // Muestra desde posicion-1 hasta posicion
                        MostrarDatos(juegos, posicion, posicion - 1);
                    }

                    break;

                // Mostrar datos por título exacto
                case 2:

                    Console.WriteLine("Has elegido la opción \"A partir de " +
                        "su título exacto\".");
                    Console.Write("Escribe su título exacto: ");
                    string tituloTemp = Console.ReadLine().ToLower();

                    posicion = -1;
                    encontrado = false;
                    for (int i = 0; i < cantidad && encontrado == false; i++)
                    {
                        if (juegos[i].Titulo.ToLower() == tituloTemp)
                        {
                            encontrado = true;
                            posicion = i;
                        }
                    }

                    if (encontrado)
                    {
                        // Muestra desde posicion hasta posicion+1
                        MostrarDatos(juegos, posicion + 1, posicion);
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado ninguna coincidencia.");
                    }

                    break;
            }
        }
    }

    static void MostrarPlataformaCategoria(Juego[] juegos, int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Mostrar todos los juegos " +
                        "por plataforma y categoría\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            string plataformaTemp = Pedir(
                "Plataforma de los juegos para mostrar").ToLower();

            string categoriaTemp = Pedir(
                "Categoría de los juegos para mostrar").ToLower();

            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)
            {
                if (i % 22 == 21)
                {
                    Console.WriteLine("Pulsa Intro para continuar.");
                    Console.ReadLine();
                }

                if ((juegos[i].Plataforma.ToLower() == plataformaTemp) &&
                    (juegos[i].Categoria.ToLower() == categoriaTemp))
                {
                    Console.WriteLine("Juego número: {0}.", i + 1);
                    juegos[i].Mostrar();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se han encontrado juegos que pertenezcan" +
                    " a la plataforma \"{0}\" y a la categoría \"{1}\"",
                    plataformaTemp, categoriaTemp);
            }
        }
    }

    static void Buscar(Juego[] juegos, int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Buscar juegos " +
                        "que contengan un texto\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            string textoBuscar = Pedir("Escribe el texto a buscar").ToLower();
            int cantidadEncontrados = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (juegos[i].Contiene(textoBuscar))
                {
                    Console.WriteLine("Juego número: {0}.", i + 1);
                    juegos[i].Mostrar();
                    cantidadEncontrados ++;
                }
                if (cantidadEncontrados % 22 == 21)
                {
                    Console.WriteLine("Pulsa Intro para continuar.");
                    Console.ReadLine();
                }
            }

            if (cantidadEncontrados == 0)
            {
                Console.WriteLine("No se ha encontrado ninguna coincidencia.");
            }
        }
    }

    static void ModificarRegistro(Juego[] juegos, int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Modificar un registro\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            int posicion = Convert.ToInt32(Pedir("Escribe el número del registro " +
                "que quieres modificar"));

            if (posicion <= 0 || posicion > cantidad)
            {
                Console.WriteLine("Número de registro no válido.");
            }
            else
            {
                Console.WriteLine("Mostrando datos anteriores de cada campo " +
                    "en el registro número: {0}", posicion);
                Console.WriteLine("Presiona Intro para no modificar el campo.");
                Console.WriteLine("Escribe para modificar el campo.");

                juegos[posicion - 1].Titulo =
                    Modificar("Título", juegos[posicion - 1].Titulo);

                juegos[posicion - 1].Descripcion =
                    Modificar("Descripción", juegos[posicion - 1].Descripcion);

                juegos[posicion - 1].Categoria =
                    Modificar("Categoría", juegos[posicion - 1].Categoria);

                juegos[posicion - 1].Plataforma =
                    Modificar("Plataforma", juegos[posicion - 1].Plataforma);

                short anyoTemp = Convert.ToInt16(
                    Modificar("Año", juegos[posicion - 1].Anyo.ToString()));

                if (anyoTemp < 1940 || anyoTemp > 2100)
                    Console.WriteLine("Error. Debe estar entre 1940 y 2100.");
                else
                    juegos[posicion - 1].Anyo = anyoTemp;

                float calificacionTemp = Convert.ToSingle(
                    Modificar("Calificación", juegos[posicion - 1].Anyo.ToString("N1")));

                if (calificacionTemp < 0 || calificacionTemp > 10)
                    Console.WriteLine("Error. Debe estar entre 0 y 10.");
                else
                    juegos[posicion - 1].Calificacion = calificacionTemp;

                juegos[posicion - 1].Comentarios =
                    Modificar("Comentario", juegos[posicion - 1].Comentarios);
            }
        }
    }

    static void Eliminar(Juego[] juegos, ref int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Eliminar un registro\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            Console.Write("Escribe el número del registro a eliminar: ");
            int posicion = Convert.ToInt32(Console.ReadLine());

            if (posicion <= 0 || posicion > cantidad)
            {
                Console.WriteLine("Error. Número de registro incorrecto.");
            }
            else
            {
                MostrarDatos(juegos, posicion, posicion - 1);

                Console.WriteLine("¿Deseas eliminar este registro?");
                Console.WriteLine("Para confirmar, escribe \"s\".");
                Console.WriteLine("Para cancelar, presiona cualquier otra tecla.");
                Console.Write("Elección: ");

                if (Console.ReadLine().ToLower() != "s")
                {
                    Console.WriteLine("Cancelado");
                }
                else
                {
                    for (int i = posicion - 1; i < cantidad; i++)
                    {
                        juegos[i] = juegos[i + 1];
                    }
                    cantidad--;

                    Console.WriteLine("El registro número: {0} " +
                        "se ha eliminado con éxito.", posicion);
                }
            }
        }
    }

    static void Ordenar(Juego[] juegos, int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Ordenar datos alfabéticamente\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            Array.Sort(juegos, 0, cantidad);
            Console.WriteLine("Se han ordenado con éxito.");
        }
    }

    static void EliminarEspacios(Juego[] juegos, int cantidad)
    {
        Console.WriteLine("Has elegido la opción \"Eliminar espacios redundantes\".");

        if (cantidad == 0)
        {
            AvisarNoHayDatos();
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                juegos[i].EliminarEspacios();
            }
            Console.WriteLine("Espacios redundantes eliminados con éxito.");
        }
    }

    private static void AvisarNoHayDatos()
    {
        Console.WriteLine("Error. No hay ningún juego guardado. " +
            "Prueba a guardar algún juego primero.");
    }
}
