// Ejemplo de parámetros "out" para devolver 2 valores

using System;

class EjercicioDobleYTriple2
{
    static void DobleYTriple(
        int n, out int doble, out int triple)
    {
        doble = n * 2;
        triple = n * 3;
    }

    static void Main()
    {
        int dato = 5;
        int d, t;  // No es necesario indicar un valor inicial

        DobleYTriple(dato, out d, out t);
        Console.WriteLine("El doble es {0}, el triple {1}",
            d, t);
        
    }


}

