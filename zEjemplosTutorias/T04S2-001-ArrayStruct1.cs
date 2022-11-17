/*
Datos de hasta 100 personas. 
Nombre y email para cada una.
Menú que permita:
- Añadir un nuevo dato
- Ver todos
- Salir
*/

using System;

class ArrayStruct1
{
    struct Persona 
    {
        public string nombre;
        public string email;
    }

    static void Main()
    {
        const int CAPACIDAD = 100;
        Persona[] personas = new Persona[CAPACIDAD];
        int cantidad = 0;

        const byte SALIR = 0, AGREGAR = 1, VER = 2;
        byte opcion;

        do
        {
            Console.WriteLine(AGREGAR + ". Añadir nuevo dato");
            Console.WriteLine(VER + ". Ver todos los datos");
            Console.WriteLine(SALIR + ". Salir");

            Console.WriteLine("Introduce número para seleccionar la opción");
            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case AGREGAR:
                    if (cantidad < CAPACIDAD)
                    {
                        Console.Write("Dime el nombre: ");
                        personas[cantidad].nombre = Console.ReadLine();

                        Console.Write("Dime su correo: ");
                        personas[cantidad].email = Console.ReadLine();

                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Ya no puedes añadir más");
                    }
                    break;

                case VER:
                    if (cantidad <= 0)
                    {
                        Console.WriteLine("No hay ningún dato");
                    }
                    else
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Nombre: " + personas[i].nombre);
                            Console.WriteLine("Correo: " + personas[i].email);
                            Console.WriteLine();
                        }
                    }
                    break;

                case SALIR:
                    Console.WriteLine("Programa finalizado");
                    break;

                default:
                    Console.WriteLine("Número no válido");
                    break;
            }
        }
        while (opcion != 0);
    }
}
