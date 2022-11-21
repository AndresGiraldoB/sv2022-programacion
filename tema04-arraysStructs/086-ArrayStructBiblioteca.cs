/*86 Biblioteca. Examen del tema 4, 2016, grupo presencial, versión 
 * simplificada. 
 * Crea un programa en C# que pueda almacenar hasta 25000 libros. Para cada 
 * libro, debe permitir al usuario almacenar la siguiente información:
 * 
 * • Título (por ejemplo, El resplandor)
 * 
 * • Autor (por ejemplo, Stephen King)
 * 
 * • Año de publicación (p. Ej., 1977)
 * 
 * El programa debe permitir al usuario realizar las siguientes operaciones:
 * 
 * 1 - Añadir un libro nuevo. El título y el autor no pueden estar vacíos.
 * 
 * 2 - Mostrar todos los libros (número de registro, título, autor y año, en 
 * una misma línea), haciendo una pausa tras cada 18 filas.
 * 
 * 3 - Buscar libros que tengan un cierto título. Se debe mostrar el número de
 *  registro, el título, el autor y el año, en una misma línea.
 * 
 * 4 - Buscar libros publicados entre dos fechas (por ejemplo, 1970 y 1985), 
 * ambas incluidas. Nuevamente, debe mostrar el número de registro, el título, 
 * el autor y el año.
 * 
 * 5 - Modificar un registro: solicitará al usuario el número de registro, 
 * mostrará el valor anterior de cada campo y permitirá al usuario pulsar 
 * Intro sin escribir nada, en caso de que prefiera no modificar alguno de 
 * los campos. Se avisará al usuario (pero no se le volverá a preguntar) si 
 * introduce un número de registro incorrecto.
 * 
 * 6 - Eliminar un registro, en la posición indicada por el usuario. Se debe 
 * avisar (pero no volver a preguntar) si introduce un número de registro 
 * incorrecto. Deberá mostrar el registro que se eliminará y solicitar 
 * confirmación antes de borrarlo.
 * 
 * S - Salir (como no almacenamos la información en fichero, los datos se 
 * perderán)..
 * 
 * Autor: Omar (...)*/

using System;

class Biblioteca
{
    struct Libro
    {
        public string titulo;
        public string autor;
        public ushort anyoPubli;
    }

