// DAN 1DAW

/*
181. Pide al usuario números reales de simple precisión, tantos como desee, 
hasta que pulse Intro en vez de un número. Cada nuevo número lo deberás guardar 
en una pila. Finalmente, mostrarás todos los datos que ha introducido 
(en orden inverso), así como su suma y su media. Puedes emplear una pila con 
tipo -Generics- o sin tipo, como prefieras (se compartirán ambas soluciones, 
para que puedas comparar).
*/

using System;
using System.Collections;

class PilaDeFloat1
{
    static void Main()
    {
        Stack pila = new Stack();
        string opcion;
        bool terminar = false;
        float suma = 0, media;
        int cantidad;

        do
        {
            Console.Write("Dime un número o pulsa Intro para terminar: ");
            opcion = Console.ReadLine();

            if (opcion != "")
            {
                pila.Push(Convert.ToSingle(opcion));
            }
            else
            {
                terminar = true;
            }
        }
        while (!terminar);
        cantidad = pila.Count;

        Console.WriteLine("Contenido de la pila:");
        while (pila.Count > 0)
        {
            float dato = (float) pila.Pop();
            Console.WriteLine(dato);
            suma += dato;
        }
        media = suma / cantidad;

        Console.WriteLine("Suma de la pila: " + suma);
        Console.WriteLine("Media de la pila: " + media);
    }
}
