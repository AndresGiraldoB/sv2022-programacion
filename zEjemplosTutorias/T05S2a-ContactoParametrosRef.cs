// Contacto con parámetros "ref": duplicar una variable

using System;

class EjercicioDuplicar
{
    // El planteamiento "esperable"
    static int Duplicar(int n)
    {
        return n * 2;
    }

    // Si intentamos modificar un parámetro, 
    // los cambios se pierden al salir
    static void Duplicar2(int n)
    {
        n = n * 2;
    }

    // Si el parámetro es "ref", los cambios se conservan
    static void Duplicar3(ref int n)
    {
        n = n * 2;
    }

    // Forma alternativa de obtener un resultado
    // (no deseable: usaremos "ref" para devolver 2 o más valores,
    // no para uno solo)
    static void NumeroPi(out float n)
    {
        n = 3.141592f;
    }

    // Programa de prueba
    static void Main()
    {
        int dato = 5;
        dato = Duplicar(dato);
        Console.WriteLine( dato );

        Duplicar2(dato);
        Console.WriteLine(dato);

        Duplicar3(ref dato);
        Console.WriteLine(dato);

        float pi;
        NumeroPi(out pi);
        Console.WriteLine(pi);
    }
}
