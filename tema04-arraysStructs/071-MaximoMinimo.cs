/*
    Luis (...)
    
    71. Crea un array de números reales de doble precisión, con espacio para 20 
    datos. Pide al usuario esos 20 datos y luego muestra un menú que le 
    permita: Ver todos los datos en su orden original, ver todos los datos en 
    orden inverso, mostrar el máximo de los datos, mostrar el mínimo de los 
    datos, buscar un cierto dato, salir. La opción de Buscar preguntará el dato 
    que se quiere localizar y responderá si ese dato era parte de los 20 
    iniciales o no.
    
*/

using System;

class ejercicio71
{
    static void Main()
    {
        
        const byte MAX = 20;
        double[] array = new double[MAX];
        
        byte opcion;
        
        for (int i = 0; i < MAX; i++)
        {
            Console.WriteLine("Introduce un número real ({0} de {1}) ",
                i+1, MAX);
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        do
        {
            Console.WriteLine();
            Console.WriteLine("Elige una opción (0 para salir): ");
            Console.WriteLine();
            Console.WriteLine(" 1. Ver datos en orden original.");
            Console.WriteLine(" 2. Ver datos en orden inverso.");       
            Console.WriteLine(" 3. Ver el máximo.");        
            Console.WriteLine(" 4. Ver el mínimo.");
            Console.WriteLine(" 5. Buscar un dato.");
            Console.WriteLine();        
            Console.WriteLine(" 0. Salir.");        
            Console.WriteLine();
            Console.Write("Opción: ");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            
            switch (opcion)
            {
                case 1:
                    for (int i = 0; i < MAX; i++)
                        Console.Write(array[i] + " ");
                    Console.WriteLine();
                    break;

                case 2:
                    for (int i = MAX -1; i >= 0; i--)
                        Console.Write(array[i] + " ");
                    Console.WriteLine();
                    break;

                case 3:
                    double maximo = array[0];
                    for (int i = 1; i < MAX; i++)
                        if (array[i] > maximo)
                            maximo = array[i];
                    Console.WriteLine("El número máximo es: {0}.", maximo); 
                    break;

                case 4:
                    double minimo = array[0];
                    for (int i = 1; i < MAX; i++)
                        if (array[i] < minimo)
                            minimo = array[i];
                    Console.WriteLine("El número mínimo es: {0}.", minimo);                     
                    break;

                case 5:
                    double buscar;
                    bool encontrado = false;
                    Console.Write("Introduce un número a buscar: ");
                    buscar = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < MAX; i++)
                        if (array[i] == buscar)
                            encontrado = true;
                    if (encontrado == true)
                        Console.Write("El número se ha encontrado.");
                    else
                        Console.Write("El número no se ha encontrado.");
                    break;

                default:
                    Console.Write("Opción no válida.");
                    break;  
            }
        }
        while(opcion != 0);       
    }
}       
