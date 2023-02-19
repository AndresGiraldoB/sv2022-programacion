//Francis (...) - 1ºDAM Semipresencial

/*

176. Crea una versión ampliada de la clase Libro y su menú (ejercicio 167), en 
la que añadas una subclase "LibroElectronico", que será un tipo de libro para 
el que además indicaremos en qué formato tenemos nuestra copia (por ejemplo, 
EPUB o PDF). El constructor recibirá también este nuevo dato, y se apoyará en 
el de la clase superior. El ToString añadirá algo como " (PDF)". El 
funcionamiento debe ser básicamente el mismo que el anterior, con la diferencia 
de que al añadir un libro preguntará si es un libro electrónico y, en caso 
afirmativo, en qué formato.

 */

using System;

class Libro : IComparable<Libro>
{
    protected string titulo;
    protected string autor;
    protected short anyoPubli;

    public Libro(string titulo, string autor, int anyoPubli)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.anyoPubli = (short)anyoPubli;
    }

    public Libro(string titulo, int anyoPubli)
        : this(titulo, "Desconocido", anyoPubli)
    {
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

    public virtual void Mostrar()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Año de publicación: " + anyoPubli);
    }

    public bool Contiene(string texto)
    {
        return titulo.ToUpper().Contains(texto.ToUpper())
            || autor.ToUpper().Contains(texto.ToUpper());
    }

    int IComparable<Libro>.CompareTo(Libro libro)
    {
        if (this.titulo != libro.titulo)
        {
            return this.titulo.CompareTo(libro.titulo);
        }
        else
        {
            return this.autor.CompareTo(libro.autor);
        }
    }

    public override string ToString()
    {
        return titulo + ", " + autor + ", " + anyoPubli;
    }
}

// ------------------------------------------------------

class LibroElectronico : Libro
{
    public string Formato { get; set; }

    public LibroElectronico(string titulo, string autor, int anyoPubl, string formato)
        : base(titulo, autor, anyoPubl)
    {
        Formato = formato;
    }

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Formato: " + Formato);
    }

    public override string ToString()
    {
        return base.ToString() + " (" + Formato + ")";
    }
}

// ------------------------------------------------------

class PruebaClaseLibro
{
    static void Main()
    {

        const string OPCION1 = "1", OPCION2 = "2", OPCION3 = "3", SALIR = "S",
            OPCION4 = "4";
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
                case OPCION1: Anyadir(l, ref cantidad, MAX_LIBROS); break;
                case OPCION2: Mostrar(l, cantidad); break;
                case OPCION3: Buscar(l, cantidad); break;
                case OPCION4: Ordenar(l, 0, cantidad); break;
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
        Console.WriteLine("4. Ordenar libros por nombre/autor");
        Console.WriteLine("S. Salir");
        Console.WriteLine();
        Console.Write("Elige una opción: ");
    }

    static string PedirOpcion()
    {
        return Console.ReadLine().ToUpper();
    }

    static void Anyadir(Libro[] l, ref ushort cant, ushort MAX_LIBROS)
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

            Console.Write("Indicar formato (si / no): ");
            string indicarFormato = Console.ReadLine().ToUpper();
            string formato = "";
            if (indicarFormato == "SI")
            {
                Console.Write("Formato: ");
                formato = Console.ReadLine();
            }
            Console.WriteLine();

            if (autor == "")
                l[cant] = new Libro(titulo, anyo);
            else if (autor != "" && formato == "")
                l[cant] = new Libro(titulo, autor, anyo);
            else
                l[cant] = new LibroElectronico(titulo, autor, anyo, formato);
            cant++;
        }
    }

    static void Mostrar(Libro[] l, ushort cant)
    {
        if (cant == 0)
            Console.WriteLine("No hay libros que mostrar");
        else
        {
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Libro: " + (i + 1));
                l[i].Mostrar();
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }

    static void Buscar(Libro[] l, ushort cant)
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

    static void Ordenar(Libro[] l, int posicion, ushort cantidad)
    {
        Array.Sort(l, 0, cantidad);
        Console.WriteLine("Libros ordenados correctamente");
    }
}
