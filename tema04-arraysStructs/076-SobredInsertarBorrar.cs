/*Crea una versión mejorada del programa anterior: un array que permita almacenar hasta 1.000 nombres de personas y un menú que permita: Añadir un
nuevo dato (al final de los existentes), insertar un dato (en una cierta posición que se preguntará al usuario), borrar un dato (a partir de su
número de posición), ver todos los datos, buscar un cierto dato, salir.
* 
Fátima (...) */

using System;

class Ejercicio76
{
    enum opciones { SALIR, ANADIR, INSERTAR, BORRAR, VER, BUSCAR }
    
    static void Main()
    {
        const int CAPACIDAD = 1000;
        string[] nombres = new string[CAPACIDAD];
        int cantidad = 0;
        byte opcion;
        
        do
        {
            Console.WriteLine();
            Console.WriteLine("ELIGE UNA OPCIÓN:");
            Console.WriteLine( (int)opciones.ANADIR + ".Añadir nuevo nombre");
            Console.WriteLine( (int)opciones.INSERTAR + ".Insertar nuevo nombre");
            Console.WriteLine( (int)opciones.BORRAR + ".Borrar un nombre");
            Console.WriteLine( (int)opciones.VER + ".Ver todos los nombres");
            Console.WriteLine( (int)opciones.BUSCAR + ".Buscar a una persona");
            Console.WriteLine( (int)opciones.SALIR + ".Salir");

            Console.WriteLine();
            Console.Write("Has elegido la opción: ");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {

                case (int)opciones.ANADIR:
                    if (cantidad < CAPACIDAD)
                    {
                        Console.Write("Dato a añadir: ");
                        nombres[cantidad] = Convert.ToString(Console.ReadLine());
                        cantidad++;
                    }
                    break;

                case (int)opciones.INSERTAR:
                    Console.Write("¿En qué posición quieres insertar el dato? ");
                    int posicionInsertar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("¿Qué dato quieres insertar? ");
                    string datoInsertar = Convert.ToString(Console.ReadLine());

                    for (int i = cantidad; i > posicionInsertar; i--)
                        nombres[i] = nombres[i - 1];

                    nombres[posicionInsertar] = datoInsertar;
                    cantidad++;
                    break;

                case (int)opciones.BORRAR:
                    Console.Write("¿Cuál es la posición del dato que quieres borrar? ");
                    int posicionBorrar = Convert.ToInt32(Console.ReadLine());

                    for (int i = posicionBorrar; i < cantidad - 1; i++)
                        nombres[i] = nombres[i + 1];
                    cantidad--;
                    break;

                case (int)opciones.VER:
                    Console.WriteLine("Estos son todos los nombres almacenados:");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine((i+1) + ". " + nombres[i] + (" "));
                    }
                    break;

                case (int)opciones.BUSCAR:
                    Console.Write("Nombre a buscar: ");
                    string datoUsuario = Convert.ToString(Console.ReadLine());

                    bool encontrado = false;
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (nombres[i] == datoUsuario)
                            encontrado = true;
                    }
                    if (encontrado == true)
                        Console.WriteLine("Encontrado");
                    else
                        Console.WriteLine("No encontrado");
                    break;
            }
        }
        while (opcion != 0);
        
        Console.WriteLine("¡Hasta otra!");
    }
}

