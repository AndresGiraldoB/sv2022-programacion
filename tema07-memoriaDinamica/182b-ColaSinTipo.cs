/*182. Haz una variante del ejercicio anterior, en la que los datos no se 
introduzcan en una pila, sino en una cola, de modo que se obtendrán en el mismo 
orden inverso en que se introdujeron. Nuevamente, puedes usar una pila con tipo 
o sin tipo (se compartirán las dos soluciones).

Fátima (..) */

using System;
using System.Collections;

class Ejercicio182b
{
    static void Main()
    {
        string respuesta;
        int cantidad = 0;
        float sumaTotal = 0;
        Queue cola = new Queue();

        Console.WriteLine("Pulsa \"Enter\" cuando quieras dejar de insertar datos");
        do
        {
            Console.Write("Dime un número: ");
            respuesta = Console.ReadLine();
            if (respuesta != "")
            {
                cola.Enqueue(Convert.ToSingle(respuesta));
            }
        } while (respuesta != "");

        cantidad = cola.Count;
        while (cola.Count > 0)
        {
            float numero = (float) cola.Dequeue();
            Console.WriteLine(numero);
            sumaTotal += numero;
        }
        float media = sumaTotal / cantidad;

        Console.WriteLine("La suma de todos los números almacenados es: {0}", sumaTotal);
        Console.WriteLine("La media de todos los números almacenados es: {0}", media);
    }
}
