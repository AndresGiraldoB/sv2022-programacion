// Arrays: ejemplo 005, insertar y borrar en un sobredimensionado

using System;

class Arrays05
{
    static void Main()
    {
        const int MAXIMO = 1000;
        long[] datos = new long[MAXIMO];
        long dato;
        int cantidad = 0;

        long datoBuscar;
        bool encontrado;

        // Ejemplo de cómo añadir datos sueltos
        Console.Write("Dime el primer dato: ");
        datos[cantidad] = Convert.ToInt64(Console.ReadLine());
        cantidad++;

        Console.Write("Dime el segundo dato: ");
        datos[cantidad] = Convert.ToInt64(Console.ReadLine());
        cantidad++;

        Console.Write("Dime otro dato: ");
        datos[cantidad] = Convert.ToInt64(Console.ReadLine());
        cantidad++;

        // Ejemplo más realista, para añadir varios (hasta terminar con 0)
        do
        {
            Console.Write("Dime el dato " + (cantidad + 1) 
                + " (0 para terminar): ");
            dato = Convert.ToInt64(Console.ReadLine());
            if (dato != 0)
            {
                datos[cantidad] = dato;
                cantidad++;
            }
        }
        while (dato != 0);
        
        // Mostrar en orden inverso
        for (int i = cantidad-1; i >= 0; i--)
        {
            Console.Write(datos[i]+ " ");
        }
        Console.WriteLine();

        // Mostrar en orden directo, con for
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write(datos[i] + " ");
        }
        Console.WriteLine();


        // Buscar un dato elegido por el usuario, con booleano
        Console.Write("Dato a buscar? ");
        datoBuscar = Convert.ToInt64(Console.ReadLine());
        
        encontrado = false;
        for (int i = 0; i < cantidad; i++)
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

        // Mínimo
        long minimo = datos[0];
        for (int i = 1; i < cantidad; i++)
        {
            if (datos[i] < minimo)
            {
                minimo = datos[i];
            }
        }
        Console.WriteLine("Mínimo: " + minimo);

        // Insertar
        int posicionInsertar = 1;
        long valorInsertar = 15;

        for (int i = cantidad; i > posicionInsertar; i--)
        {
            datos[i] = datos[i - 1];
        }
        datos[posicionInsertar] = valorInsertar;
        cantidad++;

        // Mostrar para comprobar inserción
        for (int i = 0; i < cantidad; i++) Console.Write(datos[i] + " ");
        Console.WriteLine();


        // Borrar
        int posicionBorrar = 2;
        for (int i = posicionBorrar; i < cantidad-1; i++)
        {
            datos[i] = datos[i + 1];
        }
        cantidad--;

        // Mostrar para comprobar borrado
        for (int i = 0; i < cantidad; i++) Console.Write(datos[i] + " ");
        Console.WriteLine();
    }
}

