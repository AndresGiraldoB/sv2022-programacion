using System;
/* 114. Crea una versión actualizada de la base de datos de ciudades (ejercicio 091),
 * descomponiéndola en funciones. 
 * Puedes tomar ideas mirando la solución compartida al ejercicio 111 
 * (biblioteca, con funciones) o del video 052 de YouTube. */

//Noelia (...)

class Ejercicio114
{
    struct Libro
    {
        public string titulo;
        public string autor;
        public short anyoPubli;
    }

    const string SALIR = "S",
            ANADIR = "1", VERTODO = "2", BUSCARTITULO = "3",
            BUSCARFECHA = "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";
    const int MAXIMO = 25000;
    const byte BLOQUE = 18;

    static void Main()
    {
        Libro[] libros = new Libro[MAXIMO];
        ushort cantidad = 0;
        string opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();
            switch (opcion)
            {
                case ANADIR:
                    Anyadir(libros, ref cantidad);
                    break;

                case VERTODO:
                    VerTodo(libros, cantidad);
                    break;

                case BUSCARTITULO:
                    BuscarTitulo(libros, cantidad);
                    break;

                case BUSCARFECHA:
                    BuscarFecha(libros, cantidad);
                    break;

                case MODIFICAR:
                    Modificar(libros, cantidad);
                    break;

                case BORRAR:
                    Borrar(libros, ref cantidad);
                    break;

                case ORTOGRAFIA:
                    ComprobarOrtografia(libros, cantidad);
                    break;

                case SALIR:
                    Console.WriteLine("¡Adios!");
                    break;

                default:
                    Console.WriteLine("Opcion no válida!");
                    break;
            }
        }
        while (opcion != SALIR);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("===============MENU===============");
        Console.WriteLine(ANADIR + "-Añadir un libro");
        Console.WriteLine(VERTODO + "-Mostrar todos los libros");
        Console.WriteLine(BUSCARTITULO + "-Buscar por título");
        Console.WriteLine(BUSCARFECHA + "-Buscar entre fechas");
        Console.WriteLine(MODIFICAR + "-Modificar libro");
        Console.WriteLine(BORRAR + "-Borrar libro");
        Console.WriteLine(ORTOGRAFIA + "-Revisar ortografía");
        Console.WriteLine(SALIR + "-Salir");
        Console.WriteLine();
    }

    static string PedirOpcion()
    {
        Console.Write("Opción?: ");
        return Console.ReadLine().ToUpper();
    }

    static void Anyadir(Libro[] libros, ref ushort cantidad)
    {
        if (cantidad >= MAXIMO)
        {
            Console.WriteLine("Biblioteca llena");
        }
        else
        {
            libros[cantidad].titulo = PedirNoVacio("Titulo?: ");
            libros[cantidad].autor = PedirNoVacio("Autor?: ");

            // Año -1 si no se escribe nada
            string anyo = Pedir("Año de publicacion?: ");
            if (anyo == "")
            {
                libros[cantidad].anyoPubli = -1;
            }
            else
            {
                libros[cantidad].anyoPubli = Convert.ToInt16(anyo);
            }

            cantidad++;

            //Ordeno titulos alfabeticamente
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = i + 1; j < cantidad; j++)
                {
                    if (string.Compare(libros[i].titulo,
                        libros[j].titulo, true) > 0)
                    {
                        Libro aux = libros[i];
                        libros[i] = libros[j];
                        libros[j] = aux;
                    }
                }
            }
        }
    }

    static void VerTodo(Libro[] libros, ushort cantidad)
    {
        if (cantidad == 0)
            Console.WriteLine("Sin datos");
        else
            for (int i = 0; i < cantidad; i++)
            {
                MostrarRegistro(libros, i);

                if ((i + 1) % BLOQUE == 0)
                {
                    Console.ReadLine();
                }
            }
        Console.WriteLine();
    }

    static void BuscarTitulo(Libro[] libros, ushort cantidad)
    {
        Console.Write("BUSCAR. Titulo?: ");
        string buscar = Console.ReadLine();
        if (buscar != "")
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (libros[i].titulo.ToUpper().Contains(buscar.ToUpper())
                    || libros[i].autor.ToUpper().Contains(buscar.ToUpper()))
                {
                    MostrarRegistro(libros, i);
                }
            }
        }
    }

    static void BuscarFecha(Libro[] libros, ushort cantidad)
    {
        Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
        Console.Write("Entre año: ");
        ushort fecha1 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Y año: ");
        ushort fecha2 = Convert.ToUInt16(Console.ReadLine());

        // Invertir fechas si están al revés
        ushort fechaInicial = fecha1 > fecha2 ? fecha1 : fecha2;
        ushort fechaFinal = fecha1 < fecha2 ? fecha1 : fecha2;

        for (int i = 0; i < cantidad; i++)
        {
            if (libros[i].anyoPubli >= fechaInicial &&
                    libros[i].anyoPubli <= fechaFinal)
            {
                MostrarRegistro(libros, i);
            }
        }
    }

    static void Modificar(Libro[] libros, ushort cantidad)
    {
        Console.Write("Número de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= cantidad)
        {
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                    libros[numRegistro - 1].autor,
                    libros[numRegistro - 1].anyoPubli);

            string cadenaAux = Pedir("Titulo?: ").Trim();
            if (cadenaAux != "")
                libros[numRegistro - 1].titulo = cadenaAux;

            cadenaAux = Pedir("Autor?:").Trim();
            if (cadenaAux != "")
                libros[numRegistro - 1].autor = cadenaAux;

            libros[cantidad].anyoPubli =
                Convert.ToInt16(Pedir("Año de publicacion?: "));

            // Avisos de mayúsculas, minúsculas, espacios
            if (EsMayusculas(libros[numRegistro - 1].autor))
            {
                Console.WriteLine("Cuidado: Autor en mayúsculas");
            }

            if (EsMayusculas(libros[numRegistro - 1].titulo))
            {
                Console.WriteLine("Cuidado: Título en mayúsculas");
            }

            if (EsMinusculas(libros[numRegistro - 1].autor))
            {
                Console.WriteLine("Cuidado: Autor en mayúsculas");
            }

            if (EsMinusculas(libros[numRegistro - 1].titulo))
            {
                Console.WriteLine("Cuidado: Título en mayúsculas");
            }

            if (libros[numRegistro - 1].autor.Contains("  "))
            {
                Console.WriteLine("Cuidado: Autor con espacios de sobra");
            }

            if (libros[numRegistro - 1].titulo.Contains("  "))
            {
                Console.WriteLine("Cuidado: Título con espacios de sobra");
            }
        }
        else
            Console.WriteLine("No se encuentra el registro.");
    }

    static void Borrar(Libro[] libros, ref ushort cantidad)
    {
        Console.Write("Numero de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numRegistro >= 0 && numRegistro < cantidad)
        {
            MostrarRegistro(libros, numRegistro);

            Console.Write(
                "Seguro que quieres borrar este libro? Si/No:");
            string siNo = Console.ReadLine().ToUpper();
            if (siNo == "SI" || siNo == "S")
            {
                for (int i = numRegistro - 1; i < cantidad; i++)
                {
                    libros[i] = libros[i + 1];
                }
                cantidad--;
            }
        }
        else
        {
            Console.WriteLine("Sin datos");
            Console.WriteLine();
        }
    }

    static void ComprobarOrtografia(Libro[] libros, ushort cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            bool fichaCorrecta = true;
            string titulo = libros[i].titulo;
            int longitud = titulo.Length;

            // Contiene espacios duplicados?
            if (titulo.Contains("  "))
            {
                fichaCorrecta = false;
            }

            // Empieza o termina en espacio?
            if (titulo[0] == ' ' ||
                titulo[longitud - 1] == ' ')
            {
                fichaCorrecta = false;
            }


            // Minúscula justo antes de mayúscula
            for (int l = 0; l < longitud - 1; l++)
            {

                if ((titulo[l] >= 'a') && (titulo[l] <= 'z')
                    && (titulo[l + 1] >= 'A') && (titulo[l + 1] <= 'Z'))
                {
                    fichaCorrecta = false;
                }
            }

            if (!fichaCorrecta)
            {
                MostrarRegistro(libros, i);
                Console.Write("¿Desea arreglar este registro (s/n)? ");
                string corregir = Console.ReadLine().ToUpper();
                if (corregir == "S")
                {
                    // Sin espacios iniciales ni finales
                    libros[i].titulo = libros[i].titulo.Trim();

                    // Sin espacios redundantes
                    while (libros[i].titulo.Contains("  "))
                        libros[i].titulo =
                            libros[i].titulo.Replace("  ", " ");

                    // Mayúsculas correctas
                    // Fase 1: 1ª mayúscula, resto minúscula
                    libros[i].titulo =
                        libros[i].titulo.ToUpper()[0] +
                        libros[i].titulo.ToLower().Substring(1);
                    // Fase 2: Mays tras cada punto
                    string t = libros[i].titulo;
                    bool proxMayuscula = false;
                    for (int l = 1; l < t.Length - 1; l++)
                    {
                        if (t[l - 1] == '.')
                            proxMayuscula = true;

                        if ((t[l] >= 'a') && (t[l] <= 'z')
                            && proxMayuscula)
                        {
                            t = t.Insert(l, t.ToUpper().Substring(l, 1));
                            t = t.Remove(l + 1, 1);
                            proxMayuscula = false;
                        }
                    }
                    libros[i].titulo = t;
                }
            }

        }
    }

    // --------- Funciones auxiliares -------------

    static string Pedir(string aviso)
    {
        Console.Write(aviso);
        return Console.ReadLine();
    }

    static string PedirNoVacio(string aviso)
    {
        string respuesta;
        do
        {
            Console.Write(aviso);
            respuesta = Console.ReadLine();
        }
        while (respuesta == "");
        return respuesta;
    }

    static bool EsMayusculas(string texto)
    {
        return texto == texto.ToUpper();
    }

    static bool EsMinusculas(string texto)
    {
        return texto == texto.ToLower();
    }

    static void MostrarRegistro(Libro[] libros, int pos)
    {
        string anyoMostrar = Convert.ToString(
                    libros[pos].anyoPubli);

        if (anyoMostrar == "-1")
            anyoMostrar = "Año desconocido";

        Console.WriteLine(
            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
            pos + 1, libros[pos].titulo, libros[pos].autor,
            anyoMostrar);
    }
}


