// Víctor Raúl (...)
/*
73. Crea un programa que pregunte al usuario cuántos datos (enteros cortos sin signo)
 va a introducir, reserve espacio para todos ellos, se los pida al usuario y 
 finamente muestre los números que estén duplicados (pista: deberás comparar 
 cada dato con todos los posteriores). Por ejemplo, si los números 
 son 12 23 36 23 45, la respuesta sería "Duplicados: 23". Si no hubiera 
 ningún duplicado, la respuesta deberá ser "Duplicados: Ninguno". Si algún 
 dato aparece más de dos veces (por ejemplo, 12 23 36 23 45 23) puede 
 que la respuesta sea "fea": "Duplicados: 23 23".
*/

using System;

class Ejercicio73
{
    static void Main()
    {
        int num_elementos;
        bool existeDuplicado = false;

        Console.Write("Introduce el número de datos que desea insertar: ");
        num_elementos = Convert.ToInt32(Console.ReadLine());

        ushort[] datos = new ushort[num_elementos];


        for (int i = 0; i < num_elementos; i++)
        {
            Console.Write("Dato. {0} ? ", i + 1);
            datos[i] = Convert.ToUInt16(Console.ReadLine());
        }

        Console.Write("Duplicados: ");

        for (int i = 0; i < num_elementos - 1; i++)
        {
            for (int j = i + 1; j < num_elementos; j++)
            {
                if (datos[i] == datos[j])
                {
                    Console.Write(datos[i] + " ");
                    existeDuplicado = true;
                }
            }
        }
        if ( ! existeDuplicado ) Console.Write("Ninguno");
    }
}
