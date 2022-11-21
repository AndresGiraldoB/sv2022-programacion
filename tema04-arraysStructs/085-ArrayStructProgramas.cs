/*Programas de ordenador (fragmento del examen del tema 4, 2008-2009, 
grupo presencial, versión simplificada)
 
Crea un programa en C# que pueda almacenar fichas de hasta 1000 
programas de ordenador. Para cada programa, debe guardar los siguientes 
datos:

- Nombre
- Descripción
- Versión (es un conjunto de 2 datos: el mes de lanzamiento -byte- y el 
  año de lanzamiento -entero corto sin signo-)

El programa debe permitir al usuario las siguientes operaciones:

1- Añadir datos de un nuevo programa.

2- Mostrar los nombres de todos los programas almacenados. Cada nombre 
debe aparecer en una línea distinta, precedido por el número de 
programa (empezando a contar desde 1). Si hay más de 20 programas, se 
deberá hacer una pausa tras mostrar cada bloque de 20 programas, y 
esperar a que el usuario pulse Intro antes de seguir. Se deberá avisar 
si no hay datos.

3- Ver todos los datos de un cierto programa (a partir de su número de 
registro, contando desde 1). Se deberá avisar (pero no volver a pedir) 
si el número no es válido.

4- Modificar una ficha (se pedirá el número y se volverá a introducir 
el valor de todos los campos. Se debe avisar (pero no volver a pedir) 
si introduce un número de ficha incorrecto.

5- Borrar un cierto dato, a partir del número de posición, que 
introducirá el usuario. Se debe avisar (pero no volver a pedir) si 
introduce un número incorrecto.

T- Terminar(como no sabemos almacenar la información, los datos se 
perderán).*/

// Fatima (...)

using System;

class Ejercicio85
{
    const char TERMINAR = 'T', TERMINAR2 = 't',
        ANADIR='1', NOMBRES = '2', DATOS = '3', 
        MODIFICAR= '4', BORRAR = '5';

    struct tipoVersion
    {
        public byte mesLanzamiento;
        public short anyoLanzamiento;
    }

    struct tipoPrograma
    {
        public string nombre;
        public string descripcion;
        public tipoVersion version;
    }

    static void Main()
    {
        tipoPrograma[] programa = new tipoPrograma[1000];
        const int capacidad = 1000;
        int cantidad = 0;
        char opcion;
        bool terminar = false;

        do
        {
            Console.WriteLine();
            Console.WriteLine("ELIGE UNA OPCIÓN:");
            Console.WriteLine(ANADIR + ".Añadir nuevos datos");
            Console.WriteLine(NOMBRES + 
                ".Mostrar nombres de todos los programas almacenados");
            Console.WriteLine(DATOS + 
                ".Ver todos los datos de un programa");
            Console.WriteLine(MODIFICAR + ".Modificar una ficha");
            Console.WriteLine(BORRAR + ".Borrar un dato");
            Console.WriteLine(TERMINAR + ".Terminar");

            Console.Write("Has elegido la opción: ");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case ANADIR:

                    if (cantidad < capacidad)
                    {
                        Console.WriteLine();
                        Console.Write("Nombre: ");
                        programa[cantidad].nombre = 
                            Convert.ToString(Console.ReadLine());

                        Console.Write("Descripción: ");
                        programa[cantidad].descripcion = 
                            Convert.ToString(Console.ReadLine());

                        Console.Write("Mes de lanzamiento: ");
                        programa[cantidad].version.mesLanzamiento = 
                            Convert.ToByte(Console.ReadLine());

                        Console.Write("Año de lanzamiento: ");
                        programa[cantidad].version.anyoLanzamiento = 
                            Convert.ToInt16(Console.ReadLine());

                        cantidad++;
                    }

                    else
                        Console.WriteLine("Capacidad de almacenamiento agotada");
                    break;

                case NOMBRES:

                    Console.WriteLine();
                    Console.WriteLine("Programas almacenados:");
                    int contador = 0;
                     
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0}. {1}", i + 1, 
                            programa[i].nombre);
                        contador++;

                        if (contador == 20)
                        {
                            contador = 0;
                            Console.ReadLine();
                        }
                    }
                    if (cantidad == 0)
                        Console.WriteLine("No hay datos almacenados");                    
                    break;

                case DATOS:

                    Console.Write("Número de registro a mostrar: ");
                    int datoUsuario = Convert.ToInt32(Console.ReadLine());

                    if (datoUsuario >= cantidad)
                        Console.WriteLine("Dato no registrado");
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Programa: " +
                            programa[datoUsuario-1].nombre);
                        Console.WriteLine("Descripción: " +  
                            programa[datoUsuario - 1].descripcion);
                        Console.WriteLine("Versión: "  +
                            programa[datoUsuario - 1].version.mesLanzamiento +
                            "."+
                            programa[datoUsuario - 1].version.anyoLanzamiento);
                    }
                    break;

                case MODIFICAR:

                    Console.Write("Número de registro a modificar: ");
                    int datoModificar = Convert.ToInt32(Console.ReadLine());

                    if (datoModificar >= cantidad)
                        Console.WriteLine("Dato no registrado");

                    else
                    {
                        Console.Write("Nombre: ");
                        programa[datoModificar - 1].nombre = 
                            Convert.ToString(Console.ReadLine());

                        Console.Write("Descripción: ");
                        programa[datoModificar - 1].descripcion = 
                            Convert.ToString(Console.ReadLine());

                        Console.Write("Mes de lanzamiento: ");
                        programa[datoModificar - 1].version.mesLanzamiento = 
                            Convert.ToByte(Console.ReadLine());

                        Console.Write("Año de lanzamiento: ");
                        programa[datoModificar - 1].version.anyoLanzamiento = 
                            Convert.ToInt16(Console.ReadLine());
                    }                    
                    break;

                case BORRAR:

                    Console.Write("¿Cuál es el registro que quieres borrar? ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    if (posicionBorrar > cantidad)
                        Console.WriteLine("Dato no registrado");
                    else
                    {
                        for (int i = posicionBorrar; i < cantidad - 1; i++)
                            programa[i] = programa[i + 1];
                        cantidad--;
                        break;
                    }
                    break;  

                case TERMINAR:
                case TERMINAR2:
                    terminar = true;
                    break;
                    
                default:
                    Console.WriteLine("No es una opción");
                    break;
            }

        }
        while (! terminar);
        
        Console.WriteLine("¡Hasta otra!");
    }
}
