// Arrays: ejemplo 003, hallar el mínimo

using System;

class Arrays03
{
    static void Main()
    {
        long[] datos = new long[5];
        long datoBuscar;
        bool encontrado;
        int cantidadApariciones;

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

        // Buscar un dato elegido por el usuario, con booleano
        Console.Write("Dato a buscar? ");
        datoBuscar = Convert.ToInt64(Console.ReadLine());
        
        encontrado = false;
        for (int i = 0; i < datos.Length; i++)
        {
            if (datos[i] == datoBuscar)
            {
                encontrado = true;
            }
        }

        if (encontrado)
            Console.WriteLine("Encontrado");
        else
            Console.WriteLine("No encontrado");

        // Buscar con contador
        cantidadApariciones = 0;
        foreach(long d in datos)
        {
            if (d == datoBuscar)
            {
                cantidadApariciones ++;
            }
        }

        Console.WriteLine("Encontrado {0} veces", cantidadApariciones);

        // Mínimo
        long minimo = datos[0];
        for (int i = 1; i < datos.Length; i++)
        {
            if (datos[i] < minimo)
            {
                minimo = datos[i];
            }
        }
        Console.WriteLine("Mínimo: " + minimo);

    }
}