    static void Main()
    {
        const int MAXIMO = 25000;
        const byte BLOQUE = 18;
        const string SALIR = "S", SALIR2 = "s", 
            ANADIR = "1", VERTODO = "2", BUSCARTITULO= "3", 
            BUSCARFECHA= "4", MODIFICAR = "5", BORRAR = "6";
        
        Libro[] libros = new Libro[MAXIMO];
        ushort cantidad = 0;
        string opcion;

        do
        {
            Console.WriteLine("===============MENU===============");
            Console.WriteLine(ANADIR + "-Añadir un libro");
            Console.WriteLine(VERTODO + "-Mostrar todos los libros");
            Console.WriteLine(BUSCARTITULO + "-Buscar por título");
            Console.WriteLine(BUSCARFECHA + "-Buscar entre fechas");
            Console.WriteLine(MODIFICAR + "-Modificar libro");
            Console.WriteLine(BORRAR + "-Borrar libro");
            Console.WriteLine(SALIR + "-Salir");
            Console.WriteLine();
            Console.Write("Opción?: ");
            opcion = Console.ReadLine();
            Console.WriteLine();
            
            switch(opcion)
            {
                case ANADIR:
                    if (cantidad >= MAXIMO)
                    {
                        Console.WriteLine("Biblioteca llena");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("Titulo?: ");
                            libros[cantidad].titulo = Console.ReadLine();
                        }
                        while (libros[cantidad].titulo == "");
                        
                        do
                        {
                            Console.Write("Autor?: ");
                            libros[cantidad].autor = Console.ReadLine();
                        }
                        while (libros[cantidad].autor == "");
                        
                        Console.Write("Año de publicacion?: ");
                        libros[cantidad].anyoPubli =
                            Convert.ToUInt16( Console.ReadLine() );
                        
                        cantidad++;
                    }
                    break;

                case VERTODO:
                    if(cantidad == 0)
                        Console.WriteLine("Sin datos");
                    else
                        for(int i = 0; i < cantidad; i++)
                        {  
                            Console.WriteLine(
                                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                i+1, libros[i].titulo, libros[i].autor,
                                libros[i].anyoPubli);
                            if ( (i+1) % BLOQUE == 0 )
                            {
                                Console.ReadLine();
                            }
                        }
                    Console.WriteLine();
                    break;

                case BUSCARTITULO:
                    Console.Write("BUSCAR. Titulo?: ");
                    string buscar = Console.ReadLine();
                    if(buscar !="")
                    {
                        for(int i = 0; i < cantidad; i++)
                        {  
                            if(libros[i].titulo == buscar)
                            {
                                Console.WriteLine(
                                    "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                    i+1, libros[i].titulo, libros[i].autor,
                                    libros[i].anyoPubli);
                            }
                        }
                    }
                    break;

                case BUSCARFECHA:
                    Console.WriteLine("BUSCAR. RANGO AÑO DE PUBLICACION");
                    Console.Write("Entre año: ");
                    ushort fechaInicial = Convert.ToUInt16( Console.ReadLine() );
                    Console.Write("Y año: ");
                    ushort fechaFinal = Convert.ToUInt16( Console.ReadLine() );
                    
                    for(int i = 0; i < cantidad; i++)
                    {  
                        if(libros[i].anyoPubli >= fechaInicial && 
                                libros[i].anyoPubli <= fechaFinal)
                        {
                            Console.WriteLine(
                                "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                i+1, libros[i].titulo, libros[i].autor,
                                libros[i].anyoPubli);
                        }
                    }
                    break;

                case MODIFICAR:
                    Console.Write("Número de registro?: ");
                    int numRegistro = Convert.ToInt32( Console.ReadLine() );
                    if(numRegistro >= 1 && numRegistro <=cantidad)
                    { 
                        Console.WriteLine(
                            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                numRegistro, libros[numRegistro-1].titulo, 
                                libros[numRegistro-1].autor,
                                libros[numRegistro-1].anyoPubli);
                        
                        Console.Write("Titulo?: ");
                        string cadenaAux = Console.ReadLine();
                        if(cadenaAux !="")
                            libros[numRegistro-1].titulo = cadenaAux;

                        Console.Write("Autor?:");
                        cadenaAux = Console.ReadLine();
                        if(cadenaAux !="")
                            libros[numRegistro-1].autor = cadenaAux;

                        Console.Write("Año de publicacion?: ");
                        libros[cantidad].anyoPubli =
                            Convert.ToUInt16( Console.ReadLine() );
                    }
                    else
                        Console.WriteLine("No se encuentra el registro.");
                    break;

                case BORRAR:
                    Console.Write("Numero de registro?: ");
                    numRegistro = Convert.ToInt32( Console.ReadLine() );
                    if(numRegistro>=1 && numRegistro <= cantidad)
                    {
                        Console.WriteLine(
                            "{0}-Titulo: {1}, Autor: {2}, Año publicación: {3}", 
                                numRegistro, libros[numRegistro-1].titulo, 
                                    libros[numRegistro-1].autor,
                                        libros[numRegistro-1].anyoPubli);
                        Console.Write(
                            "Seguro que quieres borrar este libro? Si/No:" );
                        string siNo = Console.ReadLine();
                        if(siNo == "SI" || siNo == "Si" || 
                            siNo =="si"  || siNo == "S" || siNo == "s")
                        {
                            for(int i=numRegistro-1; i < cantidad; i++)
                            {
                                libros[i] = libros[i+1];
                            }
                            cantidad--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sin datos");
                        Console.WriteLine();
                    }
                    break;

                case SALIR:
                case SALIR2:
                    Console.WriteLine("¡Adios!");
                    break;

                default:
                    Console.WriteLine("Opcion no válida!");
                    break;
            }
                 
        }
        while(opcion != SALIR && opcion != SALIR2);
    }
}
