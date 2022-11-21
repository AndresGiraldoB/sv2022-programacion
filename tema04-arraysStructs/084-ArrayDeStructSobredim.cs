/* Juan Manuel (...) */

/*
84. Crea una versión mejorada del ejercicio 83, que no reservará espacio sólo
para 3 datos, sino para 100, y mostrará un menú que permita al usuario añadir
un nuevo dato, ver todos los existentes o salir.
*/

using System;

class Ejercicio84
{
    struct TipoFecha
    {
        public byte dia;
        public byte mes; 
        public ushort anyo;
    }

    struct TipoPersona
    {
        public string nombre;
        public byte edad;
        public TipoFecha fecha;
    }

    static void Main()
    {
        const int MAXIMO = 100;
        TipoPersona[] personas = new TipoPersona[MAXIMO];
        string opcion;
        bool salir = false;
        int cantidad = 0;
        do
        {
            Console.Clear();
            Console.WriteLine(" 1.- Añadir un nuevo dato.");
            Console.WriteLine(" 2.- Ver todos los datos existentes.");
            Console.WriteLine(" 0.- Salir.");
            Console.WriteLine();
            Console.Write(" Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "0":
                    salir = true;
                    break;

                case "1":
                    if (cantidad >= MAXIMO)
                    {
                        Console.WriteLine("Lo siento, no caben más datos");
                    }
                    else
                    {
                        Console.Write(" Dime el nombre: ");
                        personas[cantidad].nombre = Console.ReadLine();
                        Console.Write(" Dime la edad: ");
                        personas[cantidad].edad = Convert.ToByte(
                            Console.ReadLine());
                        Console.WriteLine(" Ahora la fecha de nacimiento.");
                        Console.Write(" Dime el día: ");
                        personas[cantidad].fecha.dia = Convert.ToByte(
                            Console.ReadLine());
                        Console.Write(" Dime el mes: ");
                        personas[cantidad].fecha.mes = Convert.ToByte(
                            Console.ReadLine());
                        Console.Write(" Dime el año: ");
                        personas[cantidad].fecha.anyo = 
                            Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine();

                        cantidad++;

                        Console.WriteLine(" Registro añadido.");
                        Console.Write(" Pulse una tecla para continuar.");
                        Console.ReadKey();
                    }
                    break;

                case "2":
                    Console.WriteLine();
                    if (cantidad > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(" Registro: " + (i + 1));
                            Console.WriteLine("\tNombre: " + personas[i].nombre);
                            Console.WriteLine("\tEdad: " + personas[i].edad);
                            Console.WriteLine("\tFecha de nacimiento: " +
                                personas[i].fecha.dia + "/" +
                                personas[i].fecha.mes + "/" + 
                                personas[i].fecha.anyo);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine(" No hay datos para mostrar.");
                    }
                    Console.Write(" Pulse una tecla para continuar.");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine(" Opción no válida.");
                    break;
            }

        } while (!salir);
    }
}

