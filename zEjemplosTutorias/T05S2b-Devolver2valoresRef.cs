// Ejemplo de parámetros "ref" para devolver 2 valores

using System;

class EjercicioDobleYTriple
{
    static void DobleYTriple(
        int n, ref int doble, ref int triple)
    {
        doble = n * 2;
        triple = n * 3;
    }

    static void Main()
    {
        int dato = 5;
        int d=0, t=12344321; // Valores iniciales: arbitrarios

        DobleYTriple(dato, ref d, ref t);
        Console.WriteLine("El doble es {0}, el triple {1}",
            d, t);
        
    }


}

