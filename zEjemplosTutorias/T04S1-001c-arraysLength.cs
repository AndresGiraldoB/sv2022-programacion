// Arrays: contacto (versión C: con ".Length")

using System;

class Arrays01c
{
    static void Main()
    {
        // Declarar y reservar espacio
        long[] datos = new long[5];

        // Pedir datos
        for (int i = 0; i < datos.Length; i++)
        {
            Console.Write("Dime el dato "+ (i+1) +": ");
            datos[i] = Convert.ToInt64(Console.ReadLine());
        }

        // Mostrar en orden inverso
        for (int i = datos.Length-1; i >= 0; i--)
        {
            Console.Write(datos[i]+ " ");
        }
        Console.WriteLine();

        // Mostrar en orden directo, con for
        for (int i = 0; i < datos.Length; i++)
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
