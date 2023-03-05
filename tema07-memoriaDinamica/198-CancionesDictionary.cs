// DAN 1DAW

/*
198. Debes crear una aplicación que permita llevar el control 
de una colección de música en formato MP3. De cada canción o 
similar (que será un objeto de la clase "Cancio") querremos 
anotar el título (por ejemplo, "The bell"), el intérprete 
("Mike Oldfield"), el nombre del fichero ("thebell.mp3") y la 
ubicación ("MikeOldfield/tubularBells"). Otros detalles que podrían 
ser interesantes, como el tamaño del fichero, la categoría, el álbum 
al que pertenece o la valoración personal, hemos decidido aplazarlos 
para una versión posterior 2.0.

Las canciones se guardarán en un Dictionary o un SortedList, que use 
como clave el título de la canción y como valor el conjunto de los 
datos, por ejemplo: Dictionary<string, Cancion>.

Tu aplicación debe mostrar un menú que permita:

1. Añadir una nueva canción.

2. Ver todos los datos de una canción a partir de su título.

3. Mostrar las nombres de las canciones que contengan un cierto 
texto en el título o en el autor.

4. Modificar los datos de una canción a partir de su título.

0. Salir
*/

using System;
using System.Collections.Generic;

class Cancion
{
    private string titulo;
    private string interprete;
    private string nombreFichero;
    private string ubicacionFichero;

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Interprete
    {
        get { return interprete; }
        set { interprete = value; }
    }

    public string NombreFichero
    {
        get { return nombreFichero; }
        set { nombreFichero = value; }
    }

    public string UbicacionFichero
    {
        get { return ubicacionFichero; }
        set { ubicacionFichero = value; }
    }

    public Cancion(string titulo, string interprete, string nombreFichero, 
		string ubicacionFichero)
    {
        this.titulo = titulo;
        this.interprete = interprete;
        this.nombreFichero = nombreFichero;
        this.ubicacionFichero = ubicacionFichero;
    }

    public override string ToString()
    {
        return string.Format(
			"Título: {0}, Intérprete: {1}, Fichero: {2}, Ubicación: {3}",
             titulo, interprete, nombreFichero, ubicacionFichero);
    }
}

class GestorCanciones
{
    static void Main()
    {
        Dictionary<string, Cancion> diccionario = new Dictionary<string, Cancion>();

        diccionario.Add("The bell", new Cancion(
			"The bell", "Mike Oldfield", 
            "thebell.mp3", "MikeOldField/tubularBells"));
        diccionario.Add("Sleepwalking", new Cancion(
			"Sleepwalking", "Bring me the horizon",
            "sleepwalking.mp3", "sleepwalking/bmth songs"));

        bool terminar = false;
        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("Menú");
            Console.WriteLine("1. Añadir una nueva canción");
            Console.WriteLine("2. Ver todos los datos de una canción" +
                " a partir del título");
            Console.WriteLine("3. Mostrar los nombres de las canciones" +
                " a partir de un texto");
            Console.WriteLine("4. Modificar los datos de una canción" +
                " a partir de su título");
            Console.WriteLine("0. Salir");

            opcion = Pedir("Introduce tu opción");

            switch (opcion)
            {
                default:
                    Console.WriteLine("Opción desconocida");
                    Continuar();
                    break;

                case "0":
                    Console.WriteLine("Adiós");
                    terminar = true;
                    Continuar();
                    break;

                case "1":
                    Cancion c;

                    string titulo = Pedir("Introduce un título");
                    string interprete = Pedir("Introduce un intérprete");
                    string nombreFichero = Pedir("Introduce un nombre de fichero");
                    string ubicacionFichero = Pedir("Introduce una ubicación de fichero");

                    c = new Cancion(titulo, interprete, nombreFichero, ubicacionFichero);

                    diccionario.Add(titulo, c);
                    Continuar();
                    break;

                case "2":
                    string tituloBuscar = Pedir("Introduce título a buscar");
                    if (diccionario.ContainsKey(tituloBuscar))
                    {
                        Console.WriteLine(diccionario[tituloBuscar]);
                    }
                    else
                    {
                        Console.WriteLine("Título no encontrado");
                    }

                    Continuar();
                    break;

                case "3":
                    string textoBuscar = Pedir("Introduce texto a buscar").ToLower();
                    foreach (Cancion cancion in diccionario.Values)
                    {
                        if (cancion.Titulo.ToLower().Contains(textoBuscar) ||
                            cancion.Interprete.ToLower().Contains(textoBuscar))
                        {
                            Console.WriteLine(cancion);
                        }
                    }

                    Continuar();
                    break;

                case "4":
                    string tituloModificar = Pedir("Introduce el título a buscar");
                    
                    try
                    {
						Cancion ca = diccionario[tituloModificar];
						Console.WriteLine(ca);

						ca.Titulo = Pedir("Introduce el nuevo título");
						ca.Interprete = Pedir("Introduce el nuevo intérprete");
						ca.NombreFichero = Pedir("Introduce el nuevo nombre de fichero");
						ca.UbicacionFichero = Pedir("Introduce la nueva ubicación de fichero");

						diccionario[tituloModificar] = ca;
					}
					catch (Exception)
					{
						Console.WriteLine("No existe esa canción");
					}

                    Continuar();
                    break;
            }
        }
        while (!terminar);
    }

    static string Pedir(string texto)
    {
        Console.Write("{0}: ", texto);
        return Console.ReadLine();
    }

    static void Continuar()
    {
        Console.WriteLine("Presiona cualquier tecla para continuar");
        Console.ReadKey();
    }
}
