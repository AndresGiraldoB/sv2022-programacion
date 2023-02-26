/*185. Crea una clase "PilaDeEnteros", que permita apilar (usando un método 
"Push") números enteros, obtenerlos (con un método "Pop") y saber cuántos datos 
hay (con una propiedad "Count"). Internamente debe emplear un array de enteros. 
Incluye un Main que permita probarla, añadiendo 3 datos, comprobando su 
cantidad y extrayéndolos. Si cambias la llamada al constructor (por ejemplo 
"PilaDeEnteros pila = new PilaDeEnteros()") por "Stack<int> pila = new 
Stack<int>();", el programa deberá funcionar correctamente.

 Alumno: Omar (...) */

using System;
using System.Collections.Generic;

class PilaDeEnteros
{
    private const int MAX = 1000;
    private int[] enteros = new int[MAX];
    private int cantidad = 0;

    public int Count { get { return cantidad; } }

    public void Push(int numero)
    {
        for (int i = Count; i > 0; i--)
            enteros[i] = enteros[i - 1];

        enteros[0] = numero;
        cantidad++;
    }

    public int Pop()
    {
        int extraido = enteros[0];

        for (int i = 0; i < Count; i++)
        {
            enteros[i] = enteros[i + 1];
        }

        cantidad--;

        return extraido;
    }

    static void Main()
    {
        //Con un objeto pila1
        PilaDeEnteros pila1 = new PilaDeEnteros();
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Numero? ");
            pila1.Push(Convert.ToInt32(Console.ReadLine()));
        }

        while (pila1.Count > 0)
            Console.WriteLine(pila1.Pop());

        Console.WriteLine();

        //Con un Stack<int> pila2
        Stack<int> pila2 = new Stack<int>();
        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Numero? ");
            pila2.Push(Convert.ToInt32(Console.ReadLine()));
        }

        while (pila2.Count > 0)
            Console.WriteLine(pila2.Pop());
    }
}

