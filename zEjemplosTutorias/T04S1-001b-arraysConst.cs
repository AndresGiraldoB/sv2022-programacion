// Arrays: contacto (versión B: con CONST)

using System;

class Arrays01b
{
    static void Main()
    {
        // Declarar y reservar espacio
        const int TAMANYO = 10;
        long[] datos = new long[TAMANYO];

        // Pedir datos
        for (int i = 0; i < TAMANYO; i++)
        {
            Console.Write("Dime el dato "+ (i+1) +": ");
            datos[i] = Convert.ToInt64(Console.ReadLine());
        }

        // Mostrar en orden inverso
        for (int i = TAMANYO-1; i >= 0; i--)
        {
            Console.Write(datos[i]+ " ");
        }
        Console.WriteLine();

        // Mostrar en orden directo, con for
        for (int i = 0; i < TAMANYO; i++)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();

        // Mostrar en orden directo, con foreach
        foreach (long d in datos)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();
    }
}

