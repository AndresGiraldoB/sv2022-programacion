// Daniel (...)

/* 
75. Crea un array que permita almacenar hasta 100 nombres de personas, 
como primera aproximación para crear nuestra agenda personal. Deberás 
mostrar un menú que permita: Añadir un nuevo dato (al final de los existentes), 
ver todos los datos, buscar una persona, salir. La opción de Buscar preguntará el 
nombre a buscar y responderá si es parte de nuestra colección.
 */

using System;

class Ejercicios
{
    static void Main()
    {
        string[] nombres = new string[100];    
        int cantidad = 0;
        byte opcion;

        do
        {
            Console.WriteLine("1. Añadir un nuevo dato.");
            Console.WriteLine("2. Ver todos los datos.");
            Console.WriteLine("3. Buscar una persona.");
            Console.WriteLine("0. Salir.");

            opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 0: 
                    Console.WriteLine("Adiós."); 
                    break;

                case 1:
                    Console.Write("Nombre a introducir: ");
                    nombres[cantidad] = Console.ReadLine();
                    cantidad++;
                    break;

                case 2:
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write(nombres[i] + " ");
                    }
                    break;

                case 3:
                    Console.Write("Nombre a buscar: ");
                    string nombre = Console.ReadLine();

                    bool encontrado = false;
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (nombres[i] == nombre)
                        {
                            encontrado = true;
                        }
                    }

                    if (encontrado)
                    {
                        Console.WriteLine("{0} es parte de la colección.", nombre);
                    }
                    break;
            }
        }
        while (opcion != 0);
    }
}
