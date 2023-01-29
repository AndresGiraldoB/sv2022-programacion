//Francis (...) - 1ºDAM Semipresencial

/*
 * 148. A partir de la clase "Libro" (ejercicio 140), crea un programa que 
 * permita tener hasta 25000 libros, y un menú con el que se pueda: Añadir 
 * un libro nuevo (opción "1"), Mostrar todos los libros (opción "2"), 
 * Buscar libros que contengan un texto determinado (opción "3"), 
 * Salir (opción "S").
 */

using System;

class Libro
{
    protected string titulo;
    protected string autor;
    protected short anyoPubli;

    public Libro(string nuevoTitulo, string nuevoAutor, int nuevoAnyoPublicacion)
    {
        titulo = nuevoTitulo;
        autor = nuevoAutor;
        anyoPubli = (short)nuevoAnyoPublicacion;
    }

    public string GetTitulo() { return titulo; }
    public string GetAutor() { return autor; }
    public int GetAnyoPublicacion() { return anyoPubli; }

    public void SetTitulo(string nuevoTitulo) { titulo = nuevoTitulo; }
    public void SetAutor(string nuevoAutor) { autor = nuevoAutor; }
    public void SetAnyoPublicacion(int nuevoAnyoPublicacion)
    {
        anyoPubli = (short)nuevoAnyoPublicacion;
    }

    public void Mostrar()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anyoPubli);
        Console.WriteLine();
    }

    public bool Contiene(string texto)
    {
        return titulo.ToUpper().Contains(texto.ToUpper())
            || autor.ToUpper().Contains(texto.ToUpper());
    }
}

class PruebaClaseLibro
{
    static void Main()
    {

        const string OPCION1 = "1", OPCION2 = "2", OPCION3 = "3", SALIR = "S";
        const ushort MAX_LIBROS = 25000;
        Libro[] l = new Libro[MAX_LIBROS];
        ushort cantidad = 0;
        string opcion = "";
        bool terminado = false;

        do
        {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion)
            {
                case OPCION1: Anyadir(ref l, ref cantidad, MAX_LIBROS); break;
                case OPCION2: Mostrar(ref l, cantidad); break;
                case OPCION3: Buscar(ref l, cantidad); break;
                case SALIR: terminado = true; break;
                default: AvisarIncorrecta(); break;
            }
        }
        while (!terminado);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("1. Añadir un libro nuevo");
        Console.WriteLine("2. Mostrar todos los libros");
        Console.WriteLine("3. Buscar libros que contengan un texto determinado");
        Console.WriteLine("S. Salir");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
    }

    static string PedirOpcion()
    {
        return Console.ReadLine().ToUpper();
    }

    static void Anyadir(ref Libro[] l, ref ushort cant, ushort MAX_LIBROS)
    {
        if (cant == MAX_LIBROS)
            Console.WriteLine("No caben más libros");
        else
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Año: ");
            ushort anyo = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine();

            l[cant] = new Libro(titulo, autor, anyo);
            cant++;
        }
    }

    static void Mostrar(ref Libro[] l, ushort cant)
    {
        if (cant == 0)
            Console.WriteLine("No hay libros que mostrar");
        else
        {
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Libro: " + (i + 1));
                l[i].Mostrar();
            }
        }

        Console.WriteLine();
    }

    static void Buscar(ref Libro[] l, ushort cant)
    {
        if (cant == 0)
            Console.WriteLine("No hay libros donde buscar");
        else
        {
            bool encontrado = false;

            Console.Write("Buscar coincidencias: ");
            string buscar = Console.ReadLine();

            for (int i = 0; i < cant; i++)
            {
                if (l[i].Contiene(buscar))
                {
                    l[i].Mostrar();
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No hay coincidencias");
        }
    }

    static void AvisarIncorrecta()
    {
        Console.WriteLine("Opción incorrecta");
        Console.WriteLine();
    }
}
