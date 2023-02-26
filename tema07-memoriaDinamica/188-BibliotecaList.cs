/*188. Crea una nueva versión del ejercicio 111 (biblioteca + funciones),
 * en la que no se utilice un array para los datos, sino una lista con tipo.
 * Debes partir de la "solución oficial" y respetar su estructura básica, 
 * si bien las funciones ya no necesitarán recibir la cantidad de datos 
 * como parámetro (porque se puede deducir, al tratarse de una lista) 
 * y cambiará la forma de añadir y borrar.
 
 Radha */

using System;
using System.Collections.Generic;


class BibliotecaFunciones
{
    struct Libro : IComparable<Libro>
    {
        public string titulo;
        public string autor;
        public short anyoPubli;

        public int CompareTo(Libro libro)
        {
            return this.titulo.CompareTo(libro.titulo);
        }
    }

    const string SALIR = "S",
            ANADIR = "1", VERTODO = "2", BUSCARTITULO = "3",
            BUSCARFECHA = "4", MODIFICAR = "5", BORRAR = "6",
            ORTOGRAFIA = "7";
    const byte BLOQUE = 18;

    static void Main()
    {
        List<Libro> libros = new List<Libro>();
        string opcion;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();
            switch (opcion)
            {
                case ANADIR:
                    Anyadir(libros);
                    break;

                case VERTODO:
                    VerTodo(libros);
                    break;

                case BUSCARTITULO:
                    BuscarTitulo(libros);
                    break;

                case BUSCARFECHA:
                    BuscarFecha(libros);
                    break;

                case MODIFICAR:
                    Modificar(libros);
                    break;

                case BORRAR:
                    Borrar(libros);
                    break;

                case ORTOGRAFIA:
                    ComprobarOrtografia(libros);
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

    static void Anyadir(List<Libro> libros)
    {
        Libro libroAnyadir;
        string titulo, autor;
        short anyoGuardar;

        titulo = PedirNoVacio("Titulo?: ");
        autor = PedirNoVacio("Autor?: ");
        // Año -1 si no se escribe nada
        string anyo = Pedir("Año de publicacion?: ");
        if (anyo == "")
        {
            anyoGuardar = -1;
        }
        else
        {
            anyoGuardar = Convert.ToInt16(anyo);
        }

        libroAnyadir.autor= autor;
        libroAnyadir.titulo= titulo;
        libroAnyadir.anyoPubli = anyoGuardar;

        libros.Add(libroAnyadir);

        //Ordeno titulos alfabeticamente
        libros.Sort();
        
    }

    static void VerTodo(List<Libro> libros)
    {
        if (libros.Count == 0)
            Console.WriteLine("Sin datos");
        else
            for (int i = 0; i < libros.Count; i++)
            {
                MostrarRegistro(libros, i);

                if ((i + 1) % BLOQUE == 0)
                {
                    Console.ReadLine();
                }
            }
        Console.WriteLine();
    }

    static void BuscarTitulo(List<Libro> libros)
    {
        Console.Write("BUSCAR. Titulo?: ");
        string buscar = Console.ReadLine();
        if (buscar != "")
        {
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].titulo.ToUpper().Contains(buscar.ToUpper())
                    || libros[i].autor.ToUpper().Contains(buscar.ToUpper()))
                {
                    MostrarRegistro(libros, i);
                }
            }
        }
    }

    static void BuscarFecha(List<Libro> libros)
    {
        Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
        Console.Write("Entre año: ");
        ushort fecha1 = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Y año: ");
        ushort fecha2 = Convert.ToUInt16(Console.ReadLine());

        // Invertir fechas si están al revés
        ushort fechaInicial = fecha1 > fecha2 ? fecha1 : fecha2;
        ushort fechaFinal = fecha1 < fecha2 ? fecha1 : fecha2;

        for (int i = 0; i < libros.Count; i++)
        {
            if (libros[i].anyoPubli >= fechaInicial &&
                    libros[i].anyoPubli <= fechaFinal)
            {
                MostrarRegistro(libros, i);
            }
        }
    }

    static void Modificar(List<Libro> libros)
    {
        Libro libroModificar;
        string titulo, autor;
        short anyoGuardar;


        Console.Write("Número de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine());
        if (numRegistro >= 1 && numRegistro <= libros.Count)
        {
            libroModificar = libros[numRegistro - 1];
            Console.WriteLine(
                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}",
                    numRegistro, libros[numRegistro - 1].titulo,
                    libros[numRegistro - 1].autor,
                    libros[numRegistro - 1].anyoPubli);

            string cadenaAux = Pedir("Titulo?: ").Trim();
            if (cadenaAux != "")
            {
                titulo = cadenaAux;
                libroModificar.titulo = titulo;
            }


            cadenaAux = Pedir("Autor?:").Trim();
            if (cadenaAux != "")
            {
                autor = cadenaAux;
                libroModificar.autor = autor;
            }
               

            anyoGuardar =
                Convert.ToInt16(Pedir("Año de publicacion?: "));
            
            libroModificar.anyoPubli = anyoGuardar;

            libros[numRegistro - 1] = libroModificar;

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

    static void Borrar(List<Libro> libros)
    {
        Console.Write("Numero de registro?: ");
        int numRegistro = Convert.ToInt32(Console.ReadLine()) - 1;
        if (numRegistro >= 0 && numRegistro < libros.Count)
        {
            MostrarRegistro(libros, numRegistro);

            Console.Write(
                "Seguro que quieres borrar este libro? Si/No:");
            string siNo = Console.ReadLine().ToUpper();
            if (siNo == "SI" || siNo == "S")
            {
                libros.RemoveAt(numRegistro);
            }
        }
        else
        {
            Console.WriteLine("Sin datos");
            Console.WriteLine();
        }
    }

    static void ComprobarOrtografia(List<Libro> libros)
    {
        for (int i = 0; i < libros.Count; i++)
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
                Libro libroCorregir = libros[i];
                string tituloCorregir;
                MostrarRegistro(libros, i);
                Console.Write("¿Desea arreglar este registro (s/n)? ");
                string corregir = Console.ReadLine().ToUpper();
                if (corregir == "S")
                {
                    // Sin espacios iniciales ni finales
                    tituloCorregir = libros[i].titulo.Trim();

                    // Sin espacios redundantes
                    while (libros[i].titulo.Contains("  "))
                        tituloCorregir =
                            libros[i].titulo.Replace("  ", " ");

                    // Mayúsculas correctas
                    // Fase 1: 1ª mayúscula, resto minúscula
                    tituloCorregir =
                        libros[i].titulo.ToUpper()[0] +
                        libros[i].titulo.ToLower().Substring(1);
                    // Fase 2: Mays tras cada punto
                    string t = tituloCorregir;
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
                    tituloCorregir = t;

                    libroCorregir.autor = tituloCorregir;

                    libros[i] = libroCorregir;

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

    static void MostrarRegistro(List<Libro> libros, int pos)
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

