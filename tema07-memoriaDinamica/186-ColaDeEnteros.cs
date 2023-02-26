// Juan Manuel (...) 1º DAM Semipresencial

/*
186. Crea una clase "ColaDeEnteros", que permita encolar (usando un método
"Enqueue") números enteros, desencolarlos (con un método "Dequeue") y saber
cuántos datos hay (con una propiedad "Count"). Internamente debe emplear
una List<int>. Incluye un Main que permita probarla, añadiendo 3 datos,
comprobando su cantidad y extrayéndolos. Si cambias la llamada al constructor
(por ejemplo "ColaDeEnteros cola = new ColaDeEnteros()") por 
"Queue<int> pila = new Queue<int>();", el programa deberá funcionar
correctamente.
*/


using System;
using System.Collections.Generic;

internal class ColaDeEnteros
{
    public List<int> lista = new List<int>();
    public int Count { get { return lista.Count; } }

    public int Dequeue()
    {
        int result = lista[0];
        lista.RemoveAt(0);
        return result;
    }

    public void Enqueue(int value)
    {
        lista.Add(value);
    }
}


class Ejercicio186
{
    static void Main()
    {
        //Queue<int> cola = new Queue<int>();
        ColaDeEnteros cola = new ColaDeEnteros();
        Console.WriteLine("Cantidad: " + cola.Count);
        cola.Enqueue(1);
        cola.Enqueue(2);
        cola.Enqueue(3);
        Console.WriteLine("Cantidad: " + cola.Count);
        Console.WriteLine();
        Console.WriteLine(cola.Dequeue());
        Console.WriteLine(cola.Dequeue());
        Console.WriteLine(cola.Dequeue());
        Console.WriteLine();
        Console.WriteLine("Cantidad: " + cola.Count);
    }
}
