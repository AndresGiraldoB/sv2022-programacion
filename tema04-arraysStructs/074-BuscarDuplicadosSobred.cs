// Víctor Raúl (...)
/*
74. Crea una variante del programa anterior, que no pregunte al usuario cuántos
datos, sino que reserve espacio para 1000 datos, y permita al usuario introducir
varios datos, hasta introducir un 0, que no se guardará sino que servirá para
indicar al programa que no se desea introducir más datos (pista: recuerda que
deberás llevar un contador de cuántos datos hay realmente en el fichero).
Cuando estén todos los datos introducidos, procederá como la versión anterior,
buscando y mostrando los duplicados.
*/

using System;

class Ejercicio74
{
    static void Main()
    {
        int num_elementos = 0;
        bool existeDuplicado = false;
        ushort[] datos = new ushort[1000];
        ushort valor;

        Console.WriteLine("Introduzca numeros (0:FINALIZAR)");

        do
        {
            Console.Write("Dato. {0}? ", num_elementos);
            valor = Convert.ToUInt16(Console.ReadLine());
            if (valor != 0)
            {
                datos[num_elementos] = valor;
                num_elementos++;
            }

        } while (valor != 0 && num_elementos < 1000);

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
