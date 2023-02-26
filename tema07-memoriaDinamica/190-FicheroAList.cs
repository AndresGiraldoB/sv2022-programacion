// DAN 1DAW

/*
190. Como verás con más detalle en el tema 8, una forma rápida de leer 
todo el contenido de un fichero de texto es emplear 
"string[] lineas = File.ReadAllLines("nombreDeFichero.ext");" 
(necesitarás añadir también "using System.IO;"). Además, puedes 
crear una lista a partir de ese array de strings con 
"List<string> lista = new List<string>(lineas);". 
Haz un programa que muestre un menú, mediante el cual el usuario pueda:

1 - Cargar un fichero

2 - Ver todo el contenido del fichero

3 - Ver desde un número de línea hasta otro número de línea.

4 - Insertar una línea en cualquier posición.

5 - Borrar una línea en cualquier posición.

6 - Buscar las líneas que contengan un cierto texto.

7 - Ordenar las líneas alfabéticamente.

T - Terminar.

(Como mejora opcional, puedes hacer que se guarde el resultado en 
otro fichero cuando termine la ejecución, con 
"File.WriteAllLines("nombre2.ext", miLista.ToArray());").
*/

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string nombreFichero = "";
        List<string> lineas = new List<string>();

        bool terminar = false;
        while (!terminar)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Cargar un fichero");
            Console.WriteLine("2 - Ver todo el contenido del fichero");
            Console.WriteLine("3 - Ver desde un número de línea hasta otro número de línea");
            Console.WriteLine("4 - Insertar una línea en cualquier posición");
            Console.WriteLine("5 - Borrar una línea en cualquier posición");
            Console.WriteLine("6 - Buscar las líneas que contengan un cierto texto");
            Console.WriteLine("7 - Ordenar las líneas alfabéticamente");
            Console.WriteLine("T - Terminar");

            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine().ToUpper();

            switch (opcion)
            {
                case "1":
                    Console.Write("Introduce el nombre del fichero: ");
                    nombreFichero = Console.ReadLine();

                    if (File.Exists(nombreFichero))
                    {
                        lineas = new List<string>(File.ReadAllLines(nombreFichero));
                        Console.WriteLine("Fichero cargado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("El fichero especificado no existe.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Contenido del fichero:");
                    foreach (string linea in lineas)
                    {
                        Console.WriteLine(linea);
                    }
                    break;

                case "3":
                    Console.Write("Introduce el número de línea inicial: ");
                    int inicio = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.Write("Introduce el número de línea final: ");
                    int fin = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (inicio >= 0 && fin < lineas.Count)
                    {
                        for (int i = inicio; i < fin; i++)
                        {
                            Console.WriteLine(lineas[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los números de línea especificados están fuera de rango.");
                    }
                    break;

                case "4":
                    Console.Write("Introduce la línea que quieres insertar: ");
                    string nuevaLinea = Console.ReadLine();

                    Console.Write("Introduce la posición en la que quieres insertarla: ");
                    int posicion = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicion >= 0 && posicion < lineas.Count)
                    {
                        lineas.Insert(posicion, nuevaLinea);
                        Console.WriteLine("Línea insertada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("La posición especificada está fuera de rango.");
                    }
                    break;

                case "5":
                    Console.Write("Introduce la posición de la línea que quieres borrar: ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (posicionBorrar >= 0 && posicionBorrar < lineas.Count)
                    {
                        lineas.RemoveAt(posicionBorrar);
                        Console.WriteLine("Línea borrada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("La posición especificada está fuera de rango.");
                    }
                    break;

                case "6":
                    Console.Write("Introduce el texto a buscar: ");
                    string textoBuscar = Console.ReadLine();

                    for (int i = 0; i < lineas.Count; i++)
                    {
                        if (lineas[i].Contains(textoBuscar))
                        {
                            Console.WriteLine((i+1) + ". " + lineas[i]);
                        }
                    }
                    break;

                case "7":
                    lineas.Sort();
                    break;
                    
                case "t":
                case "T":
                    terminar = true;
                    break;

                default: Console.WriteLine("Opción desconocida"); break;
            }
        }
        
        if (nombreFichero != "")
        {
            File.WriteAllLines(nombreFichero + ".modificado", lineas.ToArray());
            Console.WriteLine("Cambios guardados");
        }
    }
}
