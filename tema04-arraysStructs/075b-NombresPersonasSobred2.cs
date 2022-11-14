/* 75. Crea un array que permita almacenar hasta 100 nombres de 
* personas, como primera aproximación para crear nuestra agenda personal. 
* Deberás mostrar un menú que permita: Añadir un nuevo dato (al final de 
* los existentes), ver todos los datos, buscar una persona, salir. La 
* opción de Buscar preguntará el nombre a buscar y responderá si es parte 
* de nuestra colección.
* 
* Radha */

using System;

class Ejercicio75
{
    static void Main()
    {
        const int CAPACIDAD = 100;
        string[] nombres = new string[CAPACIDAD];
        int cantidad=0;
        
        const byte SALIR = 0, AGREGAR = 1, VER = 2, BUSCAR = 3;
        byte opcion;
        
        string persona;
        bool encontrado = false;
        
        do
        {
            Console.WriteLine(AGREGAR + ". Añadir nuevo dato");
            Console.WriteLine(VER + ". Ver todos los datos");
            Console.WriteLine(BUSCAR + ". Buscar persona");
            Console.WriteLine(SALIR + ". Salir");
        
            Console.WriteLine("Introduce número para seleccionar la opción");
            opcion = Convert.ToByte(Console.ReadLine());
            
            switch(opcion)
            {
                case AGREGAR:
                    if(cantidad < CAPACIDAD)
                    {
                        Console.WriteLine("¿Qué nombre vas a añadir?");
                        nombres[cantidad] = Console.ReadLine();
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Ya no puedes añadir más");
                    }
                    break;

               case BUSCAR:
                    Console.WriteLine("¿Qué persona buscas?");
                    persona = Console.ReadLine();
                    for(int i = 0; i < nombres.Length; i++)
                    {
                        if(nombres[i] == persona)
                        {
                            encontrado = true;
                        }
                    }
                    if(encontrado == true)
                    {
                        Console.WriteLine("Es parte de la colección");
                    }
                    else
                    {
                        Console.WriteLine("No es parte de la colección");
                    }
                    encontrado = false;
                    break;

               case VER:
                    if(cantidad == 0)
                    {
                        Console.WriteLine("No hay ningún dato");
                    }
                    if(cantidad > 0)
                    {
                        for(int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine(nombres[i]);
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
        while(opcion != 0);
    }
}
